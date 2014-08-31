Imports VideoClubEntidades
Imports System.Data.SqlClient

Public Class DatosAlquileres

    Private datos As Datos
    Private sqlParamaters() As SqlParameter
    Private sqlTrans As SqlTransaction

    Public Sub New()
        Try
            Me.datos = New Datos()
            Me.datos.abrirConexion()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub cargarAlquileres(ByVal idcliente As Integer, ByVal dtAlquileres As DataTable)
        Try
            Me.sqlParamaters = New SqlParameter(0) {}
            Me.sqlParamaters(0) = New SqlParameter("@idCliente", SqlDbType.Int)
            Me.sqlParamaters(0).Direction = ParameterDirection.Input
            Me.sqlParamaters(0).Value = idcliente
            Me.datos.cargarTablasALQ_COMPRAS("DatosAlquileres", dtAlquileres, Me.sqlParamaters)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#Region "TRANSACCIONES PARA ALQUILERES, CATALOGO"

    Public Sub altaAlquileres(ByVal alq As Alquiler, ByVal dtCatalogo As DataTable)
        Try
            Me.sqlTrans = Me.datos.ConnectionSQL.BeginTransaction()
            Me.sqlParamaters = New SqlParameter(5) {}
            Me.sqlParamaters(0) = New SqlParameter("@tipoPago", SqlDbType.VarChar, 50)
            Me.sqlParamaters(0).Direction = ParameterDirection.Input
            Me.sqlParamaters(0).Value = alq.TIPO_PAGO
            Me.sqlParamaters(1) = New SqlParameter("@totalAlquiler", SqlDbType.Float)
            Me.sqlParamaters(1).Direction = ParameterDirection.Input
            Me.sqlParamaters(1).Value = alq.TOTAL_ALQUILER
            Me.sqlParamaters(2) = New SqlParameter("@fecha", SqlDbType.Date)
            Me.sqlParamaters(2).Direction = ParameterDirection.Input
            Me.sqlParamaters(2).Value = alq.FECHA_INICIAL
            Me.sqlParamaters(3) = New SqlParameter("@fechafinal", SqlDbType.Date)
            Me.sqlParamaters(3).Direction = ParameterDirection.Input
            Me.sqlParamaters(3).Value = alq.FECHA_FINAL
            Me.sqlParamaters(4) = New SqlParameter("@idcliente", SqlDbType.Int)
            Me.sqlParamaters(4).Direction = ParameterDirection.Input
            Me.sqlParamaters(4).Value = alq.ID_CLIENTE
            Me.sqlParamaters(5) = New SqlParameter("@idAlquiler", SqlDbType.Int)
            Me.sqlParamaters(5).Direction = ParameterDirection.Output
            Me.datos.abmAlquileres_Compras("guardarAlquiler", Me.sqlParamaters, Me.sqlTrans)
            Dim idAlquiler As Integer = Me.sqlParamaters(5).Value
            altaLista(alq, idAlquiler)
            cambiarStockPeliculasLlevadas(alq)
            actualizarCatalogo(dtCatalogo)
            Me.sqlTrans.Commit()
            Me.datos.close()
        Catch ex As Exception
            Me.sqlTrans.Rollback()
            Me.datos.close()
            Throw ex
        End Try
    End Sub

    Private Sub altaLista(ByVal alq As Alquiler, ByVal idAlquiler As Integer)
        Try
            Me.sqlParamaters = New SqlParameter(1) {}
            For Each peli As Pelicula In alq.PropiedadPelicula
                Me.sqlParamaters(0) = New SqlParameter("@idPelicula", SqlDbType.Int)
                Me.sqlParamaters(0).Direction = ParameterDirection.Input
                Me.sqlParamaters(0).Value = peli.ID_PELICULA
                Me.sqlParamaters(1) = New SqlParameter("@idAlquiler", SqlDbType.Int)
                Me.sqlParamaters(1).Direction = ParameterDirection.Input
                Me.sqlParamaters(1).Value = idAlquiler
                Me.datos.abmAlquileres_Compras("altaPeliculasAlquiler", Me.sqlParamaters, Me.sqlTrans)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cambiarStockPeliculasLlevadas(ByVal alq As Alquiler)
        Try
            Me.sqlParamaters = New SqlParameter(1) {}
            For Each peli As Pelicula In alq.PropiedadPelicula
                Me.sqlParamaters(0) = New SqlParameter("@idPelicula", SqlDbType.Int)
                Me.sqlParamaters(0).Direction = ParameterDirection.Input
                Me.sqlParamaters(0).Value = peli.ID_PELICULA
                Me.sqlParamaters(1) = New SqlParameter("@cant", SqlDbType.Int)
                Me.sqlParamaters(1).Direction = ParameterDirection.Input
                Me.sqlParamaters(1).Value = 0
                Me.datos.abmAlquileres_Compras("ModificacionCantidadPeliculasrLlevadas", Me.sqlParamaters, Me.sqlTrans)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub actualizarCatalogo(ByVal dtCatalogo As DataTable)
        Try
            Me.datos.actualizarCatalogoTran("CargarDatosPeliculas", dtCatalogo, Me.sqlTrans)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub fechaAlquilerDevolucion(ByVal idcliente As Integer, ByVal idAlquiler As Integer, ByVal fechadevolucion As Date, ByVal idPelicula As Integer, ByVal dtAlq As DataTable, ByVal dtCatalogo As DataTable)
        Try
            Me.sqlTrans = Me.datos.ConnectionSQL.BeginTransaction()
            Me.sqlParamaters = New SqlParameter(1) {}
            Me.sqlParamaters(0) = New SqlParameter("@idAlquiler", SqlDbType.Int)
            Me.sqlParamaters(0).Direction = ParameterDirection.Input
            Me.sqlParamaters(0).Value = idAlquiler
            Me.sqlParamaters(1) = New SqlParameter("@fechaDevolucion", SqlDbType.Date)
            Me.sqlParamaters(1).Direction = ParameterDirection.Input
            Me.sqlParamaters(1).Value = fechadevolucion
            Me.datos.abmAlquileres_Compras("ModificacionFechafinalAlq", Me.sqlParamaters, Me.sqlTrans)
            cambiarStockPeliculaDevueltas(idPelicula)
            actualizarAlq(idcliente, dtAlq)
            actualizarCatalogo(dtCatalogo)
            Me.sqlTrans.Commit()
            Me.datos.close()
        Catch ex As Exception
            Me.sqlTrans.Rollback()
            Me.datos.close()
            Throw ex
        End Try
    End Sub

    Private Sub cambiarStockPeliculaDevueltas(ByVal idPelicula As Integer)
        Try
            Me.sqlParamaters = New SqlParameter(1) {}
            Me.sqlParamaters(0) = New SqlParameter("@idPelicula", SqlDbType.Int)
            Me.sqlParamaters(0).Direction = ParameterDirection.Input
            Me.sqlParamaters(0).Value = idPelicula
            Me.sqlParamaters(1) = New SqlParameter("@cant", SqlDbType.Int)
            Me.sqlParamaters(1).Direction = ParameterDirection.Input
            Me.sqlParamaters(1).Value = 0
            Me.datos.abmAlquileres_Compras("ModificacionCantidadPeliculasDevueltas", Me.sqlParamaters, Me.sqlTrans)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub actualizarAlq(ByVal idcliente As Integer, ByVal dtAlquileres As DataTable)
        Try
            Me.sqlParamaters = New SqlParameter(0) {}
            Me.sqlParamaters(0) = New SqlParameter("@idCliente", SqlDbType.Int)
            Me.sqlParamaters(0).Direction = ParameterDirection.Input
            Me.sqlParamaters(0).Value = idcliente
            Me.datos.actualizarAlqTrans("DatosAlquileres", dtAlquileres, Me.sqlParamaters, Me.sqlTrans)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region




  
End Class

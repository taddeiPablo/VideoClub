Imports VideoClubEntidades
Imports System.Data.SqlClient

Public Class DatosCompras

    Private datos As Datos
    Private sqlParameters() As SqlParameter
    Private sqlTrans As SqlTransaction

    Public Sub New()
        Try
            Me.datos = New Datos()
            Me.datos.abrirConexion()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="idcliente"></param>
    ''' <param name="dtCompras"></param>
    ''' <remarks></remarks>
    Public Sub cargarCompras(ByVal idcliente As Integer, ByVal dtCompras As DataTable)
        Try
            Me.sqlParameters = New SqlParameter(0) {}
            Me.sqlParameters(0) = New SqlParameter("@idCliente", SqlDbType.Int)
            Me.sqlParameters(0).Direction = ParameterDirection.Input
            Me.sqlParameters(0).Value = idcliente
            Me.datos.cargarTablasALQ_COMPRAS("DatosCompras", dtCompras, Me.sqlParameters)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub cargarVistaCompras(ByVal dtVistaCompras As DataTable)
        Try
            Me.datos.cargarTablaVista("DatosVista", dtVistaCompras)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


#Region "TRANSACCIONES"

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="comp"></param>
    ''' <remarks></remarks>
    Public Sub AltaCompra(ByVal comp As Compra, ByVal dtCatalogo As DataTable)
        Try
            Me.sqlTrans = Me.datos.ConnectionSQL.BeginTransaction()
            Me.sqlParameters = New SqlParameter(5) {}
            Me.sqlParameters(0) = New SqlParameter("@TipodePago", SqlDbType.VarChar, 50)
            Me.sqlParameters(0).Direction = ParameterDirection.Input
            Me.sqlParameters(0).Value = comp.TIPO_PAGO
            Me.sqlParameters(1) = New SqlParameter("@Total", SqlDbType.Float)
            Me.sqlParameters(1).Direction = ParameterDirection.Input
            Me.sqlParameters(1).Value = comp.TOTAL_NETO
            Me.sqlParameters(2) = New SqlParameter("@TotalCompra", SqlDbType.Float)
            Me.sqlParameters(2).Direction = ParameterDirection.Input
            Me.sqlParameters(2).Value = comp.TOTAL_COMPRA
            Me.sqlParameters(3) = New SqlParameter("@FechadeCompra", SqlDbType.Date)
            Me.sqlParameters(3).Direction = ParameterDirection.Input
            Me.sqlParameters(3).Value = comp.FECHA_COMPRA
            Me.sqlParameters(4) = New SqlParameter("@IdCliente", SqlDbType.Int)
            Me.sqlParameters(4).Direction = ParameterDirection.Input
            Me.sqlParameters(4).Value = comp.ID_CLIENTE
            Me.sqlParameters(5) = New SqlParameter("@IdCompra", SqlDbType.Int)
            Me.sqlParameters(5).Direction = ParameterDirection.Output
            Me.datos.abmAlquileres_Compras("AltaComprasCliente", Me.sqlParameters, Me.sqlTrans)
            Dim idcompra As Integer = Me.sqlParameters(5).Value
            altaListaCompra(comp, idcompra)
            cambiarStockCatalogo(comp)
            actualizarCatalogo(dtCatalogo)
            Me.sqlTrans.Commit()
            Me.datos.close()
        Catch ex As Exception
            Me.sqlTrans.Rollback()
            Me.datos.close()
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="comp"></param>
    ''' <param name="idcompra"></param>
    ''' <remarks></remarks>
    Private Sub altaListaCompra(ByVal comp As Compra, ByVal idcompra As Integer)
        Try
            Me.sqlParameters = New SqlParameter(1) {}
            For Each peli As Pelicula In comp.PELICULA_PROPERTY
                Me.sqlParameters(0) = New SqlParameter("@IdPelicula", SqlDbType.Int)
                Me.sqlParameters(0).Direction = ParameterDirection.Input
                Me.sqlParameters(0).Value = peli.ID_PELICULA
                Me.sqlParameters(1) = New SqlParameter("@idCompra", SqlDbType.Int)
                Me.sqlParameters(1).Direction = ParameterDirection.Input
                Me.sqlParameters(1).Value = idcompra
                Me.datos.abmAlquileres_Compras("AltaPeliculasCompra", Me.sqlParameters, Me.sqlTrans)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cambiarStockCatalogo(ByVal comp As Compra)
        Try
            Me.sqlParameters = New SqlParameter(1) {}
            For Each peli As Pelicula In comp.PELICULA_PROPERTY
                Me.sqlParameters(0) = New SqlParameter("@idPelicula", SqlDbType.Int)
                Me.sqlParameters(0).Direction = ParameterDirection.Input
                Me.sqlParameters(0).Value = peli.ID_PELICULA
                Me.sqlParameters(1) = New SqlParameter("@cant", SqlDbType.Int)
                Me.sqlParameters(1).Direction = ParameterDirection.Input
                Me.sqlParameters(1).Value = 0
                Me.datos.abmAlquileres_Compras("ModificacionCantidadPeliculasrLlevadas", Me.sqlParameters, Me.sqlTrans)
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


#End Region



End Class

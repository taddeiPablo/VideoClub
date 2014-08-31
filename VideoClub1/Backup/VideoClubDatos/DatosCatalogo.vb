Imports System.Data.SqlClient
Imports VideoClubEntidades


Public Class DatosCatalogo

    Private datosCatalogo As Datos
    Private SqlParameters() As SqlClient.SqlParameter

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Try
            Me.datosCatalogo = New Datos()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' METODO EN DONDE CARGAMOS LOS DATOS DEL CATALOGO EN LA GRILLA.
    ''' </summary>
    ''' <param name="dtCalatolo">RESIVE UN DATATABLE</param>
    ''' <remarks></remarks>
    Public Sub cargarCatalogo(ByVal dtCalatolo As DataTable)
        Try
            Me.datosCatalogo.cargarTablas("CargarDatosPeliculas", dtCalatolo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' METODO EN DONDE CONFIGURAMOS LOS PARAMATROS SQL.
    ''' AQUI VERIFICAMOS SI LA PELICULA QUE ESTAMOS POR GUARDAR YA EXISTE EN EL CATALOGO
    ''' </summary>
    ''' <param name="titulo">RESIVE UN TITULO</param>
    ''' <returns>RETORNA ESTRING</returns>
    ''' <remarks></remarks>
    Public Function ExistePelicula(ByVal titulo As String) As String
        Try
            Me.SqlParameters = New SqlParameter(1) {}
            Me.SqlParameters(0) = New SqlParameter("@Titulo", SqlDbType.VarChar, 50)
            Me.SqlParameters(0).Direction = ParameterDirection.Input
            Me.SqlParameters(0).Value = titulo
            Me.SqlParameters(1) = New SqlParameter("@validar", SqlDbType.VarChar, 50)
            Me.SqlParameters(1).Direction = ParameterDirection.Output
            Return Me.datosCatalogo.existePelicula("ExitePelicula", Me.SqlParameters)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' METODO EN DONDE CONFIGURAMOS LOS PARAMETROS SQL.
    ''' PARA CAMBIAR EL CAMPO POR EL CUAL SE DETERMINA SI FUE BORRADA O NO
    ''' </summary>
    ''' <param name="titulo">RESIVE EL TITULO DE LA PELICULA</param>
    ''' <remarks></remarks>
    Public Sub cambiarCampoPelicula(ByVal titulo As String)
        Try
            Me.SqlParameters = New SqlParameter(1) {}
            Me.SqlParameters(0) = New SqlParameter("@titulo", SqlDbType.VarChar, 50)
            Me.SqlParameters(0).Direction = ParameterDirection.Input
            Me.SqlParameters(0).Value = titulo
            Me.SqlParameters(1) = New SqlParameter("@borrada", SqlDbType.VarChar, 50)
            Me.SqlParameters(1).Direction = ParameterDirection.Input
            Me.SqlParameters(1).Value = "no"
            Me.datosCatalogo.Abm("ModCampoBorrada", Me.SqlParameters)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' METODO EN DONDE CONFIGURAMOS LOS PARAMETROS SQL.
    ''' AQUI HACEMOS UN ALTA DE PELICULAS
    ''' </summary>
    ''' <param name="unaPelicula"></param>
    ''' <remarks></remarks>
    Public Sub altaPelicula(ByVal unaPelicula As Pelicula)
        Try
            Me.SqlParameters = New SqlParameter(7) {}
            Me.SqlParameters(0) = New SqlParameter("@titulo", SqlDbType.VarChar, 50)
            Me.SqlParameters(0).Direction = ParameterDirection.Input
            Me.SqlParameters(0).Value = unaPelicula.Titulo_Pelicula
            Me.SqlParameters(1) = New SqlParameter("@genero", SqlDbType.VarChar, 50)
            Me.SqlParameters(1).Direction = ParameterDirection.Input
            Me.SqlParameters(1).Value = unaPelicula.Genero_Pelicula
            Me.SqlParameters(2) = New SqlParameter("@formato", SqlDbType.VarChar, 50)
            Me.SqlParameters(2).Direction = ParameterDirection.Input
            Me.SqlParameters(2).Value = unaPelicula.Formato_Pelicula
            Me.SqlParameters(3) = New SqlParameter("@precioAlquiler", SqlDbType.Float)
            Me.SqlParameters(3).Direction = ParameterDirection.Input
            Me.SqlParameters(3).Value = unaPelicula.PrecioAlquiler_Pelicula
            Me.SqlParameters(4) = New SqlParameter("@precioCompra", SqlDbType.Float)
            Me.SqlParameters(4).Direction = ParameterDirection.Input
            Me.SqlParameters(4).Value = unaPelicula.PrecioCompra_Pelicula
            Me.SqlParameters(5) = New SqlParameter("@imagen", SqlDbType.Image)
            Me.SqlParameters(5).Direction = ParameterDirection.Input
            Me.SqlParameters(5).Value = unaPelicula.IMAGEN_BYTES
            Me.SqlParameters(6) = New SqlParameter("@cantidad", SqlDbType.Int)
            Me.SqlParameters(6).Direction = ParameterDirection.Input
            Me.SqlParameters(6).Value = unaPelicula.Cantidad_Pelicula
            Me.SqlParameters(7) = New SqlParameter("@borrada", SqlDbType.VarChar, 50)
            Me.SqlParameters(7).Direction = ParameterDirection.Input
            Me.SqlParameters(7).Value = "no"
            Me.datosCatalogo.Abm("AltaPeliculas", Me.SqlParameters)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' METODO EN DONDE CONFIGURAMOS LOS PARAMETROS SQL.
    ''' AQUI HACEMOS UNA BAJA DE UNA PELICULA.
    ''' </summary>
    ''' <param name="idPelicula">RESIVE UN ID DE PELICULA</param>
    ''' <remarks></remarks>
    Public Sub bajaPelicula(ByVal idPelicula As Integer)
        Try
            Me.SqlParameters = New SqlParameter(1) {}
            Me.SqlParameters(0) = New SqlParameter("@idPelicula", SqlDbType.Int)
            Me.SqlParameters(0).Direction = ParameterDirection.Input
            Me.SqlParameters(0).Value = idPelicula
            Me.SqlParameters(1) = New SqlParameter("@borrado", SqlDbType.VarChar, 50)
            Me.SqlParameters(1).Direction = ParameterDirection.Input
            Me.SqlParameters(1).Value = "si"
            Me.datosCatalogo.Abm("BorrarPelicula", Me.SqlParameters)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' METODO EN DONDE CONFIGURAMOS LOS PARAMETROS SQL.
    ''' AQUI MODIFICAMOS UNA PELICULA.
    ''' </summary>
    ''' <param name="unaPelicula">RESIVE UNA PELICULA</param>
    ''' <remarks></remarks>
    Public Sub modificacionPelicula(ByVal unaPelicula As Pelicula)
        Try
            Me.SqlParameters = New SqlParameter(8) {}
            Me.SqlParameters(0) = New SqlParameter("@idPelicula", SqlDbType.Int)
            Me.SqlParameters(0).Direction = ParameterDirection.Input
            Me.SqlParameters(0).Value = unaPelicula.ID_PELICULA
            Me.SqlParameters(1) = New SqlParameter("@titulo", SqlDbType.VarChar, 50)
            Me.SqlParameters(1).Direction = ParameterDirection.Input
            Me.SqlParameters(1).Value = unaPelicula.Titulo_Pelicula
            Me.SqlParameters(2) = New SqlParameter("@genero", SqlDbType.VarChar, 50)
            Me.SqlParameters(2).Direction = ParameterDirection.Input
            Me.SqlParameters(2).Value = unaPelicula.Genero_Pelicula
            Me.SqlParameters(3) = New SqlParameter("@formato", SqlDbType.VarChar, 50)
            Me.SqlParameters(3).Direction = ParameterDirection.Input
            Me.SqlParameters(3).Value = unaPelicula.Formato_Pelicula
            Me.SqlParameters(4) = New SqlParameter("@precioAlquiler", SqlDbType.Float)
            Me.SqlParameters(4).Direction = ParameterDirection.Input
            Me.SqlParameters(4).Value = unaPelicula.PrecioAlquiler_Pelicula
            Me.SqlParameters(5) = New SqlParameter("@precioCompra", SqlDbType.Float)
            Me.SqlParameters(5).Direction = ParameterDirection.Input
            Me.SqlParameters(5).Value = unaPelicula.PrecioCompra_Pelicula
            Me.SqlParameters(6) = New SqlParameter("@imagen", SqlDbType.Image)
            Me.SqlParameters(6).Direction = ParameterDirection.Input
            Me.SqlParameters(6).Value = unaPelicula.IMAGEN_BYTES
            Me.SqlParameters(7) = New SqlParameter("@cantidad", SqlDbType.Int)
            Me.SqlParameters(7).Direction = ParameterDirection.Input
            Me.SqlParameters(7).Value = unaPelicula.Cantidad_Pelicula
            Me.SqlParameters(8) = New SqlParameter("@borrada", SqlDbType.VarChar, 50)
            Me.SqlParameters(8).Direction = ParameterDirection.Input
            Me.SqlParameters(8).Value = "no"
            Me.datosCatalogo.Abm("ModificacionPelicula", Me.SqlParameters)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

End Class

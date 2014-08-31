Imports System.Data.SqlClient
Imports VideoClubEntidades
Imports System.Xml


Public Class DatosClientes

    Private datosBd As Datos
    Private SqlParameters() As SqlClient.SqlParameter


    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Try
            Me.datosBd = New Datos()
        Catch ex As Exception
            Throw New Exception("ERROR : En el constructor de la clase" & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' METODO PARA CARGAR LOS CLIENTES EN LA GRILLA
    ''' ESTA ES LA CAPA DE DATOS.
    ''' </summary>
    ''' <param name="dtclientes">RESIVE UN DATATABLE</param>
    ''' <remarks></remarks>
    Public Sub cargarClientes(ByVal dtclientes As DataTable)
        Try
            Me.datosBd.cargarTablas("CargarDatos", dtclientes)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' METODO EN DONDE CONFIGURAMOS LOS PARAMETROS
    ''' SQL NESESARIOS PARA HACER LA CONSULTA A LA BASE DE DATOS
    ''' </summary>
    ''' <param name="dni">RESIVE EL DNI</param>
    ''' <returns>DEVUELVE UN ENTERO</returns>
    ''' <remarks></remarks>
    Public Function existeCliente(ByVal dni As String) As Integer
        Try
            Me.SqlParameters = New SqlParameter(1) {}
            Me.SqlParameters(0) = New SqlParameter("@dni", SqlDbType.Int)
            Me.SqlParameters(0).Direction = ParameterDirection.Input
            Me.SqlParameters(0).Value = dni
            Me.SqlParameters(1) = New SqlParameter("@valido", SqlDbType.Int)
            Me.SqlParameters(1).Direction = ParameterDirection.Output
            Return Me.datosBd.existe("ExisteCliente", Me.SqlParameters)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' METODO EN DONDE CONFIGURAMOS LOS PARAMETROS SQL NECESARIOS PARA HACER UN ALTA A LA BASE DE DATOS
    ''' </summary>
    ''' <param name="uncliente">RESIVE UN CLIENTE</param>
    ''' <remarks></remarks>
    Public Sub altaCliente(ByVal uncliente As Cliente)
        Try
            SqlParameters = New SqlClient.SqlParameter(5) {}
            SqlParameters(0) = New SqlParameter("@nombre", SqlDbType.VarChar, 50)
            SqlParameters(0).Direction = ParameterDirection.Input
            SqlParameters(0).Value = uncliente.Nombre_Cliente
            SqlParameters(1) = New SqlParameter("@apellido", SqlDbType.VarChar, 50)
            SqlParameters(1).Direction = ParameterDirection.Input
            SqlParameters(1).Value = uncliente.Apellido_Cliente
            SqlParameters(2) = New SqlParameter("@dni", SqlDbType.Int)
            SqlParameters(2).Direction = ParameterDirection.Input
            SqlParameters(2).Value = uncliente.DNI_Cliente
            SqlParameters(3) = New SqlParameter("@direccion", SqlDbType.VarChar, 50)
            SqlParameters(3).Direction = ParameterDirection.Input
            SqlParameters(3).Value = uncliente.Direccion_Cliente
            SqlParameters(4) = New SqlParameter("@telefono", SqlDbType.Int)
            SqlParameters(4).Direction = ParameterDirection.Input
            SqlParameters(4).Value = uncliente.Telefono_Cliente
            SqlParameters(5) = New SqlParameter("@email", SqlDbType.VarChar, 50)
            SqlParameters(5).Direction = ParameterDirection.Input
            SqlParameters(5).Value = uncliente.Email_Cliente
            Me.datosBd.Abm("altaClientes", SqlParameters)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' METODO DONDE CONFIGURAMOS LOS PARAMEROS SQL.
    ''' </summary>
    ''' <param name="idcliente">RESIVE EL ID DE UN CLIENTE</param>
    ''' <returns>RETORNA UN ENTERO</returns>
    ''' <remarks></remarks>
    Public Function existeAlquileresCompras(ByVal idcliente As Integer) As Integer
        Try
            Me.SqlParameters = New SqlParameter(1) {}
            Me.SqlParameters(0) = New SqlParameter("@idCliente", SqlDbType.Int)
            Me.SqlParameters(0).Direction = ParameterDirection.Input
            Me.SqlParameters(0).Value = idcliente
            Me.SqlParameters(1) = New SqlParameter("@verificar", SqlDbType.Int)
            Me.SqlParameters(1).Direction = ParameterDirection.Output
            Return Me.datosBd.existe("ExisteAlquileresCompras", Me.SqlParameters)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' METODO EN DONDE CONFIGURAMOS LOS PARAMETROS SQL.
    ''' AQUI REALIZAREMOS LA BAJA DE CLIENTES Y SU HISTORIAL
    ''' </summary>
    ''' <param name="uncliente">RESIVE UN CLIENTE</param>
    ''' <remarks></remarks>
    Public Sub bajaClienteAlquilresCompras(ByVal uncliente As Cliente)
        Try
            Me.SqlParameters = New SqlParameter(0) {}
            Me.SqlParameters(0) = New SqlParameter("@idCliente", SqlDbType.Int)
            Me.SqlParameters(0).Direction = ParameterDirection.Input
            Me.SqlParameters(0).Value = uncliente.IDcliente_Cliente
            Me.datosBd.Abm("borrarCliente", SqlParameters)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' METODO EN DONDE CONFIGURAMOS LOS PARAMETROS SQL.
    ''' AQUI REALIZAMOS LA BAJA DEL CLIENTE UNICAMENTE
    ''' </summary>
    ''' <param name="uncliente">RESIVE UN CLIENTE</param>
    ''' <remarks></remarks>
    Public Sub bajaCliente(ByVal uncliente As Cliente)
        Try
            Me.SqlParameters = New SqlParameter(0) {}
            Me.SqlParameters(0) = New SqlParameter("@idCliente", SqlDbType.Int)
            Me.SqlParameters(0).Direction = ParameterDirection.Input
            Me.SqlParameters(0).Value = uncliente.IDcliente_Cliente
            Me.datosBd.Abm("BorrarClienteUnicamente", Me.SqlParameters)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' METODO EN DONDE CONFIGURAMOS LOS PARAMETROS SQL.
    ''' AQUI REALIZAMOS UNA MODIFICACION DEL CLIENTE.
    ''' </summary>
    ''' <param name="uncliente">RESIVE UN CLIENTE</param>
    ''' <remarks></remarks>
    Public Sub modificacionCliente(ByVal uncliente As Cliente)
        Try
            Me.SqlParameters = New SqlParameter(6) {}
            Me.SqlParameters(0) = New SqlParameter("@idcliente", SqlDbType.Int)
            Me.SqlParameters(0).Direction = ParameterDirection.Input
            Me.SqlParameters(0).Value = uncliente.IDcliente_Cliente
            Me.SqlParameters(1) = New SqlParameter("@nombre", SqlDbType.VarChar, 50)
            Me.SqlParameters(1).Direction = ParameterDirection.Input
            Me.SqlParameters(1).Value = uncliente.Nombre_Cliente
            Me.SqlParameters(2) = New SqlParameter("@apellido", SqlDbType.VarChar, 50)
            Me.SqlParameters(2).Direction = ParameterDirection.Input
            Me.SqlParameters(2).Value = uncliente.Apellido_Cliente
            Me.SqlParameters(3) = New SqlParameter("@dni", SqlDbType.VarChar, 50)
            Me.SqlParameters(3).Direction = ParameterDirection.Input
            Me.SqlParameters(3).Value = uncliente.DNI_Cliente
            Me.SqlParameters(4) = New SqlParameter("@direccion", SqlDbType.VarChar, 50)
            Me.SqlParameters(4).Direction = ParameterDirection.Input
            Me.SqlParameters(4).Value = uncliente.Direccion_Cliente
            Me.SqlParameters(5) = New SqlParameter("@telefono", SqlDbType.VarChar, 50)
            Me.SqlParameters(5).Direction = ParameterDirection.Input
            Me.SqlParameters(5).Value = uncliente.Telefono_Cliente
            Me.SqlParameters(6) = New SqlParameter("@email", SqlDbType.VarChar, 50)
            Me.SqlParameters(6).Direction = ParameterDirection.Input
            Me.SqlParameters(6).Value = uncliente.Email_Cliente
            Me.datosBd.Abm("ModificarCliente", Me.SqlParameters)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' METODO PARA EXPORTAR LOS CLIENTES A UN ARCHIVO XML
    ''' </summary>
    ''' <param name="ruta">RUTA HACIA LA CARPETA EN DONDE SE VA A GUARDAR EL ARCHIVO XML</param>
    ''' <param name="lista">LISTA DE CLIENTES</param>
    ''' <returns>RETORNA UN ENTERO</returns>
    ''' <remarks></remarks>
    Public Function exportarDatos(ByVal ruta As String, ByVal lista As List(Of Cliente)) As Integer
        Dim cantClientes As Integer = 0
        Try
            Dim objArchivo As New XmlTextWriter(ruta, System.Text.Encoding.UTF8)
            With objArchivo
                .Formatting = Formatting.Indented
                .WriteStartDocument()
                .WriteStartElement("Clientes")
                For Each uncliente As Cliente In lista
                    .WriteStartElement("Cliente")
                    .WriteAttributeString("Nombre", uncliente.Nombre_Cliente)
                    .WriteAttributeString("Apellido", uncliente.Apellido_Cliente)
                    .WriteAttributeString("Dni", uncliente.DNI_Cliente)
                    .WriteAttributeString("Direccion", uncliente.Direccion_Cliente)
                    .WriteAttributeString("Telefono", uncliente.Telefono_Cliente)
                    .WriteAttributeString("Email", uncliente.Email_Cliente)
                    .WriteEndElement()
                    cantClientes += 1
                Next
                .WriteEndElement()
                .WriteEndDocument()
                .Close()
            End With
            Return cantClientes
        Catch ex As Exception
            Throw ex
        End Try
    End Function



End Class

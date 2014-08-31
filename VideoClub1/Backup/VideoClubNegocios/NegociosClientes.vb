Imports System.Data
Imports VideoClubDatos
Imports VideoClubEntidades

Public Class NegociosClientes

    Private datosClientes As DatosClientes

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Me.datosClientes = New DatosClientes()
    End Sub

    ''' <summary>
    ''' METODO POR EL CUAL AVERIGUAMOS SI YA EXISTE EL CLIENTE EN LA 
    ''' BASE DE DATOS.
    ''' </summary>
    ''' <param name="dni">RECIBE COMO PARAMETRO EL NUMERO DE DNI</param>
    ''' <returns>RETORNA TRUE O FALSE</returns>
    ''' <remarks></remarks>
    Public Function getExisteCliente(ByVal dni As String) As Boolean
        Try
            If Me.datosClientes.existeCliente(dni) = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw New Exception("ERROR : Al querer buscar un cliente" & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' METODO POR EL CUAL SE EFECTUA UN ALTA DE CLIENTE EN LA BASE DE DATOS
    ''' </summary>
    ''' <param name="uncliente">RECIBE POR PARAMETRO UN CLIENTE</param>
    ''' <remarks></remarks>
    Public Sub guardarNuevoCliente(ByVal uncliente As Cliente)
        Try
            datosClientes.altaCliente(uncliente)
        Catch ex As Exception
            Throw New Exception("ERROR : Al querer guardar un cliente en la base de datos " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' METODO POR EL CUAL SE AVERIGUA SI EL CLIENTE POSEE ALQUILERES O COMPRAS
    ''' PARA LUEGO PROCEDER A BORRAR EL CLIENTE.
    ''' </summary>
    ''' <param name="idcliente">RESIVE POR PARAMETRO EL ID DEL CLIENTE</param>
    ''' <returns>RETORNA TRUE O FALSE</returns>
    ''' <remarks></remarks>
    Public Function getExisteAlquilerCompra(ByVal idcliente As Integer) As Boolean
        Try
            If datosClientes.existeAlquileresCompras(idcliente) = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw New Exception("ERROR : Al querer buscar si existe un alquiler o compra" & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' METODO PARA BORRAR UN CLIENTE QUE NO TIENE
    ''' ALQUILERES NI COMPRAS, SOLO SE BORRA UN CLIENTE.
    ''' </summary>
    ''' <param name="uncliente">RESIVE UN CLIENTE</param>
    ''' <remarks></remarks>
    Public Sub borrarCliente(ByVal uncliente As Cliente)
        Try
            datosClientes.bajaCliente(uncliente)
        Catch ex As Exception
            Throw New Exception("ERROR : Al querer borrar un cliente unicamente   " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' ESTE METODO BORRA UN CLIENTE Y SUS ALQUILERES O COMPRAS
    ''' BORRA EL CLIENTE Y TODO SU HISTORIAL
    ''' </summary>
    ''' <param name="uncliente">RESIVE UN CLIENTE</param>
    ''' <remarks></remarks>
    Public Sub borrarClienteAlquileresYcompras(ByVal uncliente As Cliente)
        Try
            datosClientes.bajaClienteAlquilresCompras(uncliente)
        Catch ex As Exception
            Throw New Exception("ERROR : Al querer borrar un cliente y su historial de la base de datos " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' METODO PARA MODIFICAR LOS DATOS DE UN CLIENTE EN LA BASE DE DATOS
    ''' </summary>
    ''' <param name="uncliente">RESIVE UN CLIENTE</param>
    ''' <remarks></remarks>
    Public Sub modificarCliente(ByVal uncliente As Cliente)
        Try
            datosClientes.modificacionCliente(uncliente)
        Catch ex As Exception
            Throw New Exception("ERROR : Al querer realizar una modificacion de clientes  " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' METODO UTILIZADO PARA EXPORTAR LOS CLIENTES A UN ARCHIVO XML
    ''' </summary>
    ''' <param name="ruta">RESIVE RUTA HACIA LA CARPETA EN DONDE SE GUARDARA EL ARCHIVO</param>
    ''' <returns>RETORNA UN ENTERO</returns>
    ''' <remarks></remarks>
    Public Function exportarXML(ByVal ruta As String) As Integer
        Dim ListaClientes As New List(Of Cliente)
        Try
            Dim dtClientes As DataTable = VideoCubNegocios.VIDEOCLUB.Tables("Clientes")
            For Each row As DataRow In dtClientes.Rows
                Dim uncliente As New Cliente()
                With uncliente
                    .Nombre_Cliente = row("Nombre").ToString
                    .Apellido_Cliente = row("Apellido").ToString
                    .Direccion_Cliente = row("Direccion")
                    .Telefono_Cliente = row("Telefono")
                    .DNI_Cliente = row("Dni")
                    .Email_Cliente = row("Email")
                End With
                ListaClientes.Add(uncliente)
            Next
            Dim cantidadClientes As Integer = Me.datosClientes.exportarDatos(ruta, ListaClientes)
            Return cantidadClientes
        Catch ex As Exception
            Throw New Exception("ERROR : Al querer exportar los datos a xml" & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' METODO QUE PERMITE IMPORTAR LOS CLIENTES DEL ARCHIVO XML
    ''' PARA GUARDARLOS EN LA TABLA DE LA BASE DE DATOS.
    ''' </summary>
    ''' <param name="listaClientes">LISTA DE CLIENTES</param>
    ''' <param name="cantRepetidos">CANTIDAD DE REGISTROS REPETIDOS</param>
    ''' <param name="cantRegistrosNuevos">CANTIDAD DE REGISTROS NUEVOS</param>
    ''' <remarks></remarks>
    Public Sub importarClientesBD(ByVal listaClientes As List(Of Cliente), ByRef cantRepetidos As Integer, ByRef cantRegistrosNuevos As Integer)
        For Each cliente1 As Cliente In listaClientes
            Try
                If getExisteCliente(cliente1.DNI_Cliente) Then
                    cantRepetidos += 1
                Else
                    guardarNuevoCliente(cliente1)
                    cantRegistrosNuevos += 1
                End If
            Catch ex As Exception
                Throw New Exception("ERROR : AL QUERER INSERTAR UN CLIENTE")
            End Try
        Next
    End Sub



    
End Class

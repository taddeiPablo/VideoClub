Imports VideoClubDatos
Imports VideoClubNegocios
Imports VideoClubEntidades

Public Class ManejadorXML

    Private listaClientes As New List(Of Cliente)

    ''' <summary>
    ''' METODO QUE DEVUELVE UN LISTADO DE CLIENTES
    ''' </summary>
    ''' <returns>RETORNA UNA LISTA DE CLIENTES</returns>
    ''' <remarks></remarks>
    Public Function getLista() As List(Of Cliente)
        Return Me.listaClientes
    End Function

    Public Sub New()

    End Sub

    ''' <summary>
    ''' METODO PARA IMPORTAR LOS CLIENTES DEL ARCHIVO XML
    ''' </summary>
    ''' <param name="nombreArchivo">RESIVE EL NOMBRE DEL ARCHIVO XML</param>
    ''' <param name="cantidadRepetidos">RESIVE LA CANTIDAD DE CLIENTES REPETIDOS</param>
    ''' <param name="cantidadInsertados">RESIVE LA CANTIDAD DE CLIENTES INSERTADOS CON EXITO</param>
    ''' <remarks></remarks>
    Public Sub importarSocios(ByVal nombreArchivo As String, ByRef cantidadRepetidos As Integer, ByRef cantidadInsertados As Integer)
        Dim leerXML As Xml.XmlTextReader
        Try
            Dim cliente As Cliente
            leerXML = New Xml.XmlTextReader(nombreArchivo)
            Do While Not leerXML.EOF
                If leerXML.Name = "Cliente" Then
                    cliente = New Cliente()
                    leerXML.MoveToAttribute("Nombre")
                    cliente.Nombre_Cliente = leerXML.Value
                    leerXML.MoveToAttribute("Apellido")
                    cliente.Apellido_Cliente = leerXML.Value
                    leerXML.MoveToAttribute("Dni")
                    cliente.DNI_Cliente = leerXML.Value
                    leerXML.MoveToAttribute("Direccion")
                    cliente.Direccion_Cliente = leerXML.Value
                    leerXML.MoveToAttribute("Telefono")
                    cliente.Telefono_Cliente = leerXML.Value
                    leerXML.MoveToAttribute("Email")
                    cliente.Email_Cliente = leerXML.Value
                    listaClientes.Add(cliente)
                End If
                leerXML.Read()
            Loop
            leerXML.Close()
        Catch ex As Exception
            Throw New Exception("ERROR : Al querer leer el archivo xml" & ex.Message)
        End Try
    End Sub

End Class

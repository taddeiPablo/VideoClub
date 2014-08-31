Imports VideoClubEntidades
Imports VideoClubDatos

Public Class NegociosCompras

    Private datosCompras As DatosCompras

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Try
            Me.datosCompras = New DatosCompras()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' METODO PARA CARGAR LAS COMPRAS EN LA GRILLA 
    ''' </summary>
    ''' <param name="idcliente">RESIVE UN ID DE CLIENTE</param>
    ''' <param name="dtCompras">RESIVE UN ID DE COMPRAS</param>
    ''' <remarks></remarks>
    Public Sub cargandoCompras(ByVal idcliente As Integer, ByVal dtCompras As DataTable)
        Try
            Me.datosCompras.cargarCompras(idcliente, dtCompras)
        Catch ex As Exception
            Throw New Exception("ERROR : Al querer cargar las compras en la grilla")
        End Try
    End Sub

    ''' <summary>
    ''' METODO PARA GUARDAR UNA NUEVA COMPRA, Y CARGAR LA LISTA DE PELICULAS, Y ACTUALIZAR EL CATALOGO
    ''' (ESTO SE REALIZA A TRAVEZ DE UNA TRANSACCION)
    ''' </summary>
    ''' <param name="comp">RESIVE UNA COMPRA</param>
    ''' <remarks></remarks>
    Public Sub cargandoCompras(ByVal comp As Compra)
        Try
            VideoCubNegocios.VIDEOCLUB.Tables("Peliculas").Clear()
            Me.datosCompras.AltaCompra(comp, VideoCubNegocios.VIDEOCLUB.Tables("Peliculas"))
        Catch ex As Exception
            Throw New Exception("ERROR : Al querer guardar una compra" & ex.Message)
        End Try
    End Sub


    Public Sub cargarVistaCompras(ByVal dtVistaCompras As DataTable)
        Try
            Me.datosCompras.cargarVistaCompras(dtVistaCompras)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class

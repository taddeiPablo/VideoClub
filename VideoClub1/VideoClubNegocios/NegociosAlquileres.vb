Imports VideoClubEntidades
Imports VideoClubDatos
Imports System.Data.SqlClient

Public Class NegociosAlquileres

    Private datosAlquiler As DatosAlquileres

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Try
            Me.datosAlquiler = New DatosAlquileres()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' METODO PARA CARGAR LOS ALQUILERES EN LA GRILLA
    ''' </summary>
    ''' <param name="idcliente">RESIVE EL ID DEL CLIENTE</param>
    ''' <param name="dtAlquileres">RESIVE LA TABLA DE ALQUILERES</param>
    ''' <remarks></remarks>
    Public Sub cargandoAlquileres(ByVal idcliente As Integer, ByVal dtAlquileres As DataTable)
        Try
            Me.datosAlquiler.cargarAlquileres(idcliente, dtAlquileres)
        Catch ex As Exception
            Throw New Exception("ERROR : Al querer cargar un alquiler en la grilla" & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' METODO PARA GUARDAR UN ALQUILER, TAMBIEN PARA GUARDAR EL LISTA DE PELICULAS, Y ACTUALIZAR EL 
    ''' CATALOGO (ESTO SE HACE A TRAVEZ DE UNA TRANSACCION)
    ''' </summary>
    ''' <param name="alq">RESIVE UN ALQUILER</param>
    ''' <remarks></remarks>
    Public Sub guardarAlquiler(ByVal alq As Alquiler)
        Try
            VideoCubNegocios.VIDEOCLUB.Tables("Peliculas").Clear()
            Me.datosAlquiler.altaAlquileres(alq, VideoCubNegocios.VIDEOCLUB.Tables("Peliculas"))
        Catch ex As Exception
            Throw New Exception("ERROR : Al querer realizar un alta de alquileres, lista de peliculas, y catalogo" & ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' METODO PARA ESTABLECER UNA FECHA DE DEVOLUCION DE UN ALQUILER
    ''' </summary>
    ''' <param name="idcliente">RESIVE UN ID DEL CLIENTE</param>
    ''' <param name="idAlquiler">RESIVE UN ID DE ALQUILER</param>
    ''' <param name="idPelicula">RESIVE UN ID DE PELICULA</param>
    ''' <param name="fechaDevolucion">RESIVE FECHA DE DEVOLUCION</param>
    ''' <remarks></remarks>
    Public Sub cambiarFechaDevolucionalq(ByVal idcliente As Integer, ByVal idAlquiler As Integer, ByVal idPelicula As Integer, ByVal fechaDevolucion As Date)
        Try
            VideoCubNegocios.VIDEOCLUB.Tables("Alquileres").Clear()
            VideoCubNegocios.VIDEOCLUB.Tables("Peliculas").Clear()
            Me.datosAlquiler.fechaAlquilerDevolucion(idcliente, idAlquiler, fechaDevolucion, idPelicula, VideoCubNegocios.VIDEOCLUB.Tables("Alquileres"), VideoCubNegocios.VIDEOCLUB.Tables("Peliculas"))
        Catch ex As Exception
            Throw New Exception("ERROR : Al querer establecer la fecha de devolucion de un alquiler" & ex.Message)
        End Try
    End Sub


End Class

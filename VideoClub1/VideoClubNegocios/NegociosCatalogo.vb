Imports VideoClubEntidades
Imports VideoClubDatos


Public Class NegociosCatalogo

    Private datosCatalogo As DatosCatalogo

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Me.datosCatalogo = New DatosCatalogo()
    End Sub

    ''' <summary>
    ''' METODO PARA BUSCAR SI EXISTE YA LA PELICULA EN LA BASE DE DATOS
    ''' ANTES DE REALIZAR UN ALTA.
    ''' </summary>
    ''' <param name="titulo">INGRESA EL TITULO</param>
    ''' <returns>RETORNA UN STRING</returns>
    ''' <remarks></remarks>
    Public Function getExistePelicula(ByVal titulo As String) As String
        Try
            Return Me.datosCatalogo.ExistePelicula(titulo)
        Catch ex As Exception
            Throw New Exception("ERROR : Al querer buscar una pelicula en el catalogo" & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' METODO POR EL CUAL CAMBIAMOS EL VALOR
    ''' DEL CAMPO POR EL CUAL OCULTAMOS LA PELICULA SI ESTA A SIDO BORRADA
    ''' </summary>
    ''' <param name="titulo">RESIVE COMO PARAMETRO EL TITULO DE LA PELICULA</param>
    ''' <remarks></remarks>
    Public Sub CambiarValor(ByVal titulo As String)
        Try
            Me.datosCatalogo.cambiarCampoPelicula(titulo)
        Catch ex As Exception
            Throw New Exception("ERROR : Al querer cambiar un campo en el catalogo" & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' METODO PARA GUARDAR UNA PELICULA EN EL CATALOGO
    ''' </summary>
    ''' <param name="unapelicula">RESIVE UNA PELICULA</param>
    ''' <remarks></remarks>
    Public Sub guardarPelicula(ByVal unapelicula As Pelicula)
        Try
            datosCatalogo.altaPelicula(unapelicula)
        Catch ex As Exception
            Throw New Exception("ERROR : Al querer guardar una pelicula" & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' METODO PARA BORRAR UN PELICULA
    ''' </summary>
    ''' <param name="idPelicula">RESIVE EL ID DE LA PELICULA</param>
    ''' <remarks></remarks>
    Public Sub borrarPelicula(ByVal idPelicula As Integer)
        Try
            datosCatalogo.bajaPelicula(idPelicula)
        Catch ex As Exception
            Throw New Exception("ERROR : Al querer borrar una pelicula del catalogo" & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' METODO PARA MODIFICAR LOS DATOS DE UNA PELICULA
    ''' </summary>
    ''' <param name="unaPelicula">RESIVE UNA PELICULA</param>
    ''' <remarks></remarks>
    Public Sub modificarPelicula(ByVal unaPelicula As Pelicula)
        Try
            datosCatalogo.modificacionPelicula(unaPelicula)
        Catch ex As Exception
            Throw New Exception("ERROR : Al querer modificar una pelicula del catalogo" & ex.Message)
        End Try
    End Sub
End Class

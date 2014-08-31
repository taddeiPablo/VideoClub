Imports System.Data
Imports VideoClubDatos

Public Class VideoCubNegocios

    Private Shared DsVideoClub As DataSet
    Private Shared dtClientes As DataTable
    Private Shared dtPeliculas As DataTable
    Private Shared dtAlquileres As DataTable
    Private Shared dtCompras As DataTable
    Private Shared dtVistaCompra As DataTable

    ''' <summary>
    ''' PROPIEDAD QUE DEVUELVE UN DATASET CON SUS RESPECTIVAS TABLAS
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Property VIDEOCLUB() As DataSet
        Get
            Return DsVideoClub
        End Get
        Set(ByVal value As DataSet)
            DsVideoClub = value
        End Set
    End Property

    ''' <summary>
    ''' METODO QUE CREARA EL DATASET Y LOS DATATABLES CORESPONDIENTES
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Sub iniciar()
        DsVideoClub = New DataSet("VideoClub")
        dtClientes = New DataTable("Clientes")
        dtPeliculas = New DataTable("Peliculas")
        dtAlquileres = New DataTable("Alquileres")
        dtCompras = New DataTable("Compras")
        dtVistaCompra = New DataTable("VistaCompras")
        DsVideoClub.Tables.Add(dtClientes)
        DsVideoClub.Tables.Add(dtPeliculas)
        DsVideoClub.Tables.Add(dtAlquileres)
        DsVideoClub.Tables.Add(dtCompras)
        DsVideoClub.Tables.Add(dtVistaCompra)
    End Sub

    ''' <summary>
    ''' METODO QUE CARGAR EL DATATABLE DE CLIENTES CON LOS CLIENTES TRAIDOS DE 
    ''' LA BASE DE DATOS.
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Sub cargarDatosCliente()
        Try
            Dim datosCliente As New DatosClientes()
            datosCliente.cargarClientes(DsVideoClub.Tables("Clientes"))
        Catch ex As Exception
            Throw New Exception("ERROR : Al querer cargar una tabla con clientes" & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' METODO QUE CARGA EL DATATABLE DE PELICULAS CON LAS PELICULAS TRAIDAS DE LA BASE DE DATOS
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Sub cargarDatosCatalogo()
        Try
            Dim datosCatalogo As New DatosCatalogo()
            datosCatalogo.cargarCatalogo(DsVideoClub.Tables("Peliculas"))
        Catch ex As Exception
            Throw New Exception("ERROR : Al querer cargar el catalogo de peliculas" & ex.Message)
        End Try
    End Sub

End Class

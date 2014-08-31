
Public Class Alquiler

    Private idAlq As Integer
    Private listaPeliculas As List(Of Pelicula)
    Private tipodePago As String
    Private totalAlquiler As Single
    Private fechaInicio As Date
    Private fechaFinal As Date
    Private idCliente As Integer



    Public Property IDAlquileres() As Integer
        Get
            Return Me.idAlq
        End Get
        Set(ByVal value As Integer)
            Me.idAlq = value
        End Set
    End Property
    Public Property PropiedadPelicula() As List(Of Pelicula)
        Get
            Return Me.listaPeliculas
        End Get
        Set(ByVal value As List(Of Pelicula))
            Me.listaPeliculas = value
        End Set
    End Property

    Public Property TIPO_PAGO() As String
        Get
            Return Me.tipodePago
        End Get
        Set(ByVal value As String)
            Me.tipodePago = value
        End Set
    End Property

    Public Property TOTAL_ALQUILER() As Single
        Get
            Return Me.totalAlquiler
        End Get
        Set(ByVal value As Single)
            Me.totalAlquiler = value
        End Set
    End Property
    Public Property FECHA_INICIAL() As Date
        Get
            Return Me.fechaInicio
        End Get
        Set(ByVal value As Date)
            Me.fechaInicio = value
        End Set
    End Property
    Public Property FECHA_FINAL() As Date
        Get
            Return Me.fechaFinal
        End Get
        Set(ByVal value As Date)
            Me.fechaFinal = value
        End Set
    End Property
    Public Property ID_CLIENTE() As Integer
        Get
            Return Me.idCliente
        End Get
        Set(ByVal value As Integer)
            Me.idCliente = value
        End Set
    End Property



    Public Sub New(ByVal peli As List(Of Pelicula), ByVal tipoP As String, ByVal totalAlquiler As Single, ByVal fechaInicio As Date, ByVal idcliente As Integer)
        Me.listaPeliculas = peli
        Me.tipodePago = tipoP
        Me.totalAlquiler = totalAlquiler
        Me.fechaInicio = fechaInicio
        Me.idCliente = idcliente
    End Sub
End Class

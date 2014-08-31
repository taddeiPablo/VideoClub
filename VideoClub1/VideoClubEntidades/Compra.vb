

Public Class Compra

    Private idCompra As Integer
    Private listaPeliculas As List(Of Pelicula)
    Private tipoPago As String
    Private total As Single
    Private totalCompra As Single
    Private fechaCompra As Date
    Private idcliente As Integer


    Public Property ID_COMPRA() As Integer
        Get
            Return Me.idcliente
        End Get
        Set(ByVal value As Integer)
            Me.idcliente = value
        End Set
    End Property
    Public Property PELICULA_PROPERTY() As List(Of Pelicula)
        Get
            Return Me.listaPeliculas
        End Get
        Set(ByVal value As List(Of Pelicula))
            Me.listaPeliculas = value
        End Set
    End Property
    Public Property TIPO_PAGO() As String
        Get
            Return Me.tipoPago
        End Get
        Set(ByVal value As String)
            Me.tipoPago = value
        End Set
    End Property
    Public Property TOTAL_NETO() As Single
        Get
            Return Me.total
        End Get
        Set(ByVal value As Single)
            Me.total = value
        End Set
    End Property
    Public Property TOTAL_COMPRA() As Single
        Get
            Return Me.totalCompra
        End Get
        Set(ByVal value As Single)
            Me.totalCompra = value
        End Set
    End Property
    Public Property FECHA_COMPRA() As Date
        Get
            Return Me.fechaCompra
        End Get
        Set(ByVal value As Date)
            Me.fechaCompra = value
        End Set
    End Property
    Public Property ID_CLIENTE() As Integer
        Get
            Return Me.idcliente
        End Get
        Set(ByVal value As Integer)
            Me.idcliente = value
        End Set
    End Property

    Public Sub New(ByVal pelicula As List(Of Pelicula), ByVal tipoPago As String, ByVal totalN As Single, ByVal totalCompra As Single, ByVal fechaCompra As Date, ByVal idcliente As Integer)
        Me.listaPeliculas = pelicula
        Me.tipoPago = tipoPago
        Me.total = totalN
        Me.totalCompra = totalCompra
        Me.fechaCompra = fechaCompra
        Me.idcliente = idcliente
    End Sub

    Public Sub New(ByVal idcompra As Integer, ByVal pelicula As List(Of Pelicula), ByVal tipoPago As String, ByVal totalN As Single, ByVal totalCompra As Single, ByVal fechaCompra As Date, ByVal idcliente As Integer)
        Me.idCompra = idcompra
        Me.listaPeliculas = pelicula
        Me.tipoPago = tipoPago
        Me.total = totalN
        Me.totalCompra = totalCompra
        Me.fechaCompra = fechaCompra
        Me.idcliente = idcliente
    End Sub

End Class

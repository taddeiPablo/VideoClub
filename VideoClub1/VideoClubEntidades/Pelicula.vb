

Public Class Pelicula

    Private idPelicula As Integer
    Private titulo As String
    Private genero As String
    Private formato As String
    Private precioAlquiler As Single
    Private precioCompra As Single
    Private imagen() As Byte
    Private cantidad As Integer

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ID_PELICULA() As Integer
        Get
            Return Me.idPelicula
        End Get
        Set(ByVal value As Integer)
            Me.idPelicula = value
        End Set
    End Property

    ''' <summary>
    ''' propiedad titulo
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Titulo_Pelicula() As String
        Get
            Return Me.titulo
        End Get
        Set(ByVal value As String)
            Me.titulo = value
        End Set
    End Property

    ''' <summary>
    ''' propiedad genero
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Genero_Pelicula() As String
        Get
            Return Me.genero
        End Get
        Set(ByVal value As String)
            Me.genero = value
        End Set
    End Property

    ''' <summary>
    ''' propiedad formato
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Formato_Pelicula() As String
        Get
            Return Me.formato
        End Get
        Set(ByVal value As String)
            Me.formato = value
        End Set
    End Property

    ''' <summary>
    ''' propiedad precio Alquiler
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PrecioAlquiler_Pelicula() As Single
        Get
            Return Me.precioAlquiler
        End Get
        Set(ByVal value As Single)
            Me.precioAlquiler = value
        End Set
    End Property

    ''' <summary>
    ''' propiedad precio compra
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PrecioCompra_Pelicula() As Single
        Get
            Return Me.precioCompra
        End Get
        Set(ByVal value As Single)
            Me.precioCompra = value
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property IMAGEN_BYTES() As Byte()
        Get
            Return Me.imagen
        End Get
        Set(ByVal value As Byte())
            Me.imagen = value
        End Set
    End Property


    ''' <summary>
    ''' propiedad cantidad
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Cantidad_Pelicula() As Integer
        Get
            Return Me.cantidad
        End Get
        Set(ByVal value As Integer)
            Me.cantidad = value
        End Set
    End Property

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <param name="titulo"></param>
    ''' <param name="genero"></param>
    ''' <param name="formato"></param>
    ''' <param name="precioAlq"></param>
    ''' <param name="precioComp"></param>
    ''' <param name="cantidad"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal titulo As String, ByVal genero As String, ByVal formato As String, ByVal precioAlq As Single, ByVal precioComp As Single, ByVal imagen As Byte(), ByVal cantidad As Integer)
        Me.titulo = titulo
        Me.genero = genero
        Me.formato = formato
        Me.precioAlquiler = precioAlq
        Me.precioCompra = precioComp
        Me.imagen = imagen
        Me.cantidad = cantidad
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="idpelicula"></param>
    ''' <param name="titulo"></param>
    ''' <param name="genero"></param>
    ''' <param name="formato"></param>
    ''' <param name="precioAlq"></param>
    ''' <param name="precioComp"></param>
    ''' <param name="cantidad"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal idpelicula As Integer, ByVal titulo As String, ByVal genero As String, ByVal formato As String, ByVal precioAlq As Single, ByVal precioComp As Single, ByVal imagen As Byte(), ByVal cantidad As Integer)
        Me.idPelicula = idpelicula
        Me.titulo = titulo
        Me.genero = genero
        Me.formato = formato
        Me.precioAlquiler = precioAlq
        Me.precioCompra = precioComp
        Me.imagen = imagen
        Me.cantidad = cantidad
    End Sub
End Class

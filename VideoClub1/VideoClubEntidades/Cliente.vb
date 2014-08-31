
Public Class Cliente

    Private idcliente As Integer
    Private nombre As String
    Private apellido As String
    Private direccion As String
    Private dni As Integer
    Private telefono As Integer
    Private email As String


    ''' <summary>
    ''' propiedad cliente
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property IDcliente_Cliente() As String
        Get
            Return Me.idcliente
        End Get
        Set(ByVal value As String)
            Me.idcliente = value
        End Set
    End Property


    ''' <summary>
    ''' propiedad nombre
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Nombre_Cliente() As String
        Get
            Return Me.nombre
        End Get
        Set(ByVal value As String)
            Me.nombre = value
        End Set
    End Property

    ''' <summary>
    ''' propiedad apellido
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Apellido_Cliente() As String
        Get
            Return Me.apellido
        End Get
        Set(ByVal value As String)
            Me.apellido = value
        End Set
    End Property

    ''' <summary>
    ''' propiedad direccion
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Direccion_Cliente() As String
        Get
            Return Me.direccion
        End Get
        Set(ByVal value As String)
            Me.direccion = value
        End Set
    End Property

    Public Property DNI_Cliente() As Integer
        Get
            Return Me.dni
        End Get
        Set(ByVal value As Integer)
            Me.dni = value
        End Set
    End Property


    ''' <summary>
    ''' propiedad telefono
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Telefono_Cliente() As Integer
        Get
            Return Me.telefono
        End Get
        Set(ByVal value As Integer)
            Me.telefono = value
        End Set
    End Property

    ''' <summary>
    ''' email
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Email_Cliente() As String
        Get
            Return Me.email
        End Get
        Set(ByVal value As String)
            Me.email = value
        End Set
    End Property

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <param name="nombre"></param>
    ''' <param name="apellido"></param>
    ''' <param name="direccion"></param>
    ''' <param name="telefono"></param>
    ''' <param name="email"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal nombre As String, ByVal apellido As String, ByVal dni As Integer, ByVal direccion As String, ByVal telefono As Integer, ByVal email As String)
        Me.nombre = nombre
        Me.apellido = apellido
        Me.direccion = direccion
        Me.telefono = telefono
        Me.email = email
        Me.dni = dni
    End Sub
    ''' <summary>
    ''' sobrecarga de constructor
    ''' </summary>
    ''' <param name="idcliente"></param>
    ''' <param name="nombre"></param>
    ''' <param name="apellido"></param>
    ''' <param name="dni"></param>
    ''' <param name="direccion"></param>
    ''' <param name="telefono"></param>
    ''' <param name="email"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal idcliente As Integer, ByVal nombre As String, ByVal apellido As String, ByVal dni As Integer, ByVal direccion As String, ByVal telefono As Integer, ByVal email As String)
        Me.idcliente = idcliente
        Me.nombre = nombre
        Me.apellido = apellido
        Me.direccion = direccion
        Me.telefono = telefono
        Me.email = email
        Me.dni = dni
    End Sub

    Public Sub New()

    End Sub
End Class

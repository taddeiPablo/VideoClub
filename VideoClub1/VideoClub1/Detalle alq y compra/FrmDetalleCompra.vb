Public Class FrmDetalleCompra
    Dim titulo As String
    Dim genero As String
    Dim formato As String
    Dim tipoPago As String
    Dim total As Single
    Dim imagen As Image

    Public Sub New(ByVal titulo As String, ByVal genero As String, ByVal formato As String, ByVal tipoPago As String, ByVal total As Single, ByVal img As Image)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        Me.titulo = titulo
        Me.genero = genero
        Me.formato = formato
        Me.tipoPago = tipoPago
        Me.total = total
        Me.imagen = img
    End Sub

    Private Sub FrmDetalleCompra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LblTitulo.Text = Me.titulo
        LblGenero.Text = Me.genero
        LblTipo.Text = Me.formato
        LblTipoPago.Text = Me.tipoPago
        LblPrecioC.Text = Me.total
        LblTotalPagar.Text = Me.total
        PictureBox1.Image = Me.imagen
    End Sub

    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
End Class
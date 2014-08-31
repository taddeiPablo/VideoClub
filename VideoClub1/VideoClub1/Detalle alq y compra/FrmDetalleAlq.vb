Imports VideoClubNegocios
Public Class FrmDetalleAlq

    Private idcliente As Integer
    Private idPelicula As Integer
    Private titulo As String
    Private genero As String
    Private formato As String
    Private imagen As Image
    Private idAlquiler As Integer
    Private totalAlq As Single
    Private tipoPago As String
    Private fechaAlq As Date
    Private fechFinal As Date
    Private negociosAlquiler As NegociosAlquileres

    Public Sub New(ByVal idcliente As Integer, ByVal idPelicula As Integer, ByVal idAlq As Integer, ByVal titulo As String, ByVal genero As String, ByVal formato As String, ByVal img As Image, ByVal totalAlq As Single, ByVal tipoPago As String, ByVal fechaAlq As Date, ByVal fechaFinal As Date)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        Me.negociosAlquiler = New NegociosAlquileres()
        Me.idcliente = idcliente
        Me.idPelicula = idPelicula
        Me.idAlquiler = idAlq
        Me.titulo = titulo
        Me.genero = genero
        Me.formato = formato
        Me.imagen = img
        Me.totalAlq = totalAlq
        Me.tipoPago = tipoPago
        Me.fechaAlq = fechaAlq
        Me.fechFinal = fechaFinal
    End Sub

    Private Sub FrmDetalleAlq_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LblTitulo.Text = Me.titulo
        LblGenero.Text = Me.genero
        LblTipo.Text = Me.formato
        PictureBox1.Image = Me.imagen
        LblPrecioC.Text = Me.totalAlq
        LblTipoPago.Text = Me.tipoPago
        LblFechaInicioAlq.Text = Me.fechaAlq
        Dim var As String = Me.fechFinal.ToShortDateString()
        If var = "01/01/2013" Then
            LblFechaFinalAlq.Text = "NO DEVUELTA"
        Else
            LblFechaFinalAlq.Text = Me.fechFinal
        End If
    End Sub

    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frmDevolucion As New FrmDevolucionAlq()
        If frmDevolucion.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                Me.negociosAlquiler.cambiarFechaDevolucionalq(idcliente, idAlquiler, idPelicula, frmDevolucion.FechaDevolucionALQ)
                LblFechaFinalAlq.Text = "Pelicula ya Devuelta"
            Catch ex As Exception
                MessageBox.Show("ERROR : " & ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
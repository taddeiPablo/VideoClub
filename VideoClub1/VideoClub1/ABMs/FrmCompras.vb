Imports VideoClubEntidades
Imports VideoClubNegocios

Public Class FrmCompras

    Private idCliente As Integer
    Private listaPeliculas As List(Of Pelicula)
    Private unaCompra As Compra
    Private acum As Integer = 0
    Private total As Single = 0
    Private tipodePago As String = String.Empty


    Public Property ID_CLIENTE() As Integer
        Get
            Return Me.idCliente
        End Get
        Set(ByVal value As Integer)
            Me.idCliente = value
        End Set
    End Property


    Public Property COMPRA() As Compra
        Get
            Return Me.unaCompra
        End Get
        Set(ByVal value As Compra)
            Me.unaCompra = value
        End Set
    End Property

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Try
            Dim fechaAlq As Date = Date.Parse(DateTimeFechaCompra.Value.Date.ToString)
            Me.tipodePago = CmbBoxTipoPago.SelectedItem.ToString
            Me.unaCompra = New Compra(Me.listaPeliculas, tipodePago, total, total, fechaAlq, idCliente)
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.DgvListadodePeliculas.DataSource = VideoCubNegocios.VIDEOCLUB.Tables("Peliculas")
            Me.DgvListadodePeliculas.Columns("idPelicula").Visible = False
            Me.listaPeliculas = New List(Of Pelicula)
            Me.CmbBoxTipoPago.Items.AddRange(New String() {"Efectivo", "Tarjeta"})
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ANTENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvListadodePeliculas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvListadodePeliculas.CellContentClick
        Try
            Dim titulo As String = Me.DgvListadodePeliculas.Rows(e.RowIndex).Cells("titulo").Value.ToString
            Dim genero As String = Me.DgvListadodePeliculas.Rows(e.RowIndex).Cells("genero").Value.ToString
            Dim formato As String = Me.DgvListadodePeliculas.Rows(e.RowIndex).Cells("formato").Value.ToString
            Dim precioAlq As Single = Single.Parse(Me.DgvListadodePeliculas.Rows(e.RowIndex).Cells("PrecioAlquiler").Value.ToString)
            Dim arrayImg() As Byte = Me.DgvListadodePeliculas.Rows(e.RowIndex).Cells("ImagenPelicula").Value
            LblTitulo.Text = titulo
            LblGenero.Text = genero
            LblTipo.Text = formato
            LblPrecioAlquiler.Text = "$ " & precioAlq
            PBImagenPelicula.Image = getImages(arrayImg)
            DgvListadodePeliculas.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Aqua
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvListadodePeliculas_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvListadodePeliculas.CellValueChanged
        If DgvListadodePeliculas.Columns(e.ColumnIndex).Name = "seleccion" Then
            Dim row As DataGridViewRow = DgvListadodePeliculas.Rows(e.RowIndex)
            Dim cell As DataGridViewCheckBoxCell = CType(row.Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(cell.Value) Then
                Dim idPelicula As Integer = Integer.Parse(Me.DgvListadodePeliculas.Rows(e.RowIndex).Cells("idPelicula").Value.ToString)
                Dim titulo As String = Me.DgvListadodePeliculas.Rows(e.RowIndex).Cells("titulo").Value.ToString
                Dim genero As String = Me.DgvListadodePeliculas.Rows(e.RowIndex).Cells("genero").Value.ToString
                Dim formato As String = Me.DgvListadodePeliculas.Rows(e.RowIndex).Cells("formato").Value.ToString
                Dim precioAlq As Single = Single.Parse(Me.DgvListadodePeliculas.Rows(e.RowIndex).Cells("PrecioAlquiler").Value.ToString)
                Dim precioComp As Single = Single.Parse(Me.DgvListadodePeliculas.Rows(e.RowIndex).Cells("PrecioCompra").Value.ToString)
                Dim arrayImg() As Byte = Me.DgvListadodePeliculas.Rows(e.RowIndex).Cells("ImagenPelicula").Value
                Dim cantidad As Integer = Integer.Parse(Me.DgvListadodePeliculas.Rows(e.RowIndex).Cells("cantidad").Value.ToString)
                Dim unaPelicula As New Pelicula(idPelicula, titulo, genero, formato, precioAlq, precioComp, arrayImg, cantidad)
                Me.listaPeliculas.Add(unaPelicula)
            Else
                Me.listaPeliculas.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub BtnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalc.Click
        Try
            For Each peli As Pelicula In listaPeliculas
                Me.acum = Me.acum + peli.PrecioAlquiler_Pelicula
            Next
            LblCantidad.Text = Me.listaPeliculas.Count
            LblTotalAPagar.Text = "$ " & Me.acum
            total = Me.acum
            Me.acum = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmbBoxTipoPago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBoxTipoPago.SelectedIndexChanged
        Select Case CmbBoxTipoPago.SelectedItem.ToString
            Case "Efectivo"
                Me.tipodePago = "Efectivo"
            Case "Tarjeta"
                Me.tipodePago = "Tarjeta"
            Case Else
        End Select
    End Sub


    Private Function getImages(ByVal bytes As Byte()) As Image
        Try
            Dim ms As New IO.MemoryStream(bytes)
            Dim retornaImagen As Image = Image.FromStream(ms)
            Return retornaImagen
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class
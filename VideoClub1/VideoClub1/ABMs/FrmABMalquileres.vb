Imports VideoClubNegocios
Imports VideoClubEntidades

Public Class FrmABMalquileres

    Private idCliente As Integer
    Private listaPeliculas As List(Of Pelicula)
    Private unalquiler As Alquiler
    Private acum As Integer = 0
    Private total As Integer = 0
    Private tipodePago As String = String.Empty


    Public Property ID_CLIENTE() As Integer
        Get
            Return Me.idCliente
        End Get
        Set(ByVal value As Integer)
            Me.idCliente = value
        End Set
    End Property


    Public Property ALQUILER() As Alquiler
        Get
            Return Me.unalquiler
        End Get
        Set(ByVal value As Alquiler)
            Me.unalquiler = value
        End Set
    End Property


    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Try
            Dim fechaAlq As Date = Date.Parse(DateTimeInicio.Value.Date.ToString)
            Me.tipodePago = CmbBoxTipoPago.SelectedItem.ToString
            Me.unalquiler = New Alquiler(Me.listaPeliculas, Me.tipodePago, Me.total, fechaAlq, Me.idCliente)
            Me.unalquiler.FECHA_FINAL = New Date(2013, 1, 1)
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmABMalquileres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DgvListadodePeliculas.DataSource = VideoCubNegocios.VIDEOCLUB.Tables("Peliculas")
        Me.DgvListadodePeliculas.Columns("idPelicula").Visible = False
        Me.DgvListadodePeliculas.Columns("ImagenPelicula").Visible = False
        Me.listaPeliculas = New List(Of Pelicula)
        Me.CmbBoxTipoPago.Items.AddRange(New String() {"Efectivo", "Tarjeta"})
    End Sub

    Private Sub DgvListadodePeliculas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvListadodePeliculas.CellContentClick
        Try
            Dim titulo As String = Me.DgvListadodePeliculas.Rows(e.RowIndex).Cells("titulo").Value.ToString
            Dim genero As String = Me.DgvListadodePeliculas.Rows(e.RowIndex).Cells("genero").Value.ToString
            Dim formato As String = Me.DgvListadodePeliculas.Rows(e.RowIndex).Cells("formato").Value.ToString
            Dim precioAlq As Single = Single.Parse(Me.DgvListadodePeliculas.Rows(e.RowIndex).Cells("PrecioAlquiler").Value.ToString)
            Dim arrayImagen() As Byte = Me.DgvListadodePeliculas.Rows(e.RowIndex).Cells("ImagenPelicula").Value
            LblTitulo.Text = titulo
            LblGenero.Text = genero
            LblTipo.Text = formato
            LblPrecioAlquiler.Text = "$ " & precioAlq
            PBImagenPelicula.Image = getImages(arrayImagen)
            DgvListadodePeliculas.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Aqua
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvListadodePeliculas_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvListadodePeliculas.CellValueChanged
        If DgvListadodePeliculas.Columns(e.ColumnIndex).Name = "Seleccionar" Then
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
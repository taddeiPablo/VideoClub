Imports VideoClubEntidades
Imports VideoClubNegocios

Public Class FrmCatalogo

    Private unapelicula As Pelicula
    Private filas As Integer = 0


    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Dim abmPelicula As New FrmABMpeliculas
        If DialogResult.OK = abmPelicula.ShowDialog() Then
            Try
                Dim negocioCatalogo As New NegociosCatalogo()
                Dim valorCampoBorrada As String = negocioCatalogo.getExistePelicula(abmPelicula.UNA_PELICULA.Titulo_Pelicula)
                If valorCampoBorrada = "si" Then
                    negocioCatalogo.CambiarValor(abmPelicula.UNA_PELICULA.Titulo_Pelicula)
                ElseIf valorCampoBorrada = "no" Then
                    MessageBox.Show("ESTA PELICULA YA SE ENCUENTRA EN EL CATALOGO", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    negocioCatalogo.guardarPelicula(abmPelicula.UNA_PELICULA)
                End If
                VideoCubNegocios.VIDEOCLUB.Tables("Peliculas").Clear()
                VideoCubNegocios.cargarDatosCatalogo()
                Me.DataGridCatalogo.DataSource = VideoClubNegocios.VideoCubNegocios.VIDEOCLUB.Tables("Peliculas")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FrmCatalogo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            cargarCombo()
            Me.ErrorProviderBusquedaPelicula.SetError(Me.TxtIngreseBusqueda, "Seleccione un criterio de busqueda primero")
            Me.TxtIngreseBusqueda.Enabled = False
            Me.DataGridCatalogo.DataSource = VideoClubNegocios.VideoCubNegocios.VIDEOCLUB.Tables("Peliculas")
            Me.DataGridCatalogo.Columns("IdPelicula").Visible = False
            Me.DataGridCatalogo.Columns("ImagenPelicula").Visible = False
            Me.BtnModificar.Enabled = False
            Me.BtnBorrar.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridCatalogo_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridCatalogo.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim idPelicula As Integer = Integer.Parse(Me.DataGridCatalogo.Rows(e.RowIndex).Cells("IdPelicula").Value)
            Dim titulo As String = Me.DataGridCatalogo.Rows(e.RowIndex).Cells("Titulo").Value
            LblTitulo.Text = titulo
            Dim genero As String = Me.DataGridCatalogo.Rows(e.RowIndex).Cells("Genero").Value
            LblGenero.Text = genero
            Dim formato As String = Me.DataGridCatalogo.Rows(e.RowIndex).Cells("Formato").Value
            LblFormato.Text = formato
            Dim precioAlq As Single = Single.Parse(Me.DataGridCatalogo.Rows(e.RowIndex).Cells("PrecioAlquiler").Value)
            LblPrecioAlq.Text = "$ " & precioAlq
            Dim precioComp As Single = Single.Parse(Me.DataGridCatalogo.Rows(e.RowIndex).Cells("PrecioCompra").Value)
            LblPrecioComp.Text = "$ " & precioComp
            Dim array() As Byte = Me.DataGridCatalogo.Rows(e.RowIndex).Cells("ImagenPelicula").Value
            PictureBoxPelicula.Image = getImages(array)
            Dim cantidad As Integer = Integer.Parse(Me.DataGridCatalogo.Rows(e.RowIndex).Cells("Cantidad").Value)
            LblCant.Text = cantidad
            Me.unapelicula = New Pelicula(idPelicula, titulo, genero, formato, precioAlq, precioComp, array, cantidad)
            Me.BtnModificar.Enabled = True
            Me.BtnBorrar.Enabled = True
        End If
    End Sub

    Private Sub BtnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrar.Click
        Try
            Dim negocioPelicula As New NegociosCatalogo()
            If DialogResult.Yes = MessageBox.Show("USTED ESTA A PUNTO DE BORRAR UNA PELICULA DESEA CONTINUAR", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                negocioPelicula.borrarPelicula(Me.unapelicula.ID_PELICULA)
                Me.BtnModificar.Enabled = False
                Me.BtnBorrar.Enabled = False
            End If
            VideoCubNegocios.VIDEOCLUB.Tables("Peliculas").Clear()
            VideoCubNegocios.cargarDatosCatalogo()
            Me.DataGridCatalogo.DataSource = VideoClubNegocios.VideoCubNegocios.VIDEOCLUB.Tables("Peliculas")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        Dim abmPelicula As New FrmABMpeliculas
        abmPelicula.UNA_PELICULA = Me.unapelicula
        If DialogResult.OK = abmPelicula.ShowDialog() Then
            Try
                Dim negocioPelicula As New NegociosCatalogo()
                negocioPelicula.modificarPelicula(abmPelicula.UNA_PELICULA)
                Me.BtnBorrar.Enabled = False
                Me.BtnModificar.Enabled = False
                VideoCubNegocios.VIDEOCLUB.Tables("Peliculas").Clear()
                VideoCubNegocios.cargarDatosCatalogo()
                Me.DataGridCatalogo.DataSource = VideoClubNegocios.VideoCubNegocios.VIDEOCLUB.Tables("Peliculas")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub cargarCombo()
        Me.CmbBuscar.Items.AddRange(New String() {"Titulo", "Genero", "Formato"})
    End Sub

    Private Sub TxtIngreseBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIngreseBusqueda.TextChanged
        buscar(CmbBuscar.SelectedItem.ToString, TxtIngreseBusqueda.Text)
    End Sub


    Private Sub buscar(ByVal campo As String, ByVal valor As String)
        Try
            Dim expresion = campo & " like'%" & valor & "%'"
            Dim tablaaux As DataTable = VideoCubNegocios.VIDEOCLUB.Tables("Peliculas").Clone()
            Dim filas As DataRow() = VideoCubNegocios.VIDEOCLUB.Tables("Peliculas").Select(expresion)
            For Each dr As DataRow In filas
                tablaaux.ImportRow(dr)
            Next
            Me.DataGridCatalogo.DataSource = tablaaux
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub CmbBuscar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBuscar.SelectedIndexChanged
        Me.ErrorProviderBusquedaPelicula.Clear()
        Me.TxtIngreseBusqueda.Enabled = True
    End Sub
End Class
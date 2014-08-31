Public Class FrmPrincipal

    Private Sub CLIENTESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLIENTESToolStripMenuItem.Click
        Dim frmclientes As New FrmClientes
        frmclientes.MdiParent = Me
        frmclientes.Show()
    End Sub

    Private Sub CATALOGODEPELICULASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CATALOGODEPELICULASToolStripMenuItem.Click
        Dim frmPeliculas As New FrmCatalogo
        frmPeliculas.MdiParent = Me
        frmPeliculas.Show()
    End Sub

    Private Sub VENTAYALQUILERESDEPELIUCLASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VENTAYALQUILERESDEPELIUCLASToolStripMenuItem.Click
        Dim frmVentaCompra As New FrmComprasAlquileres
        frmVentaCompra.MdiParent = Me
        frmVentaCompra.Show()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRToolStripMenuItem.Click
        If DialogResult.Yes = MessageBox.Show("Usted esta a punto de cerrar el programa desea continuar", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            Me.Close()
        End If
    End Sub

    Private Sub ACERCADEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACERCADEToolStripMenuItem.Click
        Dim acerca As New AcercaDe()
        acerca.MdiParent = Me
        acerca.Show()
    End Sub

    Private Sub FrmPrincipal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            VideoClubNegocios.VideoCubNegocios.iniciar()
            VideoClubNegocios.VideoCubNegocios.cargarDatosCliente()
            VideoClubNegocios.VideoCubNegocios.cargarDatosCatalogo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ExportarClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarClientesToolStripMenuItem.Click
        Dim frmExportar As New FrmExportar()
        frmExportar.MdiParent = Me
        frmExportar.Show()
    End Sub

    Private Sub ImportarClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportarClientesToolStripMenuItem.Click
        Dim frmImportar As New FrmImportar()
        frmImportar.MdiParent = Me
        frmImportar.Show()
    End Sub

    Private Sub VERTOTALDECOMPRASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VERTOTALDECOMPRASToolStripMenuItem.Click
        Dim frmvista As New FrmVistadeCompras()
        frmvista.MdiParent = Me
        frmvista.Show()
    End Sub
End Class

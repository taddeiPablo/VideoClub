Imports System
Imports VideoClubNegocios

Public Class FrmVistadeCompras

    Private cont As Integer = 0

    Private Sub SALIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FrmVistadeCompras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim vistaCompras As New NegociosCompras()
        vistaCompras.cargarVistaCompras(VideoCubNegocios.VIDEOCLUB.Tables("VistaCompras"))
        Me.DataGridView1.DataSource = VideoCubNegocios.VIDEOCLUB.Tables("VistaCompras")
        For Each dtvista As DataRow In VideoCubNegocios.VIDEOCLUB.Tables("VistaCompras").Rows
            Dim valor As Integer = Integer.Parse(dtvista("TotalCompra").ToString)
            cont += valor
        Next
        Label2.Text = "$ " & cont
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim valor As Date = DateTimePicker1.Value

    End Sub
End Class
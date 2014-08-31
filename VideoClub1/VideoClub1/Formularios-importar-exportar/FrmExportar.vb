Imports VideoClubNegocios

Public Class FrmExportar

    Private negocioCliente As NegociosClientes



    Private Sub BtnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExportar.Click
        Try
            Dim nombreArchivo As String = TextBox1.Text
            Dim cantClientes As Integer = Me.negocioCliente.exportarXML(Application.StartupPath & "\Exportaciones\" & nombreArchivo & ".xml")
            Label3.Text = cantClientes
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmExportar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.negocioCliente = New NegociosClientes()
    End Sub
End Class
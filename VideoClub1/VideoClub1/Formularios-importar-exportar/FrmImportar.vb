Imports VideoClubNegocios
Imports VideoClubEntidades


Public Class FrmImportar

    Private negociosCliente As NegociosClientes
    Private nombreArchivo As String = String.Empty


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Button2.Enabled = True
            Me.nombreArchivo = OpenFileDialog1.FileName
            Label2.Text = Me.nombreArchivo
        End If
    End Sub

    Private Sub FrmImportar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Button2.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
       Try
            negociosCliente = New NegociosClientes()
            Dim cantRegistrosRepetidos As Integer = 0
            Dim cantClientesAgregados As Integer = 0
            Dim manejador As New ManejadorXML()
            manejador.importarSocios(Me.nombreArchivo, cantRegistrosRepetidos, cantClientesAgregados)
            negociosCliente.importarClientesBD(manejador.getLista(), cantRegistrosRepetidos, cantClientesAgregados)
            Label7.Text = cantClientesAgregados
            Label8.Text = cantRegistrosRepetidos
            VideoCubNegocios.iniciar()
            VideoCubNegocios.cargarDatosCliente()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
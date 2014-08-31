Imports VideoClubNegocios
Imports VideoClubEntidades


Public Class FrmClientes

    Private uncliente As Cliente
    Private selec As String

    Private Sub BtnNuevoC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevoC.Click
        Dim abmcliente As New FrmABMclientes()
        If DialogResult.OK = abmcliente.ShowDialog() Then
            Try
                Dim negociosClientes As New NegociosClientes()
                If negociosClientes.getExisteCliente(abmcliente.UN_CLIENTE.DNI_Cliente) Then
                    MessageBox.Show("Este cliente ya a sido registrado con anterioridad", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    negociosClientes.guardarNuevoCliente(abmcliente.UN_CLIENTE)
                    VideoCubNegocios.VIDEOCLUB.Tables("Clientes").Clear()
                    VideoCubNegocios.cargarDatosCliente()
                    Me.DataGripClientes.DataSource = VideoCubNegocios.VIDEOCLUB.Tables("Clientes")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FrmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cargarCombo()
            Me.TextBox1.Enabled = False
            ErrorProviderBusqueda.SetError(Me.TextBox1, "Seleccion primera un campo para la busqueda")
            Me.DataGripClientes.DataSource = VideoCubNegocios.VIDEOCLUB.Tables("Clientes")
            Me.DataGripClientes.Columns("IdCliente").Visible = False
            Me.BtnModC.Enabled = False
            Me.BtnBorrarC.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnModC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModC.Click
        Try
            Dim abmcliente As New FrmABMclientes()
            abmcliente.UN_CLIENTE = Me.uncliente
            If DialogResult.OK = abmcliente.ShowDialog() Then
                Dim negociosClienten As New NegociosClientes()
                negociosClienten.modificarCliente(abmcliente.UN_CLIENTE)
                VideoCubNegocios.VIDEOCLUB.Tables("Clientes").Clear()
                VideoCubNegocios.cargarDatosCliente()
                Me.DataGripClientes.DataSource = VideoCubNegocios.VIDEOCLUB.Tables("Clientes")
            End If
            Me.BtnBorrarC.Enabled = False
            Me.BtnModC.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGripClientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGripClientes.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim idcliente As Integer = Integer.Parse(Me.DataGripClientes.Rows(e.RowIndex).Cells("IdCliente").Value)
            Dim nombre As String = Me.DataGripClientes.Rows(e.RowIndex).Cells("Nombre").Value
            Dim apellido As String = Me.DataGripClientes.Rows(e.RowIndex).Cells("Apellido").Value
            Dim dni As String = Me.DataGripClientes.Rows(e.RowIndex).Cells("Dni").Value
            Dim direccion As String = Me.DataGripClientes.Rows(e.RowIndex).Cells("Direccion").Value
            Dim telefono As String = Me.DataGripClientes.Rows(e.RowIndex).Cells("Telefono").Value
            Dim email As String = Me.DataGripClientes.Rows(e.RowIndex).Cells("Email").Value
            Me.uncliente = New Cliente(idcliente, nombre, apellido, dni, direccion, telefono, email)
            Me.DataGripClientes.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Aqua
            Me.BtnBorrarC.Enabled = True
            Me.BtnModC.Enabled = True
        End If
    End Sub

    Private Sub BtnBorrarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrarC.Click
        Try
            Dim negociosCliente As New NegociosClientes()
            If DialogResult.Yes = MessageBox.Show("USTED ESTA POR BORRAR UN CLIENTE DESEA CONTINUAR", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                If negociosCliente.getExisteAlquilerCompra(Me.uncliente.IDcliente_Cliente) Then
                    negociosCliente.borrarClienteAlquileresYcompras(Me.uncliente)
                Else
                    negociosCliente.borrarCliente(uncliente)
                End If
            End If
            Me.BtnBorrarC.Enabled = False
            Me.BtnModC.Enabled = False
            VideoCubNegocios.VIDEOCLUB.Tables("Clientes").Clear()
            VideoCubNegocios.cargarDatosCliente()
            Me.DataGripClientes.DataSource = VideoCubNegocios.VIDEOCLUB.Tables("Clientes")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cargarCombo()
        Me.ComboBox1.Items.AddRange(New String() {"Nombre", "Apellido", "Dni"})
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        buscar(ComboBox1.SelectedItem.ToString, TextBox1.Text)
    End Sub

    Private Sub buscar(ByVal campo As String, ByVal valor As String)
        Try
            Dim expresion = campo & " like'%" & valor & "%'"
            Dim tablaaux As DataTable = VideoCubNegocios.VIDEOCLUB.Tables("Clientes").Clone()
            Dim filas As DataRow() = VideoCubNegocios.VIDEOCLUB.Tables("Clientes").Select(expresion)
            For Each dr As DataRow In filas
                tablaaux.ImportRow(dr)
            Next
            Me.DataGripClientes.DataSource = tablaaux
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.TextBox1.Enabled = True
        ErrorProviderBusqueda.Clear()
    End Sub
End Class
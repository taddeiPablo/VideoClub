Imports VideoClubEntidades
Imports VideoClubNegocios

Public Class FrmComprasAlquileres

    Private uncliente As Cliente

    Private Sub BtnAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAlta.Click
        Dim alquileres As New FrmABMalquileres

        If Not uncliente Is Nothing Then
            alquileres.ID_CLIENTE = uncliente.IDcliente_Cliente
            If DialogResult.OK = alquileres.ShowDialog() Then
                Dim negociosAlquiler As New NegociosAlquileres()
                negociosAlquiler.guardarAlquiler(alquileres.ALQUILER)
                MessageBox.Show("EL ALQUILER A SIDO GUARDADO CON EXITO", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("DEBE BUSCAR PRIMERO EL CLIENTE", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnAltaC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAltaC.Click
        Dim compra As New FrmCompras

        If Not uncliente Is Nothing Then
            compra.ID_CLIENTE = uncliente.IDcliente_Cliente
            If DialogResult.OK = compra.ShowDialog() Then
                Dim negocioCompra As New NegociosCompras()
                negocioCompra.cargandoCompras(compra.COMPRA)
                MessageBox.Show("LA COMPRA A SIDO GUARDADO CON EXITO", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("DEBE BUSCAR PRIMERO EL CLIENTE", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Try
            buscarCliente(CmbBoxBusqueda.SelectedItem.ToString, TxtBoxIngreseBusqueda.Text)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub FrmComprasAlquileres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmbBoxBusqueda.Items.AddRange(New String() {"Nombre", "Apellido", "Dni"})
        Me.ErrorProviderBusquedaCliente.SetError(Me.TxtBoxIngreseBusqueda, "Seleccione un criterio de busqueda primero")
        Me.TxtBoxIngreseBusqueda.Enabled = False
    End Sub

    Public Sub buscarCliente(ByVal campo As String, ByVal valor As String)
        Try
            Dim expresion = campo & " like'%" & valor & "%'"
            Dim tablaaux As DataTable = VideoCubNegocios.VIDEOCLUB.Tables("Clientes").Clone()
            Dim filas As DataRow() = VideoCubNegocios.VIDEOCLUB.Tables("Clientes").Select(expresion)
            Dim idCliente As Integer = 0
            Dim nombre As String = String.Empty
            Dim apellido As String = String.Empty
            Dim dni As String = String.Empty
            Dim direccion As String = String.Empty
            Dim telefono As String = String.Empty
            Dim email As String = String.Empty
            For Each row As DataRow In filas
                idCliente = Integer.Parse(row("idCliente").ToString)
                nombre = row("Nombre").ToString
                apellido = row("Apellido").ToString
                dni = row("dni").ToString
                direccion = row("direccion").ToString
                telefono = row("Telefono").ToString
                email = row("Email").ToString
            Next
            Me.uncliente = New Cliente(idCliente, nombre, apellido, dni, direccion, telefono, email)
            LblNombre.Text = Me.uncliente.Nombre_Cliente
            LblApellido.Text = Me.uncliente.Apellido_Cliente
            LblTelefono.Text = Me.uncliente.Telefono_Cliente
            LblEmail.Text = Me.uncliente.Email_Cliente
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CheckAlquileres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckAlquileres.CheckedChanged
        Try
            If CheckAlquileres.Checked Then
                If Not Me.uncliente Is Nothing Then
                    VideoCubNegocios.VIDEOCLUB.Tables("Alquileres").Clear()
                    Dim negocioAlquileres As New NegociosAlquileres()
                    negocioAlquileres.cargandoAlquileres(Me.uncliente.IDcliente_Cliente, VideoCubNegocios.VIDEOCLUB.Tables("Alquileres"))

                    If VideoCubNegocios.VIDEOCLUB.Tables("Alquileres").Rows.Count = 0 Then
                        MessageBox.Show("ESTE CLIENTE NO A REALIZADO NINGUN ALQUILER HASTA EL MOMENTO", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        Me.DtgAlquileres.DataSource = VideoCubNegocios.VIDEOCLUB.Tables("Alquileres")
                        Me.DtgAlquileres.Columns("IdPelicula").Visible = False
                        Me.DtgAlquileres.Columns("IdAlquiler").Visible = False
                        Me.DtgAlquileres.Columns("TotalAlquiler").Visible = False
                        Me.DtgAlquileres.Columns("ImagenPelicula").Visible = False
                    End If
                Else
                    MessageBox.Show("USTED DEBE BUSCAR UN CLIENTE PRIMERO", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                Me.DtgAlquileres.DataSource = ""
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CheckCompras_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckCompras.CheckedChanged
        Try
            If CheckCompras.Checked Then
                If Not Me.uncliente Is Nothing Then
                    VideoCubNegocios.VIDEOCLUB.Tables("Compras").Clear()
                    Dim negocioCompras As New NegociosCompras()
                    negocioCompras.cargandoCompras(Me.uncliente.IDcliente_Cliente, VideoCubNegocios.VIDEOCLUB.Tables("Compras"))

                    If VideoCubNegocios.VIDEOCLUB.Tables("Compras").Rows.Count = 0 Then
                        MessageBox.Show("ESTE CLIENTE NO A REALIZADO NINGUNA COMPRA HASTA EL MOMENTO", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        Me.DtgCompras.DataSource = VideoCubNegocios.VIDEOCLUB.Tables("Compras")
                        Me.DtgCompras.Columns("TotalCompra").Visible = False
                        Me.DtgCompras.Columns("ImagenPelicula").Visible = False
                    End If
                Else
                    MessageBox.Show("USTED DEBE BUSCAR PRIMERO UN CLIENTE", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                Me.DtgCompras.DataSource = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TxtIngreseAlquiler_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIngreseAlquiler.TextChanged
        Try
            If VideoCubNegocios.VIDEOCLUB.Tables("Alquileres").Rows.Count <> 0 Then
                Dim valor As String = TxtIngreseAlquiler.Text
                Dim expresion = "titulo like'%" & valor & "%'"
                Dim tablaaux As DataTable = VideoCubNegocios.VIDEOCLUB.Tables("Alquileres").Clone()
                Dim filas As DataRow() = VideoCubNegocios.VIDEOCLUB.Tables("Alquileres").Select(expresion)
                For Each dr As DataRow In filas
                    tablaaux.ImportRow(dr)
                Next
                Me.DtgAlquileres.DataSource = tablaaux
                Me.DtgAlquileres.Columns("TotalCompra").Visible = False
                Me.DtgAlquileres.Columns("ImagenPelicula").Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TxtIngreseCp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIngreseCp.TextChanged
        Try
            If VideoCubNegocios.VIDEOCLUB.Tables("Compras").Rows.Count <> 0 Then
                Dim valor As String = TxtIngreseCp.Text
                Dim expresion = "Titulo like'%" & valor & "%'"
                Dim tablaaux As DataTable = VideoCubNegocios.VIDEOCLUB.Tables("Compras").Clone()
                Dim filas As DataRow() = VideoCubNegocios.VIDEOCLUB.Tables("Compras").Select(expresion)
                For Each dr As DataRow In filas
                    tablaaux.ImportRow(dr)
                Next
                Me.DtgCompras.DataSource = tablaaux
                Me.DtgCompras.Columns("TotalCompra").Visible = False
                Me.DtgCompras.Columns("ImagenPelicula").Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DtgAlquileres_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgAlquileres.CellContentClick

        If e.ColumnIndex = 0 Then
            Dim idPelicula As Integer = Me.DtgAlquileres.Rows(e.RowIndex).Cells("IdPelicula").Value
            Dim idAlq As Integer = Me.DtgAlquileres.Rows(e.RowIndex).Cells("IdAlquiler").Value
            Dim titulo As String = Me.DtgAlquileres.Rows(e.RowIndex).Cells("Titulo").Value
            Dim genero As String = Me.DtgAlquileres.Rows(e.RowIndex).Cells("Genero").Value
            Dim formato As String = Me.DtgAlquileres.Rows(e.RowIndex).Cells("Formato").Value
            Dim imagen As Image = getImages(Me.DtgAlquileres.Rows(e.RowIndex).Cells("ImagenPelicula").Value)
            Dim totalAlq As Single = Me.DtgAlquileres.Rows(e.RowIndex).Cells("TotalAlquiler").Value
            Dim tipoPago As String = Me.DtgAlquileres.Rows(e.RowIndex).Cells("TipodePago").Value
            Dim fechaAlq As Date = Me.DtgAlquileres.Rows(e.RowIndex).Cells("FechaInicio").Value
            Dim fechFinal As Date = Me.DtgAlquileres.Rows(e.RowIndex).Cells("FechaFinal").Value
            Dim frmDetalleAlq As New FrmDetalleAlq(Me.uncliente.IDcliente_Cliente, idPelicula, idAlq, titulo, genero, formato, imagen, totalAlq, tipoPago, fechaAlq, fechFinal)
            frmDetalleAlq.Show()
        End If
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

    Private Sub DtgCompras_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgCompras.CellContentClick

        If e.ColumnIndex = 0 Then
            Dim titulo As String = Me.DtgCompras.Rows(e.RowIndex).Cells("Titulo").Value
            Dim genero As String = Me.DtgCompras.Rows(e.RowIndex).Cells("Genero").Value
            Dim formato As String = Me.DtgCompras.Rows(e.RowIndex).Cells("Formato").Value
            Dim tipoPago As String = Me.DtgCompras.Rows(e.RowIndex).Cells("TipodePago").Value
            Dim total As Single = Me.DtgCompras.Rows(e.RowIndex).Cells("TotalCompra").Value
            Dim imagen As Image = getImages(Me.DtgCompras.Rows(e.RowIndex).Cells("ImagenPelicula").Value)
            Dim frmDetalleCompras As New FrmDetalleCompra(titulo, genero, formato, tipoPago, total, imagen)
            frmDetalleCompras.Show()
        End If
    End Sub

    Private Sub CmbBoxBusqueda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBoxBusqueda.SelectedIndexChanged
        Me.ErrorProviderBusquedaCliente.Clear()
        Me.TxtBoxIngreseBusqueda.Enabled = True
    End Sub




End Class
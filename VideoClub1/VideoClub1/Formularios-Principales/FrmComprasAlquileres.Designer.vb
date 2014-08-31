<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComprasAlquileres
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ARCHIVOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GrpBox = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckCompras = New System.Windows.Forms.CheckBox
        Me.CheckAlquileres = New System.Windows.Forms.CheckBox
        Me.BtnAltaC = New System.Windows.Forms.Button
        Me.lblCmopra = New System.Windows.Forms.Label
        Me.TxtIngreseCp = New System.Windows.Forms.TextBox
        Me.BtnAlta = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtIngreseAlquiler = New System.Windows.Forms.TextBox
        Me.DtgCompras = New System.Windows.Forms.DataGridView
        Me.Detalle = New System.Windows.Forms.DataGridViewButtonColumn
        Me.DtgAlquileres = New System.Windows.Forms.DataGridView
        Me.verDetalle = New System.Windows.Forms.DataGridViewButtonColumn
        Me.LblEmail = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.LblTelefono = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.LblApellido = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LblNombre = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnBuscar = New System.Windows.Forms.Button
        Me.TxtBoxIngreseBusqueda = New System.Windows.Forms.TextBox
        Me.CmbBoxBusqueda = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblBusqueda = New System.Windows.Forms.Label
        Me.ErrorProviderBusquedaCliente = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.GrpBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DtgCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgAlquileres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProviderBusquedaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowDrop = True
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ARCHIVOToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1019, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ARCHIVOToolStripMenuItem
        '
        Me.ARCHIVOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ARCHIVOToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.ARCHIVOToolStripMenuItem.Name = "ARCHIVOToolStripMenuItem"
        Me.ARCHIVOToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ARCHIVOToolStripMenuItem.Text = "ARCHIVO"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "SALIR"
        '
        'GrpBox
        '
        Me.GrpBox.Controls.Add(Me.GroupBox1)
        Me.GrpBox.Controls.Add(Me.GroupBox2)
        Me.GrpBox.ForeColor = System.Drawing.Color.Navy
        Me.GrpBox.Location = New System.Drawing.Point(12, 50)
        Me.GrpBox.Name = "GrpBox"
        Me.GrpBox.Size = New System.Drawing.Size(995, 506)
        Me.GrpBox.TabIndex = 2
        Me.GrpBox.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckCompras)
        Me.GroupBox1.Controls.Add(Me.CheckAlquileres)
        Me.GroupBox1.Controls.Add(Me.BtnAltaC)
        Me.GroupBox1.Controls.Add(Me.lblCmopra)
        Me.GroupBox1.Controls.Add(Me.TxtIngreseCp)
        Me.GroupBox1.Controls.Add(Me.BtnAlta)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TxtIngreseAlquiler)
        Me.GroupBox1.Controls.Add(Me.DtgCompras)
        Me.GroupBox1.Controls.Add(Me.DtgAlquileres)
        Me.GroupBox1.Controls.Add(Me.LblEmail)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.LblTelefono)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.LblApellido)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LblNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(983, 398)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'CheckCompras
        '
        Me.CheckCompras.AutoSize = True
        Me.CheckCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckCompras.Location = New System.Drawing.Point(501, 61)
        Me.CheckCompras.Name = "CheckCompras"
        Me.CheckCompras.Size = New System.Drawing.Size(74, 17)
        Me.CheckCompras.TabIndex = 27
        Me.CheckCompras.Text = "Compras"
        Me.CheckCompras.UseVisualStyleBackColor = True
        '
        'CheckAlquileres
        '
        Me.CheckAlquileres.AutoSize = True
        Me.CheckAlquileres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckAlquileres.Location = New System.Drawing.Point(9, 61)
        Me.CheckAlquileres.Name = "CheckAlquileres"
        Me.CheckAlquileres.Size = New System.Drawing.Size(81, 17)
        Me.CheckAlquileres.TabIndex = 26
        Me.CheckAlquileres.Text = "Alquileres"
        Me.CheckAlquileres.UseVisualStyleBackColor = True
        '
        'BtnAltaC
        '
        Me.BtnAltaC.Location = New System.Drawing.Point(887, 366)
        Me.BtnAltaC.Name = "BtnAltaC"
        Me.BtnAltaC.Size = New System.Drawing.Size(90, 25)
        Me.BtnAltaC.TabIndex = 23
        Me.BtnAltaC.Text = "Nueva Compra"
        Me.BtnAltaC.UseVisualStyleBackColor = True
        '
        'lblCmopra
        '
        Me.lblCmopra.AutoSize = True
        Me.lblCmopra.Location = New System.Drawing.Point(504, 352)
        Me.lblCmopra.Name = "lblCmopra"
        Me.lblCmopra.Size = New System.Drawing.Size(93, 13)
        Me.lblCmopra.TabIndex = 22
        Me.lblCmopra.Text = "Buscar por Titulo :"
        '
        'TxtIngreseCp
        '
        Me.TxtIngreseCp.Location = New System.Drawing.Point(507, 371)
        Me.TxtIngreseCp.Name = "TxtIngreseCp"
        Me.TxtIngreseCp.Size = New System.Drawing.Size(179, 20)
        Me.TxtIngreseCp.TabIndex = 21
        '
        'BtnAlta
        '
        Me.BtnAlta.Location = New System.Drawing.Point(392, 367)
        Me.BtnAlta.Name = "BtnAlta"
        Me.BtnAlta.Size = New System.Drawing.Size(93, 25)
        Me.BtnAlta.TabIndex = 16
        Me.BtnAlta.Text = "Nuevo Alquiler"
        Me.BtnAlta.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 353)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Buscar por Titulo :"
        '
        'TxtIngreseAlquiler
        '
        Me.TxtIngreseAlquiler.Location = New System.Drawing.Point(9, 369)
        Me.TxtIngreseAlquiler.Name = "TxtIngreseAlquiler"
        Me.TxtIngreseAlquiler.Size = New System.Drawing.Size(177, 20)
        Me.TxtIngreseAlquiler.TabIndex = 14
        '
        'DtgCompras
        '
        Me.DtgCompras.AllowUserToAddRows = False
        Me.DtgCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Detalle})
        Me.DtgCompras.Location = New System.Drawing.Point(501, 84)
        Me.DtgCompras.Name = "DtgCompras"
        Me.DtgCompras.Size = New System.Drawing.Size(476, 239)
        Me.DtgCompras.TabIndex = 11
        '
        'Detalle
        '
        Me.Detalle.HeaderText = "Detalle"
        Me.Detalle.Name = "Detalle"
        Me.Detalle.Text = "Ver Detalle"
        Me.Detalle.ToolTipText = "Ver Detalle"
        Me.Detalle.UseColumnTextForButtonValue = True
        '
        'DtgAlquileres
        '
        Me.DtgAlquileres.AllowUserToAddRows = False
        Me.DtgAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgAlquileres.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.verDetalle})
        Me.DtgAlquileres.Location = New System.Drawing.Point(9, 84)
        Me.DtgAlquileres.Name = "DtgAlquileres"
        Me.DtgAlquileres.Size = New System.Drawing.Size(476, 239)
        Me.DtgAlquileres.TabIndex = 10
        '
        'verDetalle
        '
        Me.verDetalle.HeaderText = "Ver Detalle"
        Me.verDetalle.Name = "verDetalle"
        Me.verDetalle.Text = "Ver Detalle"
        Me.verDetalle.ToolTipText = "Ver Detalle"
        Me.verDetalle.UseColumnTextForButtonValue = True
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.Location = New System.Drawing.Point(491, 14)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(47, 15)
        Me.LblEmail.TabIndex = 7
        Me.LblEmail.Text = "--------"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(440, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Email :"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefono.Location = New System.Drawing.Point(352, 14)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(37, 15)
        Me.LblTelefono.TabIndex = 5
        Me.LblTelefono.Text = "------"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(287, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Telefono :"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellido.Location = New System.Drawing.Point(206, 14)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(37, 15)
        Me.LblApellido.TabIndex = 3
        Me.LblApellido.Text = "------"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(144, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Apellido :"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(70, 14)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(42, 15)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "-------"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnBuscar)
        Me.GroupBox2.Controls.Add(Me.TxtBoxIngreseBusqueda)
        Me.GroupBox2.Controls.Add(Me.CmbBoxBusqueda)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblBusqueda)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(619, 72)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(471, 30)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(130, 23)
        Me.BtnBuscar.TabIndex = 4
        Me.BtnBuscar.Text = "BUSCAR"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtBoxIngreseBusqueda
        '
        Me.TxtBoxIngreseBusqueda.Location = New System.Drawing.Point(209, 33)
        Me.TxtBoxIngreseBusqueda.Name = "TxtBoxIngreseBusqueda"
        Me.TxtBoxIngreseBusqueda.Size = New System.Drawing.Size(182, 20)
        Me.TxtBoxIngreseBusqueda.TabIndex = 3
        '
        'CmbBoxBusqueda
        '
        Me.CmbBoxBusqueda.FormattingEnabled = True
        Me.CmbBoxBusqueda.Location = New System.Drawing.Point(9, 32)
        Me.CmbBoxBusqueda.Name = "CmbBoxBusqueda"
        Me.CmbBoxBusqueda.Size = New System.Drawing.Size(155, 21)
        Me.CmbBoxBusqueda.TabIndex = 2
        Me.CmbBoxBusqueda.Text = "Seleccionar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingrese busqueda :"
        '
        'lblBusqueda
        '
        Me.lblBusqueda.AutoSize = True
        Me.lblBusqueda.Location = New System.Drawing.Point(6, 16)
        Me.lblBusqueda.Name = "lblBusqueda"
        Me.lblBusqueda.Size = New System.Drawing.Size(99, 13)
        Me.lblBusqueda.TabIndex = 0
        Me.lblBusqueda.Text = "Buscar Cliente por :"
        '
        'ErrorProviderBusquedaCliente
        '
        Me.ErrorProviderBusquedaCliente.ContainerControl = Me
        '
        'FrmComprasAlquileres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1019, 568)
        Me.ControlBox = False
        Me.Controls.Add(Me.GrpBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FrmComprasAlquileres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compra y Alquileres de Peliculas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GrpBox.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DtgCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgAlquileres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProviderBusquedaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ARCHIVOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrpBox As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAltaC As System.Windows.Forms.Button
    Friend WithEvents lblCmopra As System.Windows.Forms.Label
    Friend WithEvents TxtIngreseCp As System.Windows.Forms.TextBox
    Friend WithEvents BtnAlta As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtIngreseAlquiler As System.Windows.Forms.TextBox
    Friend WithEvents DtgCompras As System.Windows.Forms.DataGridView
    Friend WithEvents DtgAlquileres As System.Windows.Forms.DataGridView
    Friend WithEvents LblEmail As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LblTelefono As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblApellido As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents TxtBoxIngreseBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents CmbBoxBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblBusqueda As System.Windows.Forms.Label
    Friend WithEvents CheckCompras As System.Windows.Forms.CheckBox
    Friend WithEvents CheckAlquileres As System.Windows.Forms.CheckBox
    Friend WithEvents Detalle As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents verDetalle As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ErrorProviderBusquedaCliente As System.Windows.Forms.ErrorProvider
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnModC = New System.Windows.Forms.Button
        Me.BtnBorrarC = New System.Windows.Forms.Button
        Me.BtnNuevoC = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGripClientes = New System.Windows.Forms.DataGridView
        Me.Seleccion = New System.Windows.Forms.DataGridViewButtonColumn
        Me.ErrorProviderBusqueda = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGripClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(640, 24)
        Me.MenuStrip1.TabIndex = 0
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnModC)
        Me.GroupBox2.Controls.Add(Me.BtnBorrarC)
        Me.GroupBox2.Controls.Add(Me.BtnNuevoC)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(3, 386)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(635, 96)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Panel"
        '
        'BtnModC
        '
        Me.BtnModC.Location = New System.Drawing.Point(550, 49)
        Me.BtnModC.Name = "BtnModC"
        Me.BtnModC.Size = New System.Drawing.Size(75, 26)
        Me.BtnModC.TabIndex = 6
        Me.BtnModC.Text = "Modificar"
        Me.BtnModC.UseVisualStyleBackColor = True
        '
        'BtnBorrarC
        '
        Me.BtnBorrarC.Location = New System.Drawing.Point(458, 49)
        Me.BtnBorrarC.Name = "BtnBorrarC"
        Me.BtnBorrarC.Size = New System.Drawing.Size(75, 26)
        Me.BtnBorrarC.TabIndex = 5
        Me.BtnBorrarC.Text = "Borrar"
        Me.BtnBorrarC.UseVisualStyleBackColor = True
        '
        'BtnNuevoC
        '
        Me.BtnNuevoC.Location = New System.Drawing.Point(362, 49)
        Me.BtnNuevoC.Name = "BtnNuevoC"
        Me.BtnNuevoC.Size = New System.Drawing.Size(75, 26)
        Me.BtnNuevoC.TabIndex = 4
        Me.BtnNuevoC.Text = "Nuevo"
        Me.BtnNuevoC.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(138, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(165, 21)
        Me.TextBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ingrese su busqueda :"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(9, 52)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar por :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGripClientes)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(5, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(635, 332)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Clientes"
        '
        'DataGripClientes
        '
        Me.DataGripClientes.AllowUserToAddRows = False
        Me.DataGripClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGripClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccion})
        Me.DataGripClientes.Location = New System.Drawing.Point(6, 20)
        Me.DataGripClientes.Name = "DataGripClientes"
        Me.DataGripClientes.Size = New System.Drawing.Size(619, 306)
        Me.DataGripClientes.TabIndex = 0
        '
        'Seleccion
        '
        Me.Seleccion.HeaderText = "Seleccionar"
        Me.Seleccion.Name = "Seleccion"
        Me.Seleccion.Text = "Seleccionar"
        Me.Seleccion.ToolTipText = "Seleccionar"
        Me.Seleccion.UseColumnTextForButtonValue = True
        '
        'ErrorProviderBusqueda
        '
        Me.ErrorProviderBusqueda.ContainerControl = Me
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(640, 484)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FrmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLIENTES"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGripClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ARCHIVOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnModC As System.Windows.Forms.Button
    Friend WithEvents BtnBorrarC As System.Windows.Forms.Button
    Friend WithEvents BtnNuevoC As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGripClientes As System.Windows.Forms.DataGridView
    Friend WithEvents Seleccion As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ErrorProviderBusqueda As System.Windows.Forms.ErrorProvider
End Class

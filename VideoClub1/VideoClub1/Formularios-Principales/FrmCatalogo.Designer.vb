<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCatalogo
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnModificar = New System.Windows.Forms.Button
        Me.BtnBorrar = New System.Windows.Forms.Button
        Me.BtnNuevo = New System.Windows.Forms.Button
        Me.TxtIngreseBusqueda = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbBuscar = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.PictureBoxPelicula = New System.Windows.Forms.PictureBox
        Me.LblCant = New System.Windows.Forms.Label
        Me.LblPrecioComp = New System.Windows.Forms.Label
        Me.LblPrecioAlq = New System.Windows.Forms.Label
        Me.LblFormato = New System.Windows.Forms.Label
        Me.LblGenero = New System.Windows.Forms.Label
        Me.LblTitulo = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DataGridCatalogo = New System.Windows.Forms.DataGridView
        Me.Seleccion = New System.Windows.Forms.DataGridViewButtonColumn
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ARCHIVOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ErrorProviderBusquedaPelicula = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBoxPelicula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ErrorProviderBusquedaPelicula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnModificar)
        Me.GroupBox2.Controls.Add(Me.BtnBorrar)
        Me.GroupBox2.Controls.Add(Me.BtnNuevo)
        Me.GroupBox2.Controls.Add(Me.TxtIngreseBusqueda)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.CmbBuscar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(12, 445)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(994, 68)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Panel"
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(853, 29)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(135, 29)
        Me.BtnModificar.TabIndex = 8
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(719, 28)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(117, 30)
        Me.BtnBorrar.TabIndex = 7
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(589, 28)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(111, 30)
        Me.BtnNuevo.TabIndex = 6
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'TxtIngreseBusqueda
        '
        Me.TxtIngreseBusqueda.Location = New System.Drawing.Point(286, 33)
        Me.TxtIngreseBusqueda.Name = "TxtIngreseBusqueda"
        Me.TxtIngreseBusqueda.Size = New System.Drawing.Size(190, 21)
        Me.TxtIngreseBusqueda.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ingrese : "
        '
        'CmbBuscar
        '
        Me.CmbBuscar.FormattingEnabled = True
        Me.CmbBuscar.Location = New System.Drawing.Point(96, 33)
        Me.CmbBuscar.Name = "CmbBuscar"
        Me.CmbBuscar.Size = New System.Drawing.Size(121, 23)
        Me.CmbBuscar.TabIndex = 3
        Me.CmbBuscar.Text = "Seleccionar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar por :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.DataGridCatalogo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(994, 384)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Peliculas"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBoxPelicula)
        Me.GroupBox3.Controls.Add(Me.LblCant)
        Me.GroupBox3.Controls.Add(Me.LblPrecioComp)
        Me.GroupBox3.Controls.Add(Me.LblPrecioAlq)
        Me.GroupBox3.Controls.Add(Me.LblFormato)
        Me.GroupBox3.Controls.Add(Me.LblGenero)
        Me.GroupBox3.Controls.Add(Me.LblTitulo)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(502, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(486, 366)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'PictureBoxPelicula
        '
        Me.PictureBoxPelicula.Location = New System.Drawing.Point(6, 20)
        Me.PictureBoxPelicula.Name = "PictureBoxPelicula"
        Me.PictureBoxPelicula.Size = New System.Drawing.Size(213, 311)
        Me.PictureBoxPelicula.TabIndex = 0
        Me.PictureBoxPelicula.TabStop = False
        '
        'LblCant
        '
        Me.LblCant.AutoSize = True
        Me.LblCant.Location = New System.Drawing.Point(342, 266)
        Me.LblCant.Name = "LblCant"
        Me.LblCant.Size = New System.Drawing.Size(37, 15)
        Me.LblCant.TabIndex = 13
        Me.LblCant.Text = "------"
        '
        'LblPrecioComp
        '
        Me.LblPrecioComp.AutoSize = True
        Me.LblPrecioComp.Location = New System.Drawing.Point(342, 217)
        Me.LblPrecioComp.Name = "LblPrecioComp"
        Me.LblPrecioComp.Size = New System.Drawing.Size(32, 15)
        Me.LblPrecioComp.TabIndex = 12
        Me.LblPrecioComp.Text = "-----"
        '
        'LblPrecioAlq
        '
        Me.LblPrecioAlq.AutoSize = True
        Me.LblPrecioAlq.Location = New System.Drawing.Point(340, 171)
        Me.LblPrecioAlq.Name = "LblPrecioAlq"
        Me.LblPrecioAlq.Size = New System.Drawing.Size(32, 15)
        Me.LblPrecioAlq.TabIndex = 11
        Me.LblPrecioAlq.Text = "-----"
        '
        'LblFormato
        '
        Me.LblFormato.AutoSize = True
        Me.LblFormato.Location = New System.Drawing.Point(291, 120)
        Me.LblFormato.Name = "LblFormato"
        Me.LblFormato.Size = New System.Drawing.Size(32, 15)
        Me.LblFormato.TabIndex = 10
        Me.LblFormato.Text = "-----"
        '
        'LblGenero
        '
        Me.LblGenero.AutoSize = True
        Me.LblGenero.Location = New System.Drawing.Point(291, 68)
        Me.LblGenero.Name = "LblGenero"
        Me.LblGenero.Size = New System.Drawing.Size(32, 15)
        Me.LblGenero.TabIndex = 9
        Me.LblGenero.Text = "-----"
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Location = New System.Drawing.Point(282, 20)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(32, 15)
        Me.LblTitulo.TabIndex = 8
        Me.LblTitulo.Text = "-----"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(226, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 15)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Stock :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(226, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Precio Compra :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(225, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Precio Alquiler :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(225, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Formato :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(225, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Genero :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(225, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Titulo :"
        '
        'DataGridCatalogo
        '
        Me.DataGridCatalogo.AllowUserToAddRows = False
        Me.DataGridCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCatalogo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccion})
        Me.DataGridCatalogo.Location = New System.Drawing.Point(6, 20)
        Me.DataGridCatalogo.Name = "DataGridCatalogo"
        Me.DataGridCatalogo.Size = New System.Drawing.Size(490, 358)
        Me.DataGridCatalogo.TabIndex = 0
        '
        'Seleccion
        '
        Me.Seleccion.HeaderText = "Seleccionar"
        Me.Seleccion.Name = "Seleccion"
        Me.Seleccion.Text = "Seleccionar"
        Me.Seleccion.ToolTipText = "Seleccionar"
        Me.Seleccion.UseColumnTextForButtonValue = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowDrop = True
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ARCHIVOToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1018, 24)
        Me.MenuStrip1.TabIndex = 10
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
        'ErrorProviderBusquedaPelicula
        '
        Me.ErrorProviderBusquedaPelicula.ContainerControl = Me
        '
        'FrmCatalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1018, 525)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmCatalogo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Peliculas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBoxPelicula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ErrorProviderBusquedaPelicula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents TxtIngreseBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LblCant As System.Windows.Forms.Label
    Friend WithEvents LblPrecioComp As System.Windows.Forms.Label
    Friend WithEvents LblPrecioAlq As System.Windows.Forms.Label
    Friend WithEvents LblFormato As System.Windows.Forms.Label
    Friend WithEvents LblGenero As System.Windows.Forms.Label
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBoxPelicula As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridCatalogo As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ARCHIVOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Seleccion As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ErrorProviderBusquedaPelicula As System.Windows.Forms.ErrorProvider
End Class

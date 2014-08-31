<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABMpeliculas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBoxPelicula = New System.Windows.Forms.PictureBox
        Me.BtnCargarImagen = New System.Windows.Forms.Button
        Me.LblMensaje = New System.Windows.Forms.Label
        Me.TxtCantidad = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtPrecioCompra = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtPrecioAlquiler = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtFormato = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtGenero = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtTitulo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ErrorProviderTitulo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderGenero = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderFormato = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderPrecioalq = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderPrecioComp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderCantidad = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxPelicula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderGenero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderFormato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderPrecioalq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderPrecioComp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.BtnCargarImagen)
        Me.GroupBox1.Controls.Add(Me.LblMensaje)
        Me.GroupBox1.Controls.Add(Me.TxtCantidad)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtPrecioCompra)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtPrecioAlquiler)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtFormato)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtGenero)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtTitulo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnAceptar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 366)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Peliculas"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBoxPelicula)
        Me.Panel1.Location = New System.Drawing.Point(294, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(218, 208)
        Me.Panel1.TabIndex = 17
        '
        'PictureBoxPelicula
        '
        Me.PictureBoxPelicula.Location = New System.Drawing.Point(3, 3)
        Me.PictureBoxPelicula.Name = "PictureBoxPelicula"
        Me.PictureBoxPelicula.Size = New System.Drawing.Size(209, 200)
        Me.PictureBoxPelicula.TabIndex = 15
        Me.PictureBoxPelicula.TabStop = False
        '
        'BtnCargarImagen
        '
        Me.BtnCargarImagen.Location = New System.Drawing.Point(370, 251)
        Me.BtnCargarImagen.Name = "BtnCargarImagen"
        Me.BtnCargarImagen.Size = New System.Drawing.Size(75, 23)
        Me.BtnCargarImagen.TabIndex = 16
        Me.BtnCargarImagen.Text = "..."
        Me.BtnCargarImagen.UseVisualStyleBackColor = True
        '
        'LblMensaje
        '
        Me.LblMensaje.AutoSize = True
        Me.LblMensaje.Location = New System.Drawing.Point(10, 290)
        Me.LblMensaje.Name = "LblMensaje"
        Me.LblMensaje.Size = New System.Drawing.Size(51, 15)
        Me.LblMensaje.TabIndex = 14
        Me.LblMensaje.Text = "Label7"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(13, 248)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(200, 21)
        Me.TxtCantidad.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cantidad :"
        '
        'TxtPrecioCompra
        '
        Me.TxtPrecioCompra.Location = New System.Drawing.Point(13, 209)
        Me.TxtPrecioCompra.Name = "TxtPrecioCompra"
        Me.TxtPrecioCompra.Size = New System.Drawing.Size(200, 21)
        Me.TxtPrecioCompra.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Precio Compra :"
        '
        'TxtPrecioAlquiler
        '
        Me.TxtPrecioAlquiler.Location = New System.Drawing.Point(13, 170)
        Me.TxtPrecioAlquiler.Name = "TxtPrecioAlquiler"
        Me.TxtPrecioAlquiler.Size = New System.Drawing.Size(200, 21)
        Me.TxtPrecioAlquiler.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Precio Alquiler :"
        '
        'TxtFormato
        '
        Me.TxtFormato.Location = New System.Drawing.Point(13, 131)
        Me.TxtFormato.Name = "TxtFormato"
        Me.TxtFormato.Size = New System.Drawing.Size(200, 21)
        Me.TxtFormato.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Formato :"
        '
        'TxtGenero
        '
        Me.TxtGenero.Location = New System.Drawing.Point(13, 92)
        Me.TxtGenero.Name = "TxtGenero"
        Me.TxtGenero.Size = New System.Drawing.Size(200, 21)
        Me.TxtGenero.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Genero :"
        '
        'TxtTitulo
        '
        Me.TxtTitulo.Location = New System.Drawing.Point(13, 53)
        Me.TxtTitulo.Name = "TxtTitulo"
        Me.TxtTitulo.Size = New System.Drawing.Size(200, 21)
        Me.TxtTitulo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Titulo :"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(421, 337)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(325, 337)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 0
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ErrorProviderTitulo
        '
        Me.ErrorProviderTitulo.ContainerControl = Me
        '
        'ErrorProviderGenero
        '
        Me.ErrorProviderGenero.ContainerControl = Me
        '
        'ErrorProviderFormato
        '
        Me.ErrorProviderFormato.ContainerControl = Me
        '
        'ErrorProviderPrecioalq
        '
        Me.ErrorProviderPrecioalq.ContainerControl = Me
        '
        'ErrorProviderPrecioComp
        '
        Me.ErrorProviderPrecioComp.ContainerControl = Me
        '
        'ErrorProviderCantidad
        '
        Me.ErrorProviderCantidad.ContainerControl = Me
        '
        'FrmABMpeliculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(528, 378)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmABMpeliculas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM Peliculas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBoxPelicula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderGenero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderFormato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderPrecioalq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderPrecioComp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBoxPelicula As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCargarImagen As System.Windows.Forms.Button
    Friend WithEvents LblMensaje As System.Windows.Forms.Label
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecioCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecioAlquiler As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtFormato As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtGenero As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ErrorProviderTitulo As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProviderGenero As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProviderFormato As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProviderPrecioalq As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProviderPrecioComp As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProviderCantidad As System.Windows.Forms.ErrorProvider
End Class

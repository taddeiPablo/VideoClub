<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABMalquileres
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
        Me.GrpDatosAlquiler = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.DateTimeInicio = New System.Windows.Forms.DateTimePicker
        Me.BtnCalc = New System.Windows.Forms.Button
        Me.LblCantidad = New System.Windows.Forms.Label
        Me.LblTotalAPagar = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.LblFechaAlq = New System.Windows.Forms.Label
        Me.CmbBoxTipoPago = New System.Windows.Forms.ComboBox
        Me.LblTipoPago = New System.Windows.Forms.Label
        Me.LblPrecioAlquiler = New System.Windows.Forms.Label
        Me.LblTipo = New System.Windows.Forms.Label
        Me.LblGenero = New System.Windows.Forms.Label
        Me.LblTitulo = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PBImagenPelicula = New System.Windows.Forms.PictureBox
        Me.GrbListado = New System.Windows.Forms.GroupBox
        Me.DgvListadodePeliculas = New System.Windows.Forms.DataGridView
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.GrpDatosAlquiler.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PBImagenPelicula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrbListado.SuspendLayout()
        CType(Me.DgvListadodePeliculas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpDatosAlquiler
        '
        Me.GrpDatosAlquiler.Controls.Add(Me.Label6)
        Me.GrpDatosAlquiler.Controls.Add(Me.Label5)
        Me.GrpDatosAlquiler.Controls.Add(Me.Label4)
        Me.GrpDatosAlquiler.Controls.Add(Me.Label3)
        Me.GrpDatosAlquiler.Controls.Add(Me.Label2)
        Me.GrpDatosAlquiler.Controls.Add(Me.Label1)
        Me.GrpDatosAlquiler.Controls.Add(Me.BtnCancelar)
        Me.GrpDatosAlquiler.Controls.Add(Me.BtnAceptar)
        Me.GrpDatosAlquiler.Controls.Add(Me.DateTimeInicio)
        Me.GrpDatosAlquiler.Controls.Add(Me.BtnCalc)
        Me.GrpDatosAlquiler.Controls.Add(Me.LblCantidad)
        Me.GrpDatosAlquiler.Controls.Add(Me.LblTotalAPagar)
        Me.GrpDatosAlquiler.Controls.Add(Me.Label8)
        Me.GrpDatosAlquiler.Controls.Add(Me.LblFechaAlq)
        Me.GrpDatosAlquiler.Controls.Add(Me.CmbBoxTipoPago)
        Me.GrpDatosAlquiler.Controls.Add(Me.LblTipoPago)
        Me.GrpDatosAlquiler.Controls.Add(Me.LblPrecioAlquiler)
        Me.GrpDatosAlquiler.Controls.Add(Me.LblTipo)
        Me.GrpDatosAlquiler.Controls.Add(Me.LblGenero)
        Me.GrpDatosAlquiler.Controls.Add(Me.LblTitulo)
        Me.GrpDatosAlquiler.Controls.Add(Me.Panel1)
        Me.GrpDatosAlquiler.ForeColor = System.Drawing.Color.Navy
        Me.GrpDatosAlquiler.Location = New System.Drawing.Point(407, 12)
        Me.GrpDatosAlquiler.Name = "GrpDatosAlquiler"
        Me.GrpDatosAlquiler.Size = New System.Drawing.Size(448, 455)
        Me.GrpDatosAlquiler.TabIndex = 4
        Me.GrpDatosAlquiler.TabStop = False
        Me.GrpDatosAlquiler.Text = "Datos del Alquiler"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(232, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "---------------------------------------------------------------------------"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Cantidad de Peliculas Alquiladas :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(206, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Precio Alquileres :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(206, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Formato :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(206, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Genero :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Titulo :"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(367, 425)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 20
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(286, 425)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 19
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'DateTimeInicio
        '
        Me.DateTimeInicio.Location = New System.Drawing.Point(127, 288)
        Me.DateTimeInicio.Name = "DateTimeInicio"
        Me.DateTimeInicio.Size = New System.Drawing.Size(213, 20)
        Me.DateTimeInicio.TabIndex = 17
        '
        'BtnCalc
        '
        Me.BtnCalc.Location = New System.Drawing.Point(209, 426)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(71, 23)
        Me.BtnCalc.TabIndex = 16
        Me.BtnCalc.Text = "Calc Total"
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.Location = New System.Drawing.Point(193, 344)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(16, 13)
        Me.LblCantidad.TabIndex = 13
        Me.LblCantidad.Text = "---"
        '
        'LblTotalAPagar
        '
        Me.LblTotalAPagar.AutoSize = True
        Me.LblTotalAPagar.Location = New System.Drawing.Point(124, 424)
        Me.LblTotalAPagar.Name = "LblTotalAPagar"
        Me.LblTotalAPagar.Size = New System.Drawing.Size(39, 13)
        Me.LblTotalAPagar.TabIndex = 12
        Me.LblTotalAPagar.Text = "Label9"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 424)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Total A Pagar :"
        '
        'LblFechaAlq
        '
        Me.LblFechaAlq.AutoSize = True
        Me.LblFechaAlq.Location = New System.Drawing.Point(6, 295)
        Me.LblFechaAlq.Name = "LblFechaAlq"
        Me.LblFechaAlq.Size = New System.Drawing.Size(95, 13)
        Me.LblFechaAlq.TabIndex = 7
        Me.LblFechaAlq.Text = "Fecha de Alquiler :"
        '
        'CmbBoxTipoPago
        '
        Me.CmbBoxTipoPago.FormattingEnabled = True
        Me.CmbBoxTipoPago.Location = New System.Drawing.Point(104, 252)
        Me.CmbBoxTipoPago.Name = "CmbBoxTipoPago"
        Me.CmbBoxTipoPago.Size = New System.Drawing.Size(121, 21)
        Me.CmbBoxTipoPago.TabIndex = 6
        Me.CmbBoxTipoPago.Text = "Seleccionar"
        '
        'LblTipoPago
        '
        Me.LblTipoPago.AutoSize = True
        Me.LblTipoPago.Location = New System.Drawing.Point(3, 255)
        Me.LblTipoPago.Name = "LblTipoPago"
        Me.LblTipoPago.Size = New System.Drawing.Size(77, 13)
        Me.LblTipoPago.TabIndex = 5
        Me.LblTipoPago.Text = "Tipo de Pago :"
        '
        'LblPrecioAlquiler
        '
        Me.LblPrecioAlquiler.AutoSize = True
        Me.LblPrecioAlquiler.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecioAlquiler.Location = New System.Drawing.Point(322, 154)
        Me.LblPrecioAlquiler.Name = "LblPrecioAlquiler"
        Me.LblPrecioAlquiler.Size = New System.Drawing.Size(35, 13)
        Me.LblPrecioAlquiler.TabIndex = 4
        Me.LblPrecioAlquiler.Text = "-------"
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipo.Location = New System.Drawing.Point(268, 119)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(31, 13)
        Me.LblTipo.TabIndex = 3
        Me.LblTipo.Text = "------"
        '
        'LblGenero
        '
        Me.LblGenero.AutoSize = True
        Me.LblGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGenero.Location = New System.Drawing.Point(268, 82)
        Me.LblGenero.Name = "LblGenero"
        Me.LblGenero.Size = New System.Drawing.Size(31, 13)
        Me.LblGenero.TabIndex = 2
        Me.LblGenero.Text = "------"
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(259, 44)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(31, 13)
        Me.LblTitulo.TabIndex = 1
        Me.LblTitulo.Text = "------"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PBImagenPelicula)
        Me.Panel1.Location = New System.Drawing.Point(6, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(177, 183)
        Me.Panel1.TabIndex = 0
        '
        'PBImagenPelicula
        '
        Me.PBImagenPelicula.Location = New System.Drawing.Point(3, 3)
        Me.PBImagenPelicula.Name = "PBImagenPelicula"
        Me.PBImagenPelicula.Size = New System.Drawing.Size(171, 177)
        Me.PBImagenPelicula.TabIndex = 0
        Me.PBImagenPelicula.TabStop = False
        '
        'GrbListado
        '
        Me.GrbListado.Controls.Add(Me.DgvListadodePeliculas)
        Me.GrbListado.ForeColor = System.Drawing.Color.Navy
        Me.GrbListado.Location = New System.Drawing.Point(12, 12)
        Me.GrbListado.Name = "GrbListado"
        Me.GrbListado.Size = New System.Drawing.Size(389, 455)
        Me.GrbListado.TabIndex = 3
        Me.GrbListado.TabStop = False
        Me.GrbListado.Text = "Listado de Peliculas"
        '
        'DgvListadodePeliculas
        '
        Me.DgvListadodePeliculas.AllowUserToAddRows = False
        Me.DgvListadodePeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListadodePeliculas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        Me.DgvListadodePeliculas.Location = New System.Drawing.Point(6, 30)
        Me.DgvListadodePeliculas.Name = "DgvListadodePeliculas"
        Me.DgvListadodePeliculas.Size = New System.Drawing.Size(377, 419)
        Me.DgvListadodePeliculas.TabIndex = 0
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        '
        'FrmABMalquileres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(867, 471)
        Me.ControlBox = False
        Me.Controls.Add(Me.GrpDatosAlquiler)
        Me.Controls.Add(Me.GrbListado)
        Me.Name = "FrmABMalquileres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ALQUILERES"
        Me.GrpDatosAlquiler.ResumeLayout(False)
        Me.GrpDatosAlquiler.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PBImagenPelicula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrbListado.ResumeLayout(False)
        CType(Me.DgvListadodePeliculas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpDatosAlquiler As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents DateTimeInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnCalc As System.Windows.Forms.Button
    Friend WithEvents LblCantidad As System.Windows.Forms.Label
    Friend WithEvents LblTotalAPagar As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LblFechaAlq As System.Windows.Forms.Label
    Friend WithEvents CmbBoxTipoPago As System.Windows.Forms.ComboBox
    Friend WithEvents LblTipoPago As System.Windows.Forms.Label
    Friend WithEvents LblPrecioAlquiler As System.Windows.Forms.Label
    Friend WithEvents LblTipo As System.Windows.Forms.Label
    Friend WithEvents LblGenero As System.Windows.Forms.Label
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PBImagenPelicula As System.Windows.Forms.PictureBox
    Friend WithEvents GrbListado As System.Windows.Forms.GroupBox
    Friend WithEvents DgvListadodePeliculas As System.Windows.Forms.DataGridView
    Friend WithEvents Seleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class

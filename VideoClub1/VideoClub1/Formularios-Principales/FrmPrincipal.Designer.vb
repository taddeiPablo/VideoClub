<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ARCHIVOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CATALOGODEPELICULASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VENTAYALQUILERESDEPELIUCLASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImportarYExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImportarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExportarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ACERCADEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VERTOTALDECOMPRASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ARCHIVOToolStripMenuItem, Me.CLIENTESToolStripMenuItem, Me.CATALOGODEPELICULASToolStripMenuItem, Me.VENTAYALQUILERESDEPELIUCLASToolStripMenuItem, Me.ImportarYExportarToolStripMenuItem, Me.VERTOTALDECOMPRASToolStripMenuItem, Me.ACERCADEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1242, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ARCHIVOToolStripMenuItem
        '
        Me.ARCHIVOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SALIRToolStripMenuItem})
        Me.ARCHIVOToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.ARCHIVOToolStripMenuItem.Name = "ARCHIVOToolStripMenuItem"
        Me.ARCHIVOToolStripMenuItem.Size = New System.Drawing.Size(78, 21)
        Me.ARCHIVOToolStripMenuItem.Text = "ARCHIVO"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'CLIENTESToolStripMenuItem
        '
        Me.CLIENTESToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.CLIENTESToolStripMenuItem.Name = "CLIENTESToolStripMenuItem"
        Me.CLIENTESToolStripMenuItem.Size = New System.Drawing.Size(78, 21)
        Me.CLIENTESToolStripMenuItem.Text = "CLIENTES"
        '
        'CATALOGODEPELICULASToolStripMenuItem
        '
        Me.CATALOGODEPELICULASToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.CATALOGODEPELICULASToolStripMenuItem.Name = "CATALOGODEPELICULASToolStripMenuItem"
        Me.CATALOGODEPELICULASToolStripMenuItem.Size = New System.Drawing.Size(181, 21)
        Me.CATALOGODEPELICULASToolStripMenuItem.Text = "CATALOGO DE PELICULAS"
        '
        'VENTAYALQUILERESDEPELIUCLASToolStripMenuItem
        '
        Me.VENTAYALQUILERESDEPELIUCLASToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.VENTAYALQUILERESDEPELIUCLASToolStripMenuItem.Name = "VENTAYALQUILERESDEPELIUCLASToolStripMenuItem"
        Me.VENTAYALQUILERESDEPELIUCLASToolStripMenuItem.Size = New System.Drawing.Size(245, 21)
        Me.VENTAYALQUILERESDEPELIUCLASToolStripMenuItem.Text = "VENTA Y ALQUILERES DE PELICULAS"
        '
        'ImportarYExportarToolStripMenuItem
        '
        Me.ImportarYExportarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportarClientesToolStripMenuItem, Me.ExportarClientesToolStripMenuItem})
        Me.ImportarYExportarToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.ImportarYExportarToolStripMenuItem.Name = "ImportarYExportarToolStripMenuItem"
        Me.ImportarYExportarToolStripMenuItem.Size = New System.Drawing.Size(170, 21)
        Me.ImportarYExportarToolStripMenuItem.Text = "IMPORTAR Y EXPORTAR"
        '
        'ImportarClientesToolStripMenuItem
        '
        Me.ImportarClientesToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.ImportarClientesToolStripMenuItem.Name = "ImportarClientesToolStripMenuItem"
        Me.ImportarClientesToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ImportarClientesToolStripMenuItem.Text = "IMPORTAR CLIENTES"
        '
        'ExportarClientesToolStripMenuItem
        '
        Me.ExportarClientesToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.ExportarClientesToolStripMenuItem.Name = "ExportarClientesToolStripMenuItem"
        Me.ExportarClientesToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ExportarClientesToolStripMenuItem.Text = "EXPORTAR CLIENTES"
        '
        'ACERCADEToolStripMenuItem
        '
        Me.ACERCADEToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.ACERCADEToolStripMenuItem.Name = "ACERCADEToolStripMenuItem"
        Me.ACERCADEToolStripMenuItem.Size = New System.Drawing.Size(90, 21)
        Me.ACERCADEToolStripMenuItem.Text = "ACERCA DE"
        '
        'VERTOTALDECOMPRASToolStripMenuItem
        '
        Me.VERTOTALDECOMPRASToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.VERTOTALDECOMPRASToolStripMenuItem.Name = "VERTOTALDECOMPRASToolStripMenuItem"
        Me.VERTOTALDECOMPRASToolStripMenuItem.Size = New System.Drawing.Size(177, 21)
        Me.VERTOTALDECOMPRASToolStripMenuItem.Text = "VER TOTAL DE COMPRAS"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1242, 642)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VENTANA PRINCIPAL"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ARCHIVOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CLIENTESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CATALOGODEPELICULASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VENTAYALQUILERESDEPELIUCLASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ACERCADEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportarYExportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportarClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportarClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VERTOTALDECOMPRASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

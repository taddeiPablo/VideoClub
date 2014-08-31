Imports VideoClubNegocios

Public Class FrmDevolucionAlq
    
    Private fechaDevolucion As Date

    Public Property FechaDevolucionALQ() As Date
        Get
            Return Me.fechaDevolucion
        End Get
        Set(ByVal value As Date)
            Me.fechaDevolucion = value
        End Set
    End Property



    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.fechaDevolucion = Date.Parse(Me.DateTimePicker1.Value.Date.ToString)
        Me.DialogResult = Windows.Forms.DialogResult.OK 
    End Sub
End Class
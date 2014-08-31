Module Main
    Sub main()
        Try
            Dim principal As New FrmPrincipal
            Application.Run(principal)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module

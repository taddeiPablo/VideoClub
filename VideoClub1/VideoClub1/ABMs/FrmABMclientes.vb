Imports VideoClubEntidades

Public Class FrmABMclientes

    Private uncliente As cliente
    Private cont As Integer = 0

    Public Property UN_CLIENTE() As Cliente
        Get
            Return Me.uncliente
        End Get
        Set(ByVal value As Cliente)
            Me.uncliente = value
        End Set
    End Property


    Private Sub FrmABMclientes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not uncliente Is Nothing Then
                TxtNombre.Text = Me.uncliente.Nombre_Cliente
                TxtApellido.Text = Me.uncliente.Apellido_Cliente
                TxtDireccion.Text = Me.uncliente.Direccion_Cliente
                TxtDni.Text = Me.uncliente.DNI_Cliente
                TxtTelefono.Text = Me.uncliente.Telefono_Cliente
                TxtEmail.Text = Me.uncliente.Email_Cliente
            Else
                camposvacios()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Try
            Dim nombre As String = TxtNombre.Text
            Dim apellido As String = TxtApellido.Text
            Dim direccion As String = TxtDireccion.Text
            Dim dni As String = TxtDni.Text
            Dim telefono As String = TxtTelefono.Text
            Dim email As String = TxtEmail.Text

            If Me.uncliente Is Nothing Then
                Me.uncliente = New Cliente(nombre, apellido, dni, direccion, telefono, email)
            Else
                Me.uncliente.Nombre_Cliente = nombre
                Me.uncliente.Apellido_Cliente = apellido
                Me.uncliente.Direccion_Cliente = direccion
                Me.uncliente.DNI_Cliente = dni
                Me.uncliente.Telefono_Cliente = telefono
                Me.uncliente.Email_Cliente = email
            End If
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub camposvacios()
        For Each Controlf As Control In Me.Controls
            If TypeOf Controlf Is GroupBox Then
                For Each controD As Control In Controlf.Controls
                    If TypeOf controD Is TextBox Then
                        Select Case controD.Name
                            Case "TxtApellido"
                                If controD.Text = String.Empty Then
                                    Me.BtnAceptar.Enabled = False
                                    ErrorProviderApellido.SetError(Me.TxtApellido, "CAMPO OBLIGATORIO")
                                    Me.cont += 1
                                Else
                                    If validacionCampos(controD.Text) <> True Then
                                        Me.cont += 1
                                        ErrorProviderApellido.SetError(Me.TxtApellido, "ERROR : solo letras en este campo")
                                    Else
                                        ErrorProviderApellido.Clear()
                                    End If
                                End If
                            Case "TxtNombre"
                                If controD.Text = String.Empty Then
                                    Me.cont += 1
                                    ErrorProviderNombre.SetError(Me.TxtNombre, "CAMPO OBLIGATORIO")
                                Else
                                    If validacionCampos(controD.Text) <> True Then
                                        Me.cont += 1
                                        ErrorProviderNombre.SetError(Me.TxtNombre, "ERROR : solo letras en este campo")
                                    Else
                                        ErrorProviderNombre.Clear()
                                    End If
                                End If
                            Case "TxtDni"
                                If controD.Text = String.Empty Then
                                    Me.cont += 1
                                    ErrorProviderDni.SetError(Me.TxtDni, "CAMPO OBLIGTORIO")
                                Else
                                    If validacionCamposNumeros(controD.Text) <> True Then
                                        Me.cont += 1
                                        ErrorProviderDni.SetError(Me.TxtDni, "ERROR : solo numeros en este campo")
                                    Else
                                        ErrorProviderDni.Clear()
                                    End If
                                End If
                            Case "TxtDireccion"
                                If controD.Text = String.Empty Then
                                    Me.cont += 1
                                    ErrorProviderdireccion.SetError(Me.TxtDireccion, "CAMPO OBLIGATORIO")
                                Else
                                    If validacionCampos(controD.Text) <> True Then
                                        Me.cont += 1
                                        ErrorProviderdireccion.SetError(Me.TxtDireccion, "ERROR : solo letras en este campo")
                                    Else
                                        ErrorProviderdireccion.Clear()
                                    End If
                                End If
                            Case "TxtTelefono"
                                If controD.Text = String.Empty Then
                                    Me.cont += 1
                                    ErrorProviderTelefono.SetError(Me.TxtTelefono, "CAMPO OBLIGATORIO")
                                Else
                                    If validacionCamposNumeros(controD.Text) <> True Then
                                        Me.cont += 1
                                        ErrorProviderTelefono.SetError(Me.TxtTelefono, "ERROR : solo numeros en este campo")
                                    Else
                                        ErrorProviderTelefono.Clear()
                                    End If
                                End If
                            Case "TxtEmail"
                                If controD.Text = String.Empty Then
                                    Me.cont += 1
                                    ErrorProviderEmail.SetError(Me.TxtEmail, "CAMPO OBLIGATORIO")
                                Else
                                    If validacionCampos(controD.Text) <> True Then
                                        Me.cont += 1
                                        ErrorProviderEmail.SetError(Me.TxtEmail, "ERROR : solo letras en este campo")
                                    Else
                                        If validacionCampos(controD.Text) <> True Then
                                            Me.cont += 1
                                            ErrorProviderEmail.SetError(Me.TxtEmail, "ERROR : solo letras en este campo")
                                        Else
                                            ErrorProviderEmail.Clear()
                                        End If
                                    End If
                                End If
                        End Select
                    End If
                Next
            End If
        Next
        If Me.cont = 0 Then
            Me.BtnAceptar.Enabled = True
        End If
        Me.cont = 0
    End Sub

    Private Sub validarTextVacios(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombre.Validated, TxtApellido.Validated, TxtDireccion.Validated, TxtDni.Validated, TxtTelefono.Validated, TxtEmail.Validated
        camposvacios()
    End Sub

    Private Function validacionCampos(ByVal palabra As String) As Boolean
        Dim valor As Integer = AscW(palabra)
        If Char.IsNumber(CType(ChrW(valor), Char)) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function validacionCamposNumeros(ByVal palabra As String) As Boolean
        Dim valor As Integer = AscW(palabra)
        If Char.IsLetter(CType(ChrW(valor), Char)) Then
            Return False
        Else
            Return True
        End If
    End Function

End Class
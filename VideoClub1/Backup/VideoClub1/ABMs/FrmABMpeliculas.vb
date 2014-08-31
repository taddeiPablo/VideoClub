Imports VideoClubEntidades

Public Class FrmABMpeliculas

    Private unaPelicula As Pelicula
    Private imagenArray() As Byte
    Private cont As Integer = 0

    Public Property UNA_PELICULA() As Pelicula
        Get
            Return Me.unaPelicula
        End Get
        Set(ByVal value As Pelicula)
            Me.unaPelicula = value
        End Set
    End Property



    Private Sub FrmABMpeliculas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not Me.unaPelicula Is Nothing Then
                TxtTitulo.Text = unaPelicula.Titulo_Pelicula
                TxtGenero.Text = unaPelicula.Genero_Pelicula
                TxtFormato.Text = unaPelicula.Formato_Pelicula
                TxtPrecioAlquiler.Text = unaPelicula.PrecioAlquiler_Pelicula
                TxtPrecioCompra.Text = unaPelicula.PrecioCompra_Pelicula
                PictureBoxPelicula.Image = getImages(unaPelicula.IMAGEN_BYTES)
                TxtCantidad.Text = unaPelicula.Cantidad_Pelicula
            Else
                camposvacios_validacion()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Try
            Dim titulo As String = TxtTitulo.Text
            Dim genero As String = TxtGenero.Text
            Dim formato As String = TxtFormato.Text
            Dim precioAlquiler As Single = Single.Parse(TxtPrecioAlquiler.Text)
            Dim precioCompra As Single = Single.Parse(TxtPrecioCompra.Text)
            Dim cantidad As Integer = Integer.Parse(TxtCantidad.Text)

            If Me.unaPelicula Is Nothing Then
                Me.unaPelicula = New Pelicula(titulo, genero, formato, precioAlquiler, precioCompra, Me.imagenArray, cantidad)
            Else
                Me.unaPelicula.Titulo_Pelicula = titulo
                Me.unaPelicula.Genero_Pelicula = genero
                Me.unaPelicula.Formato_Pelicula = formato
                Me.unaPelicula.PrecioAlquiler_Pelicula = precioAlquiler
                Me.unaPelicula.PrecioCompra_Pelicula = precioCompra
                Me.unaPelicula.IMAGEN_BYTES = Me.imagenArray
                Me.unaPelicula.Cantidad_Pelicula = cantidad
            End If
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub BtnCargarImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCargarImagen.Click
        Try
            If OpenFileDialog1.ShowDialog() Then
                Dim path As String = OpenFileDialog1.FileName.ToString
                PictureBoxPelicula.Image = Image.FromFile(path)
                Me.imagenArray = getBytesImage(PictureBoxPelicula.Image)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function getBytesImage(ByVal image As Image) As Byte()
        Try
            Dim ms As New IO.MemoryStream()
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arreglo As Byte() = ms.ToArray()
            ms.Close()
            ms.Dispose()
            Return arreglo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getImages(ByVal bytes As Byte()) As Image
        Try
            Dim ms As New IO.MemoryStream(bytes)
            Dim retornaImagen As Image = Image.FromStream(ms)
            Return retornaImagen
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub validacion(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTitulo.Validated, TxtCantidad.Validated, TxtFormato.Validated, TxtGenero.Validated, TxtPrecioAlquiler.Validated, TxtPrecioCompra.Validated
        camposvacios_validacion()
    End Sub

    Private Sub camposvacios_validacion()
        For Each Controlf As Control In Me.Controls
            If TypeOf Controlf Is GroupBox Then
                For Each controD As Control In Controlf.Controls
                    If TypeOf controD Is TextBox Then
                        Select Case controD.Name
                            Case "TxtTitulo"
                                If controD.Text = String.Empty Then
                                    Me.BtnAceptar.Enabled = False
                                    ErrorProviderTitulo.SetError(Me.TxtTitulo, "CAMPO OBLIGATORIO")
                                    Me.cont += 1
                                Else
                                    If validacionCampos(controD.Text) <> True Then
                                        Me.cont += 1
                                        ErrorProviderTitulo.SetError(Me.TxtTitulo, "ERROR : solo letras en este campo")
                                    Else
                                        ErrorProviderTitulo.Clear()
                                    End If
                                End If
                            Case "TxtGenero"
                                If controD.Text = String.Empty Then
                                    Me.cont += 1
                                    ErrorProviderGenero.SetError(Me.TxtGenero, "CAMPO OBLIGATORIO")
                                Else
                                    If validacionCampos(controD.Text) <> True Then
                                        Me.cont += 1
                                        ErrorProviderGenero.SetError(Me.TxtGenero, "ERROR : solo letras en este campo")
                                    Else
                                        ErrorProviderGenero.Clear()
                                    End If
                                End If
                            Case "TxtFormato"
                                If controD.Text = String.Empty Then
                                    Me.cont += 1
                                    ErrorProviderFormato.SetError(Me.TxtFormato, "CAMPO OBLIGTORIO")
                                Else
                                    If validacionCampos(controD.Text) <> True Then
                                        Me.cont += 1
                                        ErrorProviderFormato.SetError(Me.TxtFormato, "ERROR : solo numeros en este campo")
                                    Else
                                        ErrorProviderFormato.Clear()
                                    End If
                                End If
                            Case "TxtPrecioAlquiler"
                                If controD.Text = String.Empty Then
                                    Me.cont += 1
                                    ErrorProviderPrecioalq.SetError(Me.TxtPrecioAlquiler, "CAMPO OBLIGATORIO")
                                Else
                                    If validacionCamposNumeros(controD.Text) <> True Then
                                        Me.cont += 1
                                        ErrorProviderPrecioalq.SetError(Me.TxtPrecioAlquiler, "ERROR : solo numeros en este campo")
                                    Else
                                        ErrorProviderPrecioalq.Clear()
                                    End If
                                End If
                            Case "TxtPrecioCompra"
                                If controD.Text = String.Empty Then
                                    Me.cont += 1
                                    ErrorProviderPrecioComp.SetError(Me.TxtPrecioCompra, "CAMPO OBLIGATORIO")
                                Else
                                    If validacionCamposNumeros(controD.Text) <> True Then
                                        Me.cont += 1
                                        ErrorProviderPrecioComp.SetError(Me.TxtPrecioCompra, "ERROR : solo numeros en este campo")
                                    Else
                                        ErrorProviderPrecioComp.Clear()
                                    End If
                                End If
                            Case "TxtCantidad"
                                If controD.Text = String.Empty Then
                                    Me.cont += 1
                                    ErrorProviderCantidad.SetError(Me.TxtCantidad, "CAMPO OBLIGATORIO")
                                Else
                                    If validacionCamposNumeros(controD.Text) <> True Then
                                        Me.cont += 1
                                        ErrorProviderCantidad.SetError(Me.TxtCantidad, "ERROR : solo letras en este campo")
                                    Else
                                        ErrorProviderCantidad.Clear()
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
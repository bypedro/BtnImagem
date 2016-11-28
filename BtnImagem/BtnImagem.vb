Imports System.Drawing.Text
Imports System.Drawing

Public Class BtnImagem
    Public Property zTexto As String = "TEXTO"
    Public Property zTamanhoLetra As Integer = 11
    Public Property zCorFundo As Color = Color.DarkGray
    Public Property zCorSecundaria As Color = Color.Gray
    Public Property zImagem As System.Drawing.Bitmap
    Public Property zComprimentoImagem As Integer = 50
    Public Property zAlturaImagem As Integer = 50


    Private Sub BtnImagem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblTexto.Font = CustomFont.GetInstance(zTamanhoLetra, FontStyle.Bold) 'Fonte Personalizada não tem um style.
        LblTexto.Text = zTexto
        Me.BackColor = zCorFundo
        PictureBox1.BackgroundImage = zImagem
        PictureBox1.Width = zComprimentoImagem
        PictureBox1.Height = zAlturaImagem

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        BtnImagem_Click(sender, e)
    End Sub

    Private Sub LblTexto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTexto.Click
        BtnImagem_Click(sender, e)
    End Sub




    Private Sub BtnImagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click

    End Sub

    ''Style
    Private Sub BtnImagem_Hover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseHover
        Me.BackColor = zCorSecundaria
    End Sub

    Private Sub BtnImagem_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseLeave
        Me.BackColor = zCorFundo
    End Sub


    Private Sub PictureBox1_hover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        Me.BackColor = zCorSecundaria
    End Sub

    Private Sub LblTexto_Hover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTexto.MouseHover
        Me.BackColor = zCorSecundaria
    End Sub

End Class



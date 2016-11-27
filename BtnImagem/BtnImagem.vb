Imports System.Drawing.Text
Imports System.Drawing
Imports System.IO
Imports System.Reflection

Public Class BtnImagem
    Public Property Texto As String = "TEXTO"
    Public Property CorFundo As Color = Color.White
    Public Property Imagem As System.Drawing.Bitmap
    Public Property TamanhoLetra As Integer = 11

    Private Sub BtnImagem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblTexto.Font = CustomFont.GetInstance(TamanhoLetra, FontStyle.Bold) 'Fonte Personalizada não tem um style.
        Me.BackColor = CorFundo
        PictureBox1.BackgroundImage = Imagem
        LblTexto.Text = Texto
    End Sub

    Private Sub BtnImagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        MsgBox("LOL")
    End Sub

    Private Sub BtnImagem_Hover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseHover

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        BtnImagem_Click(sender, e)
    End Sub

    Private Sub LblTexto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTexto.Click
        BtnImagem_Click(sender, e)
    End Sub

End Class



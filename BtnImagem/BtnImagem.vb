Imports System.Drawing.Text
Imports System.Drawing

Public Class BtnImagem
    Public Property Texto As String = "TEXTO"
    Public Property CorFundo As Color = Color.White
    Public Property Imagem As System.Drawing.Bitmap

    Private Sub BtnImagem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim customfont As New PrivateFontCollection
        customfont.AddFontFile("C:\maven.ttf") '' Usar Talvez Uma Propriedade
        LblTexto.Font = New Drawing.Font(customfont.Families(0), 10)
        LblTexto.Text = Texto
        Me.BackColor = CorFundo
        PictureBox1.BackgroundImage = Imagem
    End Sub

    Private Sub BtnImagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click

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



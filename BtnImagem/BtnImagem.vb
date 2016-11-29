Imports System.Drawing.Text
Imports System.Drawing

Public Class BtnImagem

    Public Property zCorSecundaria As Color = Color.Gray

    Public Property zTamanhoLetra As Integer
        Get
            zTamanhoLetra = LblTexto.Font.Size
        End Get
        Set(ByVal value As Integer)
            LblTexto.Font = CustomFont.GetInstance(value, FontStyle.Bold)
        End Set
    End Property

    Public Property zTexto As String
        Get
            zTexto = LblTexto.Text
        End Get
        Set(ByVal value As String)
            LblTexto.Text = value
        End Set
    End Property

    Public Property zCorFundo As Color
        Get
            zCorFundo = Me.BackColor
        End Get
        Set(ByVal value As Color)
            Me.BackColor = value
        End Set
    End Property

    Public Property zImagem As System.Drawing.Bitmap
        Get
            zImagem = PictureBox1.Image
        End Get
        Set(ByVal value As System.Drawing.Bitmap)
            PictureBox1.Image = value
        End Set
    End Property

    Public Property zComprimentoImagem As Integer
        Get
            zComprimentoImagem = PictureBox1.Width
        End Get
        Set(ByVal value As Integer)
            PictureBox1.Width = value
        End Set
    End Property

    Public Property zAlturaImagem As Integer
        Get
            zAlturaImagem = PictureBox1.Height
        End Get
        Set(ByVal value As Integer)
            PictureBox1.Height = value
        End Set
    End Property

    Private Sub BtnImagem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblTexto.Font = CustomFont.GetInstance(zTamanhoLetra, FontStyle.Bold)
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

    Private Sub PictureBox1_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        Me.BackColor = zCorFundo
    End Sub

    Private Sub LblTexto_Hover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTexto.MouseHover
        Me.BackColor = zCorSecundaria
    End Sub

    Private Sub LblTexto_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTexto.MouseLeave
        Me.BackColor = zCorFundo
    End Sub

End Class
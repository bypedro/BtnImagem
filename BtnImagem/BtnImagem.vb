Imports System.Drawing.Text
Imports System.Drawing
'Define evento prim�rio->
<System.ComponentModel.DefaultEventAttribute("Click")> _
Public Class BtnImagem
    Public Property zCorSelecionado As Color = Color.SteelBlue
    Public Property zCorFundo As Color = Color.SlateGray
    '    Get
    '        zCorFundo = Me.BackColor
    '    End Get
    '    Set(ByVal value As Color)
    '        Me.BackColor = value
    '    End Set
    'End Property
    'Ver outra solu��o
    Public Property zCorHover As Color = Color.LightSlateGray
    Dim corfundo As Color = zCorFundo
    Dim corselecionado As Color = zCorSelecionado

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

    Public Property zImagem As System.Drawing.Bitmap
        Get
            zImagem = Imagem.Image
        End Get
        Set(ByVal value As System.Drawing.Bitmap)
            Imagem.Image = value
        End Set
    End Property

    Public Property zComprimentoImagem As Integer
        Get
            zComprimentoImagem = Imagem.Width
        End Get
        Set(ByVal value As Integer)
            Imagem.Width = value
        End Set
    End Property

    Public Property zAlturaImagem As Integer
        Get
            zAlturaImagem = Imagem.Height
        End Get
        Set(ByVal value As Integer)
            Imagem.Height = value
        End Set
    End Property

    Public Property zEstadoBotao As Boolean = False

    Private Sub BtnImagem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblTexto.Font = CustomFont.GetInstance(zTamanhoLetra, FontStyle.Bold)
        If zEstadoBotao = False Then
            Me.BackColor = zCorFundo
        Else
            Me.BackColor = corselecionado
        End If
    End Sub



    Private Sub EventoClick()
        corfundo = zCorFundo
        corselecionado = zCorSelecionado
        If zEstadoBotao = False Then
            Me.BackColor = corselecionado
            zEstadoBotao = True
            'ElseIf zEstadoBotao = True Then
            '    Me.BackColor = corfundo
            '    zEstadoBotao = False
            'N�o sei se necessito disto
        End If
    End Sub


    Private Sub btnImagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click, LblTexto.Click, Imagem.Click
        EventoClick()
    End Sub

    Private Sub Btnhover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseHover, LblTexto.MouseHover, Imagem.MouseHover
        If zEstadoBotao = False Then
            Me.BackColor = zCorHover
        End If
    End Sub
    Private Sub Btnleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseLeave, Imagem.MouseLeave, LblTexto.MouseLeave
        If zEstadoBotao = False Then
            Me.BackColor = corfundo
        End If
    End Sub

    Public Sub VerificarEstadoBotao()
        If zEstadoBotao = False Then
            Me.BackColor = corfundo
        End If
        If zEstadoBotao = True Then
            Me.BackColor = corselecionado
        End If
    End Sub
End Class
Imports System.Net
Public Class UltimosAnimes
    Dim Link1 As String
    Dim Link2 As String
    Dim Link3 As String
    Dim Link4 As String
    Dim TL As Integer
    Sub CodigoMenor()
        Episodios.Redirecionamento = True
        Episodios.Show()
        Episodios.WindowState = FormWindowState.Normal
        Episodios.Episodios()
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Lista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TL = Label1.Size.Height - 5
        AnimeAleatorio()
        UltimosAnimes()

    End Sub
    Public Const PastebinAnimes As String = "https://pastebin.com/raw/HNbSsEgS"
    Private wc As New WebClient
    Private R As New Random
    Sub UltimosAnimes()
        Try
            Dim Anime As String() = wc.DownloadString(PastebinAnimes).Split(Environment.NewLine)
            Anime1(Anime(Anime.Length - 1))
            Anime2(Anime(Anime.Length - 2))
            Anime3(Anime(Anime.Length - 3))
            'Alinhar Texto e Imagem
            Label2.Location = New Point(PictureBox2.Location.X + (PictureBox2.Size.Width / 2) - (Label2.Size.Width / 2), PictureBox2.Location.Y + PictureBox2.Size.Height - TL)
            Label3.Location = New Point(PictureBox3.Location.X + (PictureBox3.Size.Width / 2) - (Label3.Size.Width / 2), PictureBox3.Location.Y + PictureBox3.Size.Height - TL)
            Label4.Location = New Point(PictureBox4.Location.X + (PictureBox4.Size.Width / 2) - (Label4.Size.Width / 2), PictureBox4.Location.Y + PictureBox4.Size.Height - TL)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Anime1(ByVal Anime As String)
        Label2.Text = Anime.Split("|")(0)
        PictureBox2.ImageLocation = Anime.Split("|")(1)
        Link2 = Anime.Split("|")(2)
    End Sub
    Private Sub Anime2(ByVal Anime As String)
        Label3.Text = Anime.Split("|")(0)
        PictureBox3.ImageLocation = Anime.Split("|")(1)
        Link3 = Anime.Split("|")(2)
    End Sub
    Private Sub Anime3(ByVal Anime As String)
        Label4.Text = Anime.Split("|")(0)
        PictureBox4.ImageLocation = Anime.Split("|")(1)
        Link4 = Anime.Split("|")(2)
    End Sub
    Sub AnimeAleatorio()
        Try
            Dim Anime As String() = wc.DownloadString(PastebinAnimes).Split(Environment.NewLine)
            Separador1(Anime(R.Next(1, Anime.Length)))
            'Alinhar Texto e Imagem
            Label1.Location = New Point(PictureBox1.Location.X + (PictureBox1.Size.Width / 2) - (Label1.Size.Width / 2), PictureBox1.Location.Y + PictureBox1.Size.Height - TL)
        Catch ex As Exception
            MsgBox("Internet Error" & vbNewLine & vbNewLine & "Este Programa necessita de Internet para funcionar :/" & vbNewLine & vbNewLine & "Para Tentar Novamente Re-abra o Programa.")

        End Try
    End Sub

    Private Sub Separador1(ByVal Anime As String)
        Label1.Text = Anime.Split("|")(0)
        PictureBox1.ImageLocation = Anime.Split("|")(1)
        Link1 = Anime.Split("|")(2)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        AnimeAleatorio()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Episodios.PastebinEpisodios = Link1
        CodigoMenor()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Episodios.PastebinEpisodios = Link2
        CodigoMenor()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Episodios.PastebinEpisodios = Link3
        CodigoMenor()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Episodios.PastebinEpisodios = Link4
        CodigoMenor()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Episodios.PastebinEpisodios = Link1
        CodigoMenor()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Episodios.PastebinEpisodios = Link2
        CodigoMenor()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Episodios.PastebinEpisodios = Link3
        CodigoMenor()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Episodios.PastebinEpisodios = Link4
        CodigoMenor()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TodosOsAnimes.Show()
        TodosOsAnimes.WindowState = FormWindowState.Normal
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Sobre.Show()
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TextoDeslizante.Location.X > -TextoDeslizante.Width Then
            TextoDeslizante.Location = New Point(TextoDeslizante.Location.X - 2, TextoDeslizante.Location.Y)
        ElseIf TextoDeslizante.Location.X < -TextoDeslizante.Width Then
            TextoDeslizante.Location = New Point(Panel1.Width, TextoDeslizante.Location.Y)
        End If
    End Sub
End Class
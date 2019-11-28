Imports System.Net
Public Class TodosOsAnimes
    Private wc As New WebClient
    Private R As New Random
    Dim local
    Dim Contagem = 0
    Dim Linha = 0
    Public LarguraJanelaTodosAnimes = 845
    Private Sub TodosOsAnimes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Anime As String() = wc.DownloadString(UltimosAnimes.PastebinAnimes).Split(Environment.NewLine)
            For Each i As String In Anime


                If local > 3 Then
                    local = 0
                    Linha = Linha + 1
                End If
                Dim FotoAnime = New PictureBox
                Dim NomeAnime = New Label
                FotoAnime.Size = New Size(178, 266)
                FotoAnime.Cursor = Cursors.Hand
                FotoAnime.InitialImage = My.Resources.loading_neko
                FotoAnime.ErrorImage = My.Resources.Icone_erro3
                NomeAnime.Cursor = Cursors.Hand
                NomeAnime.MinimumSize = New Size(178, 28)
                NomeAnime.TextAlign = ContentAlignment.TopCenter
                NomeAnime.AutoEllipsis = True
                FotoAnime.ImageLocation = i.Split("|")(1)
                FotoAnime.SizeMode = PictureBoxSizeMode.StretchImage
                If Contagem = 0 Then
                    NomeAnime.Text = i.Split("|")(0)
                Else
                    NomeAnime.Text = i.Substring(1, i.Length - 1).Split("|")(0)
                End If
                FotoAnime.Location = New Point(20 + local * (FotoAnime.Width + 20), 20 + 33 + Linha * (FotoAnime.Height + NomeAnime.Height + 20))
                NomeAnime.Location = New Point((FotoAnime.Size.Width / 2 - NomeAnime.Size.Width / 2) + FotoAnime.Location.X, FotoAnime.Location.Y + FotoAnime.Height)
                Me.Controls.Add(FotoAnime)
                Me.Controls.Add(NomeAnime)
                Dim TextoDica As New ToolTip()
                TextoDica.AutoPopDelay = 5000
                TextoDica.InitialDelay = 1000
                TextoDica.ReshowDelay = 500
                TextoDica.SetToolTip(FotoAnime, NomeAnime.Text)
                TextoDica.SetToolTip(NomeAnime, NomeAnime.Text)
                TextoDica.BackColor = Color.Black
                TextoDica.ForeColor = Color.White
                AddHandler FotoAnime.Click, Sub()
                                                Episodios.Redirecionamento = False
                                                Episodios.PastebinEpisodios = i.Split("|")(2)
                                                Episodios.Show()
                                                Episodios.Episodios()
                                                Me.WindowState = FormWindowState.Minimized
                                            End Sub
                AddHandler NomeAnime.Click, Sub()
                                                Episodios.Redirecionamento = False
                                                Episodios.PastebinEpisodios = i.Split("|")(2)
                                                Episodios.Show()
                                                Episodios.Episodios()
                                                Me.WindowState = FormWindowState.Minimized
                                            End Sub
                Contagem = Contagem + 1
                local = local + 1
                If Contagem = Anime.Count Then
                    Dim espacador = New PictureBox
                    espacador.Size = New Size(20, 20)
                    espacador.Location = New Point(0, NomeAnime.Location.Y + NomeAnime.Height)
                    Me.Controls.Add(espacador)
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TodosOsAnimes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        UltimosAnimes.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UltimosAnimes.WindowState = FormWindowState.Normal
        Me.Close()
    End Sub
End Class
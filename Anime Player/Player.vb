Imports System.ComponentModel
Imports AxWMPLib
Public Class Player
    Dim Volume As Integer
    Dim Tamanho As Integer
    Dim MostrarVolume As Boolean
    Public LinkEpisodio As String
    Public NumeroEpisodio As Decimal
    Public NomeEpisodio As Decimal
    Dim Selecao As Boolean = False
    Dim SelecaoVolume As Boolean = False
    Dim LinhaAssistido As Pen
    Dim LinhaFalta As Pen
    Dim LinhaSom As Pen
    Dim CursorVideo As Brush
    Dim ANCHOCURSOR As Integer = 5
    Dim ALTOCURSOR As Integer = 20
    Dim VALOR As Integer
    Dim Total As Integer
    Sub AjustesIniciais()
        BtnAvancarEpisodio.Location = New Point(PictureBoxTelaCheia.Location.X - BtnAvancarEpisodio.Size.Width - 30, BtnAvancarEpisodio.Location.Y)
        LblEpisodio.Location = New Point(BtnAvancarEpisodio.Location.X - LblEpisodio.Size.Width - 20, LblEpisodio.Location.Y)
        BtnVoltarEpisodio.Location = New Point(LblEpisodio.Location.X - BtnVoltarEpisodio.Size.Width - 20, BtnVoltarEpisodio.Location.Y)
        If NumeroEpisodio > 0 Then
            BtnVoltarEpisodio.Visible = True
        Else
            BtnVoltarEpisodio.Visible = False
        End If
        If NumeroEpisodio < Episodios.ListBox1.Items.Count - 1 Then
            BtnAvancarEpisodio.Visible = True
        Else
            BtnAvancarEpisodio.Visible = False
        End If
    End Sub
    Sub Carregar()
        AxWindowsMediaPlayer1.URL = LinkEpisodio
        LblEpisodio.Text = (Episodios.ListBox1.Items(Episodios.ListBoxf.FindString(LinkEpisodio)))
        AjustesIniciais()
    End Sub

    Private Sub Player_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Episodios.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Player_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar()
        AxWindowsMediaPlayer1.stretchToFit = True
        AxWindowsMediaPlayer1.uiMode = "NONE"
        AxWindowsMediaPlayer1.settings.volume = VALOR
        LinhaAssistido = New Pen(Color.Red, 5)
        LinhaSom = New Pen(Color.White, 5)
        LinhaFalta = New Pen(Color.DarkGray, 5)
        Tamanho = PictureBoxBarraVolume.Width / 2
        AxWindowsMediaPlayer1.settings.volume = 50
        PictureBoxIconVolume.Image = My.Resources.Volume_Medio
        CursorVideo = Brushes.White
        Desenhar()
        DesenharVolume()
        PictureBoxTelaCheia.Image = My.Resources.FullScreen
    End Sub

    Private Sub BtnVoltarEpisodio_Click(sender As Object, e As EventArgs) Handles BtnVoltarEpisodio.Click
        If NumeroEpisodio > 0 Then
            LinkEpisodio = Episodios.ListBoxf.Items(NumeroEpisodio - 1)
            NumeroEpisodio = NumeroEpisodio - 1
            Carregar()
        End If
    End Sub

    Private Sub BtnAvancarEpisodio_Click(sender As Object, e As EventArgs) Handles BtnAvancarEpisodio.Click
        If NumeroEpisodio < Episodios.ListBox1.Items.Count - 1 Then
            LinkEpisodio = Episodios.ListBoxf.Items(NumeroEpisodio + 1)
            NumeroEpisodio = NumeroEpisodio + 1
            Carregar()
        End If
    End Sub

    Private Sub PlayerDeVideo_MediaError(sender As Object, e As _WMPOCXEvents_MediaErrorEvent) Handles AxWindowsMediaPlayer1.MediaError
        MsgBox("Erro No Video Contate O Desenvolvedor")
    End Sub

    Private Sub PlayerDeVideo_PlayStateChange(sender As Object, e As _WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer1.PlayStateChange
        Try
            TimerVideo.Start()
            If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
                PictureBoxPlayPause.Image = Anime_Player_WMP.My.Resources.Resources.pause
            Else
                PictureBoxPlayPause.Image = Anime_Player_WMP.My.Resources.Resources.Icon_Play
            End If

        Catch ex As Exception
        End Try
    End Sub
    Private Sub PictureBox2_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseDown
        Selecao = True
        TimerVideo.Enabled = False
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        Total = e.X
        If Selecao = True Then
            PictureBox2.Refresh()
            If Total < ANCHOCURSOR Then
                Total = ANCHOCURSOR
            End If
            If Total > PictureBox2.Width - ANCHOCURSOR Then
                Total = PictureBox2.Width
            End If
            Desenhar()
        End If
    End Sub

    Public Sub Desenhar()
        PictureBox2.Refresh()
        Dim BM As Bitmap = New Bitmap(PictureBox2.Width, PictureBox2.Height)
        Dim Desenho As Graphics = Graphics.FromImage(BM)
        Desenho.DrawLine(LinhaAssistido, 0, CInt(PictureBox2.Height / 2), Total, CInt(PictureBox2.Height / 2))
        Desenho.DrawLine(LinhaFalta, Total, CInt(PictureBox2.Height / 2), PictureBox2.Width, CInt(PictureBox2.Height / 2))
        Desenho.FillRectangle(CursorVideo, Total - ANCHOCURSOR + 5, CInt(PictureBox2.Height / 2) - ANCHOCURSOR, 5, 10)
        PictureBox2.Image = BM

    End Sub
    Public Sub DesenharVolume()
        PictureBoxBarraVolume.Refresh()
        Dim BM As Bitmap = New Bitmap(PictureBoxBarraVolume.Width, PictureBoxBarraVolume.Height)
        Dim Desenho As Graphics = Graphics.FromImage(BM)
        Desenho.DrawLine(LinhaSom, 0, CInt(PictureBoxBarraVolume.Height / 2), Tamanho, CInt(PictureBoxBarraVolume.Height / 2))
        Desenho.DrawLine(LinhaFalta, Tamanho, CInt(PictureBoxBarraVolume.Height / 2), PictureBoxBarraVolume.Width, CInt(PictureBoxBarraVolume.Height / 2))
        Desenho.FillEllipse(CursorVideo, Tamanho, CInt(PictureBoxBarraVolume.Height / 2) - 5, 10, 10)
        PictureBoxBarraVolume.Image = BM

    End Sub

    Private Sub PictureBox2_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseUp
        VALOR = AxWindowsMediaPlayer1.currentMedia.duration / PictureBox2.Width * Total
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = VALOR
        Selecao = False
        TimerVideo.Enabled = True
    End Sub

    Private Sub TimerVideo_Tick(sender As Object, e As EventArgs) Handles TimerVideo.Tick
        Try
            VALOR = PictureBox2.Width / AxWindowsMediaPlayer1.currentMedia.duration * AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
            Total = VALOR
            Desenhar()
            LblTempoRestante.Text = Format(TimeSerial(0, 0, AxWindowsMediaPlayer1.Ctlcontrols.currentPosition), "mm:ss") & "/" & Format(TimeSerial(0, 0, AxWindowsMediaPlayer1.currentMedia.duration), "mm:ss")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PictureBoxTelaCheia_Click(sender As Object, e As EventArgs) Handles PictureBoxTelaCheia.Click
        Try
            AxWindowsMediaPlayer1.uiMode = "Full"
            AxWindowsMediaPlayer1.fullScreen = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TimerChecarFullScreen_Tick(sender As Object, e As EventArgs) Handles TimerChecarFullScreen.Tick
        If AxWindowsMediaPlayer1.fullScreen = False Then
            AxWindowsMediaPlayer1.uiMode = "none"
        ElseIf AxWindowsMediaPlayer1.fullScreen = True Then
            AxWindowsMediaPlayer1.uiMode = "Full"
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBoxPlayPause.Click
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
        Else
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If
    End Sub

    Private Sub Player_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Episodios.WindowState = FormWindowState.Normal
    End Sub

    Private Sub PictureBoxIconVolume_MouseEnter(sender As Object, e As EventArgs) Handles PictureBoxIconVolume.MouseEnter
        MostrarVolume = True
    End Sub

    Private Sub PictureBoxIconVolume_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxIconVolume.MouseLeave
        MostrarVolume = False
    End Sub

    Private Sub PictureBoxBarraVolume_MouseEnter(sender As Object, e As EventArgs) Handles PictureBoxBarraVolume.MouseEnter
        MostrarVolume = True
    End Sub

    Private Sub PictureBoxBarraVolume_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxBarraVolume.MouseLeave
        MostrarVolume = False
    End Sub

    Private Sub TimerMostrarVolume_Tick(sender As Object, e As EventArgs) Handles TimerMostrarVolume.Tick
        If MostrarVolume = False Then
            PictureBoxBarraVolume.Location = New Point(-100, -28)
            LblTempoRestante.Location = New Point(PictureBoxIconVolume.Location.X + PictureBoxIconVolume.Width + 5, PictureBoxIconVolume.Location.Y + 3)
        ElseIf MostrarVolume = True Then
            PictureBoxBarraVolume.Location = New Point(PictureBoxIconVolume.Location.X + PictureBoxIconVolume.Width, PictureBoxIconVolume.Location.Y)
            LblTempoRestante.Location = New Point(PictureBoxBarraVolume.Location.X + PictureBoxBarraVolume.Width + 15, PictureBoxIconVolume.Location.Y + 3)
        End If
    End Sub
    Dim Mudo As Boolean
    Private Sub PictureBoxIconVolume_Click(sender As Object, e As EventArgs) Handles PictureBoxIconVolume.Click

        If Mudo = False Then
            PictureBoxIconVolume.Image = My.Resources.Volume_Mudo
            Mudo = True
            Tamanho = 0
            Volume = 0
            AxWindowsMediaPlayer1.settings.volume = Volume
            DesenharVolume()
        ElseIf Mudo = True Then
            PictureBoxIconVolume.Image = My.Resources.Volume_Medio
            Mudo = False
            Tamanho = PictureBoxBarraVolume.Width / 2
            Volume = 50
            AxWindowsMediaPlayer1.settings.volume = Volume
            DesenharVolume()
        End If
    End Sub

    Private Sub PictureBoxBarraVolume_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBoxBarraVolume.MouseMove
        Tamanho = e.X
        If SelecaoVolume = True Then
            If Tamanho < 0 Or Tamanho = 0 Then
                Tamanho = 0
                PictureBoxIconVolume.Image = My.Resources.Volume_Mudo
                Mudo = True
            ElseIf Tamanho < PictureBoxBarraVolume.Width / 2 / 2 And Tamanho > 0 Then
                PictureBoxIconVolume.Image = My.Resources.Volume
                Mudo = False
            ElseIf Tamanho < PictureBoxBarraVolume.Width / 2 And Tamanho > PictureBoxBarraVolume.Width / 2 / 2 Then
                PictureBoxIconVolume.Image = My.Resources.Volume_Baixo
                Mudo = False
            ElseIf Tamanho < PictureBoxBarraVolume.Width / 2 + PictureBoxBarraVolume.Width / 2 / 2 And Tamanho > PictureBoxBarraVolume.Width / 2 Then
                PictureBoxIconVolume.Image = My.Resources.Volume_Medio
                Mudo = False
            ElseIf Tamanho < PictureBoxBarraVolume.Width And Tamanho > PictureBoxBarraVolume.Width / 2 + PictureBoxBarraVolume.Width / 2 / 2 Then
                PictureBoxIconVolume.Image = My.Resources.Volume_Alto
                Mudo = False
            End If
            If Tamanho > PictureBoxBarraVolume.Width - 10 Then
                Tamanho = PictureBoxBarraVolume.Width - 10
            End If
            Volume = Tamanho * 100 / PictureBoxBarraVolume.Width
            AxWindowsMediaPlayer1.settings.volume = Volume
            DesenharVolume()
        End If
    End Sub

    Private Sub PictureBoxBarraVolume_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBoxBarraVolume.MouseUp
        Volume = Tamanho * 100 / PictureBoxBarraVolume.Width
        AxWindowsMediaPlayer1.settings.volume = Volume
        SelecaoVolume = False
        DesenharVolume()
    End Sub

    Private Sub PictureBoxBarraVolume_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBoxBarraVolume.MouseDown
        SelecaoVolume = True
    End Sub
End Class

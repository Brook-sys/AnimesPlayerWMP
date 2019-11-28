Imports System.Net
Public Class Episodios
    Public Redirecionamento As Boolean
    Public PastebinEpisodios As String
    Public ListBoxf As New ListBox
    Dim wc As New WebClient
    Dim R As New Random

    Public Sub Episodios()
        ListBox1.Items.Clear()
        Try
            Dim Episodio As String() = wc.DownloadString(PastebinEpisodios).Split(Environment.NewLine)
            For Each i As String In Episodio
                ListBoxf.Items.Add(i.Split("|")(0))
                ListBox1.Items.Add(i.Split("|")(1).Replace(" 0", " "))
            Next
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Episodios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Redirecionamento = True Then
            UltimosAnimes.WindowState = FormWindowState.Normal
        ElseIf Redirecionamento = False Then
            TodosOsAnimes.WindowState = FormWindowState.Normal
            TodosOsAnimes.Width = TodosOsAnimes.LarguraJanelaTodosAnimes
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim Numero As Decimal = ListBox1.SelectedIndex
        Player.LinkEpisodio = ListBoxf.Items(Numero)
        Player.NumeroEpisodio = Numero
        Player.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Redirecionamento = True Then
            UltimosAnimes.WindowState = FormWindowState.Normal
            Me.Close()
        ElseIf Redirecionamento = False Then
            TodosOsAnimes.WindowState = FormWindowState.Normal
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Player.LinkEpisodio = ListBoxf.Items(0)
            Player.NumeroEpisodio = 0
            Player.Show()
            Me.WindowState = FormWindowState.Minimized
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Episodios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
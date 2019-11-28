Imports System.ComponentModel

Public Class Sobre
    Private Sub Sobre_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        UltimosAnimes.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Sobre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = Me.ProductVersion
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Process.Start("https://www.youtube.com/channel/UCR5f5jMUwiQ6H4Yr2U5UP7g")
    End Sub
End Class
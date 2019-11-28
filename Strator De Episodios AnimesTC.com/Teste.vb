Public Class Teste

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate("https://www.animestc.com/online/rezero-kara-hajimeru-isekai-seikatsu-episodio-19/")
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If e.Url = WebBrowser1.Url Then
            'WebBrowser1.Document.GetElementsByClassName("online-botao")(0).InvokeMember("click")
            Dim Line1 = WebBrowser1.Document.GetElementsByClassName("video-online-container")(0).InnerHtml.Split("""")

            TextBox1.AppendText(Line1(NumericUpDown1.Value))


        End If
    End Sub

    Private Sub Teste_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
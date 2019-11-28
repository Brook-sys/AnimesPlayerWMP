Imports System.Text.RegularExpressions
Public Class Form1
    Dim Site
    Dim Numero = 0
    Sub AnimesTC()

    End Sub
    Sub AnimesOne()

    End Sub
    Sub PegarLinkDaPaginaDeAnimeAnimesTC()
        BtnStart.Visible = False
        BtnCopiar.Visible = False
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        For Each i As HtmlElement In WebBrowserPaginaAnime.Document.GetElementsByClassName("container-download-epi")
            Dim re As New Regex("https://www.animestc.com/episodio/.*")
            Dim mc As MatchCollection = re.Matches(Convert.ToString(i.InnerHtml.Split("""")(11)))
            If mc.Count = 0 Then
                Dim mc2 As MatchCollection = re.Matches(Convert.ToString(i.InnerHtml.Split("""")(7)))
                If mc2.Count = 0 Then
                    MsgBox("Erro o texto nao é link de pagina de anime Error!!")
                ElseIf mc2.Count = 1 Then
                    ListBox1.Items.Add(i.InnerHtml.Split("""")(7).Replace("/episodio/", "/online/"))
                    ListBox2.Items.Add(i.InnerHtml.Split("""")(8).Split("=")(1).Replace("itemprop", ""))
                End If
            ElseIf mc.Count = 1 Then
                ListBox1.Items.Add(i.InnerHtml.Split("""")(11).Replace("/episodio/", "/online/"))
                ListBox2.Items.Add(i.InnerHtml.Split("""")(12).Split("=")(1).Replace("itemprop", ""))
            End If
        Next
        BtnStart.Visible = True
        BtnPegarLinkMP4.Visible = True
        Site = "AnimesTC.com"

    End Sub
    Sub PegarLinkDaPaginaDeAnimesAnimesOne()
        BtnStart.Visible = False
        BtnCopiar.Visible = False
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        For Each i As HtmlElement In WebBrowserPaginaAnime.Document.GetElementsByClassName("episodiotitle")
            ListBox1.Items.Add(i.InnerHtml.Split("""")(1))
        Next
        BtnStart.Visible = True
        BtnCopiar.Visible = True
        BtnPegarLinkMP4.Visible = True
    End Sub
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        WebBrowserPaginaAnime.Navigate(TextBox1.Text)
    End Sub

    Private Sub WebBrowserPaginaAnime_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowserPaginaAnime.DocumentCompleted
        If e.Url = WebBrowserPaginaAnime.Url Then
            If RadioAnimesTC.Checked Then
                PegarLinkDaPaginaDeAnimeAnimesTC()
            ElseIf RadioAnimesOne.Checked Then
                PegarLinkDaPaginaDeAnimesAnimesOne()
            End If
        End If
    End Sub

    Sub NavegarAtePaginaDoEpisodio()
        BtnPegarLinkMP4.Visible = False
        BtnCopiar.Visible = False
        WebBrowserPaginaEpisodio.Navigate(ListBox1.Items(Numero))
    End Sub
    Sub PegarLinkMP4AnimesTC()
        Try
            Dim Line = WebBrowserPaginaEpisodio.Document.GetElementsByClassName("video-online")(0).InnerHtml.Split("""")

            ListBox3.Items.Insert(0, Line(27) & "|" & "Episodio " & ListBox2.Items(Numero))
            Numero += 1
            If Numero = ListBox2.Items.Count Then
                BtnPegarLinkMP4.Visible = True
                BtnCopiar.Visible = True
                For Each Linha In ListBox3.Items
                    TextBox2.AppendText(Linha & Environment.NewLine)
                Next
                MsgBox("Muito Bem Todos Os Links Foram Pegos Com Sucesso")
                Numero = 0
                Exit Sub
            End If
            NavegarAtePaginaDoEpisodio()
        Catch ex As Exception
            Try
                Dim Line10 = WebBrowserPaginaEpisodio.Document.GetElementsByClassName("video-online-container")(0).InnerHtml.Split("""")
                ListBox3.Items.Insert(0, Line10(33) & "|" & "Episodio " & ListBox2.Items(Numero))
                Numero += 1
                If Numero = ListBox2.Items.Count Then
                    BtnPegarLinkMP4.Visible = True
                    BtnCopiar.Visible = True
                    For Each Linha In ListBox3.Items
                        TextBox2.AppendText(Linha & Environment.NewLine)
                    Next
                    MsgBox("Muito Bem Todos Os Links Foram Pegos Com Sucesso")
                    Numero = 0
                    Exit Sub
                End If
                NavegarAtePaginaDoEpisodio()
            Catch exx As Exception
                MsgBox("Ocorreu um erro")
            End Try
        End Try
    End Sub
    Sub PegarLinkMP4AnimesOne()

    End Sub

    Private Sub BtnPegarLinkMP4_Click(sender As Object, e As EventArgs) Handles BtnPegarLinkMP4.Click
        NavegarAtePaginaDoEpisodio()
    End Sub

    Private Sub WebBrowserPaginaEpisodio_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowserPaginaEpisodio.DocumentCompleted
        If e.Url = WebBrowserPaginaEpisodio.Url Then
            If Site = "AnimesTC.com" Then
                PegarLinkMP4AnimesTC()
            ElseIf Site = "AnimesOne.com" Then
                PegarLinkMP4AnimesOne()
            End If

        End If

    End Sub

    Private Sub BtnCopiar_Click(sender As Object, e As EventArgs) Handles BtnCopiar.Click
        Clipboard.SetText(TextBox2.Text)
        MsgBox("Copiado Para a Area De Tranferencia")
    End Sub
End Class

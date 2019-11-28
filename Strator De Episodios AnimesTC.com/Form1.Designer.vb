<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.WebBrowserPaginaAnime = New System.Windows.Forms.WebBrowser()
        Me.BtnPegarLinkMP4 = New System.Windows.Forms.Button()
        Me.WebBrowserPaginaEpisodio = New System.Windows.Forms.WebBrowser()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnCopiar = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.RadioAnimesTC = New System.Windows.Forms.RadioButton()
        Me.RadioAnimesOne = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Link Da Pagina Do Anime:"
        '
        'BtnStart
        '
        Me.BtnStart.AutoSize = True
        Me.BtnStart.BackColor = System.Drawing.Color.Black
        Me.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStart.ForeColor = System.Drawing.Color.White
        Me.BtnStart.Location = New System.Drawing.Point(247, 191)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(82, 32)
        Me.BtnStart.TabIndex = 1
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(247, 145)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(239, 26)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "https://www.animestc.com/animes/boku-dake-ga-inai-machi-online-d/"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(29, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Links Das Paginas De Episodio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(136, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(235, 31)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Strator De Animes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(138, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Site:"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Black
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.Location = New System.Drawing.Point(276, 237)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(363, 95)
        Me.ListBox1.TabIndex = 7
        '
        'WebBrowserPaginaAnime
        '
        Me.WebBrowserPaginaAnime.AllowWebBrowserDrop = False
        Me.WebBrowserPaginaAnime.Location = New System.Drawing.Point(63, 191)
        Me.WebBrowserPaginaAnime.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserPaginaAnime.Name = "WebBrowserPaginaAnime"
        Me.WebBrowserPaginaAnime.ScriptErrorsSuppressed = True
        Me.WebBrowserPaginaAnime.Size = New System.Drawing.Size(43, 30)
        Me.WebBrowserPaginaAnime.TabIndex = 8
        Me.WebBrowserPaginaAnime.Url = New System.Uri("", System.UriKind.Relative)
        Me.WebBrowserPaginaAnime.Visible = False
        '
        'BtnPegarLinkMP4
        '
        Me.BtnPegarLinkMP4.AutoSize = True
        Me.BtnPegarLinkMP4.BackColor = System.Drawing.Color.Black
        Me.BtnPegarLinkMP4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPegarLinkMP4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPegarLinkMP4.ForeColor = System.Drawing.Color.White
        Me.BtnPegarLinkMP4.Location = New System.Drawing.Point(123, 329)
        Me.BtnPegarLinkMP4.Name = "BtnPegarLinkMP4"
        Me.BtnPegarLinkMP4.Size = New System.Drawing.Size(147, 32)
        Me.BtnPegarLinkMP4.TabIndex = 10
        Me.BtnPegarLinkMP4.Text = "Pegar Link .mp4"
        Me.BtnPegarLinkMP4.UseVisualStyleBackColor = False
        Me.BtnPegarLinkMP4.Visible = False
        '
        'WebBrowserPaginaEpisodio
        '
        Me.WebBrowserPaginaEpisodio.AllowWebBrowserDrop = False
        Me.WebBrowserPaginaEpisodio.Location = New System.Drawing.Point(654, 25)
        Me.WebBrowserPaginaEpisodio.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserPaginaEpisodio.Name = "WebBrowserPaginaEpisodio"
        Me.WebBrowserPaginaEpisodio.ScriptErrorsSuppressed = True
        Me.WebBrowserPaginaEpisodio.Size = New System.Drawing.Size(303, 232)
        Me.WebBrowserPaginaEpisodio.TabIndex = 11
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.Black
        Me.ListBox2.ForeColor = System.Drawing.Color.White
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(492, 162)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(147, 69)
        Me.ListBox2.TabIndex = 12
        '
        'ListBox3
        '
        Me.ListBox3.BackColor = System.Drawing.Color.Black
        Me.ListBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox3.ForeColor = System.Drawing.Color.White
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.HorizontalScrollbar = True
        Me.ListBox3.Location = New System.Drawing.Point(195, 377)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(444, 95)
        Me.ListBox3.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(33, 377)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Colar No Pastebin:"
        '
        'BtnCopiar
        '
        Me.BtnCopiar.AutoSize = True
        Me.BtnCopiar.BackColor = System.Drawing.Color.Black
        Me.BtnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCopiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCopiar.ForeColor = System.Drawing.Color.White
        Me.BtnCopiar.Location = New System.Drawing.Point(382, 491)
        Me.BtnCopiar.Name = "BtnCopiar"
        Me.BtnCopiar.Size = New System.Drawing.Size(147, 32)
        Me.BtnCopiar.TabIndex = 15
        Me.BtnCopiar.Text = "Copiar "
        Me.BtnCopiar.UseVisualStyleBackColor = False
        Me.BtnCopiar.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(63, 400)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBox2.Size = New System.Drawing.Size(126, 88)
        Me.TextBox2.TabIndex = 16
        '
        'RadioAnimesTC
        '
        Me.RadioAnimesTC.AutoSize = True
        Me.RadioAnimesTC.ForeColor = System.Drawing.Color.White
        Me.RadioAnimesTC.Location = New System.Drawing.Point(195, 53)
        Me.RadioAnimesTC.Name = "RadioAnimesTC"
        Me.RadioAnimesTC.Size = New System.Drawing.Size(96, 17)
        Me.RadioAnimesTC.TabIndex = 17
        Me.RadioAnimesTC.TabStop = True
        Me.RadioAnimesTC.Text = "AnimesTC.com"
        Me.RadioAnimesTC.UseVisualStyleBackColor = True
        '
        'RadioAnimesOne
        '
        Me.RadioAnimesOne.AutoSize = True
        Me.RadioAnimesOne.ForeColor = System.Drawing.Color.White
        Me.RadioAnimesOne.Location = New System.Drawing.Point(297, 53)
        Me.RadioAnimesOne.Name = "RadioAnimesOne"
        Me.RadioAnimesOne.Size = New System.Drawing.Size(102, 17)
        Me.RadioAnimesOne.TabIndex = 17
        Me.RadioAnimesOne.TabStop = True
        Me.RadioAnimesOne.Text = "AnimesOne.com"
        Me.RadioAnimesOne.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1022, 539)
        Me.Controls.Add(Me.RadioAnimesOne)
        Me.Controls.Add(Me.RadioAnimesTC)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.BtnCopiar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.BtnPegarLinkMP4)
        Me.Controls.Add(Me.WebBrowserPaginaAnime)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WebBrowserPaginaEpisodio)
        Me.Name = "Form1"
        Me.Text = " Strator de Animes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnStart As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents WebBrowserPaginaAnime As WebBrowser
    Friend WithEvents BtnPegarLinkMP4 As Button
    Friend WithEvents WebBrowserPaginaEpisodio As WebBrowser
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnCopiar As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents RadioAnimesTC As RadioButton
    Friend WithEvents RadioAnimesOne As RadioButton
End Class

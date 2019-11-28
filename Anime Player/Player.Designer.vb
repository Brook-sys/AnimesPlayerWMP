<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Player
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Player))
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.BtnVoltarEpisodio = New System.Windows.Forms.Button()
        Me.BtnAvancarEpisodio = New System.Windows.Forms.Button()
        Me.LblEpisodio = New System.Windows.Forms.Label()
        Me.TimerVideo = New System.Windows.Forms.Timer(Me.components)
        Me.LblTempoRestante = New System.Windows.Forms.Label()
        Me.TimerChecarFullScreen = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMostrarVolume = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBoxBarraVolume = New System.Windows.Forms.PictureBox()
        Me.PictureBoxIconVolume = New System.Windows.Forms.PictureBox()
        Me.PictureBoxTelaCheia = New System.Windows.Forms.PictureBox()
        Me.PictureBoxPlayPause = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxBarraVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxIconVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxTelaCheia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPlayPause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 0)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(692, 345)
        Me.AxWindowsMediaPlayer1.TabIndex = 2
        '
        'BtnVoltarEpisodio
        '
        Me.BtnVoltarEpisodio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnVoltarEpisodio.BackColor = System.Drawing.Color.Black
        Me.BtnVoltarEpisodio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVoltarEpisodio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVoltarEpisodio.ForeColor = System.Drawing.Color.White
        Me.BtnVoltarEpisodio.Location = New System.Drawing.Point(408, 374)
        Me.BtnVoltarEpisodio.Name = "BtnVoltarEpisodio"
        Me.BtnVoltarEpisodio.Size = New System.Drawing.Size(32, 27)
        Me.BtnVoltarEpisodio.TabIndex = 4
        Me.BtnVoltarEpisodio.Text = "<"
        Me.BtnVoltarEpisodio.UseVisualStyleBackColor = False
        '
        'BtnAvancarEpisodio
        '
        Me.BtnAvancarEpisodio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAvancarEpisodio.BackColor = System.Drawing.Color.Black
        Me.BtnAvancarEpisodio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAvancarEpisodio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAvancarEpisodio.ForeColor = System.Drawing.Color.White
        Me.BtnAvancarEpisodio.Location = New System.Drawing.Point(577, 374)
        Me.BtnAvancarEpisodio.Name = "BtnAvancarEpisodio"
        Me.BtnAvancarEpisodio.Size = New System.Drawing.Size(32, 27)
        Me.BtnAvancarEpisodio.TabIndex = 5
        Me.BtnAvancarEpisodio.Text = ">"
        Me.BtnAvancarEpisodio.UseVisualStyleBackColor = False
        '
        'LblEpisodio
        '
        Me.LblEpisodio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblEpisodio.AutoSize = True
        Me.LblEpisodio.BackColor = System.Drawing.Color.Black
        Me.LblEpisodio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblEpisodio.Font = New System.Drawing.Font("Tw Cen MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEpisodio.ForeColor = System.Drawing.Color.White
        Me.LblEpisodio.Location = New System.Drawing.Point(455, 374)
        Me.LblEpisodio.Name = "LblEpisodio"
        Me.LblEpisodio.Size = New System.Drawing.Size(111, 28)
        Me.LblEpisodio.TabIndex = 6
        Me.LblEpisodio.Text = "Episodio 1"
        '
        'TimerVideo
        '
        Me.TimerVideo.Interval = 1000
        '
        'LblTempoRestante
        '
        Me.LblTempoRestante.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblTempoRestante.AutoSize = True
        Me.LblTempoRestante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTempoRestante.Font = New System.Drawing.Font("Tw Cen MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTempoRestante.ForeColor = System.Drawing.Color.White
        Me.LblTempoRestante.Location = New System.Drawing.Point(210, 375)
        Me.LblTempoRestante.Name = "LblTempoRestante"
        Me.LblTempoRestante.Size = New System.Drawing.Size(127, 24)
        Me.LblTempoRestante.TabIndex = 9
        Me.LblTempoRestante.Text = "00:00/00:00"
        '
        'TimerChecarFullScreen
        '
        Me.TimerChecarFullScreen.Enabled = True
        '
        'TimerMostrarVolume
        '
        Me.TimerMostrarVolume.Enabled = True
        '
        'PictureBoxBarraVolume
        '
        Me.PictureBoxBarraVolume.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxBarraVolume.BackColor = System.Drawing.Color.Black
        Me.PictureBoxBarraVolume.Location = New System.Drawing.Point(105, 373)
        Me.PictureBoxBarraVolume.Name = "PictureBoxBarraVolume"
        Me.PictureBoxBarraVolume.Size = New System.Drawing.Size(105, 28)
        Me.PictureBoxBarraVolume.TabIndex = 14
        Me.PictureBoxBarraVolume.TabStop = False
        '
        'PictureBoxIconVolume
        '
        Me.PictureBoxIconVolume.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxIconVolume.Image = Global.Anime_Player_WMP.My.Resources.Resources.Volume_Alto
        Me.PictureBoxIconVolume.Location = New System.Drawing.Point(77, 372)
        Me.PictureBoxIconVolume.Name = "PictureBoxIconVolume"
        Me.PictureBoxIconVolume.Size = New System.Drawing.Size(28, 28)
        Me.PictureBoxIconVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxIconVolume.TabIndex = 13
        Me.PictureBoxIconVolume.TabStop = False
        '
        'PictureBoxTelaCheia
        '
        Me.PictureBoxTelaCheia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxTelaCheia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxTelaCheia.Location = New System.Drawing.Point(644, 375)
        Me.PictureBoxTelaCheia.Name = "PictureBoxTelaCheia"
        Me.PictureBoxTelaCheia.Size = New System.Drawing.Size(22, 22)
        Me.PictureBoxTelaCheia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxTelaCheia.TabIndex = 12
        Me.PictureBoxTelaCheia.TabStop = False
        '
        'PictureBoxPlayPause
        '
        Me.PictureBoxPlayPause.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxPlayPause.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxPlayPause.Image = CType(resources.GetObject("PictureBoxPlayPause.Image"), System.Drawing.Image)
        Me.PictureBoxPlayPause.Location = New System.Drawing.Point(25, 375)
        Me.PictureBoxPlayPause.Name = "PictureBoxPlayPause"
        Me.PictureBoxPlayPause.Size = New System.Drawing.Size(22, 22)
        Me.PictureBoxPlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPlayPause.TabIndex = 11
        Me.PictureBoxPlayPause.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(12, 354)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(667, 10)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Player
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(691, 408)
        Me.Controls.Add(Me.PictureBoxBarraVolume)
        Me.Controls.Add(Me.PictureBoxIconVolume)
        Me.Controls.Add(Me.PictureBoxTelaCheia)
        Me.Controls.Add(Me.PictureBoxPlayPause)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LblTempoRestante)
        Me.Controls.Add(Me.LblEpisodio)
        Me.Controls.Add(Me.BtnAvancarEpisodio)
        Me.Controls.Add(Me.BtnVoltarEpisodio)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(705, 447)
        Me.Name = "Player"
        Me.Text = "Player"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxBarraVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxIconVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxTelaCheia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPlayPause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents BtnVoltarEpisodio As Button
    Friend WithEvents BtnAvancarEpisodio As Button
    Friend WithEvents LblEpisodio As Label
    Friend WithEvents TimerVideo As Timer
    Friend WithEvents LblTempoRestante As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBoxPlayPause As PictureBox
    Friend WithEvents PictureBoxTelaCheia As PictureBox
    Friend WithEvents TimerChecarFullScreen As Timer
    Friend WithEvents PictureBoxIconVolume As PictureBox
    Friend WithEvents PictureBoxBarraVolume As PictureBox
    Friend WithEvents TimerMostrarVolume As Timer
End Class

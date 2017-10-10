<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ThemeContainer1 = New MonoFlat.ThemeContainer()
        Me.ControlBox1 = New MonoFlat.ControlBox()
        Me.Update_Screen = New MonoFlat.Panel()
        Me.TrackBar1 = New MonoFlat.TrackBar()
        Me.Separator5 = New MonoFlat.Separator()
        Me.Separator3 = New MonoFlat.Separator()
        Me.Separator4 = New MonoFlat.Separator()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.T_Label1 = New MonoFlat.t_Label()
        Me.Button5 = New MonoFlat.Button()
        Me.GamePlay_Scene = New MonoFlat.Panel()
        Me.Separator2 = New MonoFlat.Separator()
        Me.Separator1 = New MonoFlat.Separator()
        Me.Slider = New System.Windows.Forms.PictureBox()
        Me.game_info = New MonoFlat.t_Label()
        Me.Button3 = New MonoFlat.Button()
        Me.Button2 = New MonoFlat.Button()
        Me.Button1 = New MonoFlat.Button()
        Me.SliderTick = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ThemeContainer1.SuspendLayout()
        Me.Update_Screen.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GamePlay_Scene.SuspendLayout()
        CType(Me.Slider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ThemeContainer1
        '
        Me.ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThemeContainer1.Controls.Add(Me.ControlBox1)
        Me.ThemeContainer1.Controls.Add(Me.Update_Screen)
        Me.ThemeContainer1.Controls.Add(Me.GamePlay_Scene)
        Me.ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ThemeContainer1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ThemeContainer1.Name = "ThemeContainer1"
        Me.ThemeContainer1.Padding = New System.Windows.Forms.Padding(0, 60, 0, 0)
        Me.ThemeContainer1.RoundCorners = True
        Me.ThemeContainer1.Sizable = True
        Me.ThemeContainer1.Size = New System.Drawing.Size(734, 461)
        Me.ThemeContainer1.SmartBounds = True
        Me.ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ThemeContainer1.TabIndex = 0
        Me.ThemeContainer1.Text = "{Launcher_name}"
        '
        'ControlBox1
        '
        Me.ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBox1.EnableHoverHighlight = False
        Me.ControlBox1.EnableMaximizeButton = False
        Me.ControlBox1.EnableMinimizeButton = True
        Me.ControlBox1.Location = New System.Drawing.Point(622, 15)
        Me.ControlBox1.Name = "ControlBox1"
        Me.ControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.ControlBox1.TabIndex = 2
        Me.ControlBox1.Text = "ControlBox1"
        '
        'Update_Screen
        '
        Me.Update_Screen.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Update_Screen.Controls.Add(Me.TrackBar1)
        Me.Update_Screen.Controls.Add(Me.Separator5)
        Me.Update_Screen.Controls.Add(Me.Separator3)
        Me.Update_Screen.Controls.Add(Me.Separator4)
        Me.Update_Screen.Controls.Add(Me.PictureBox1)
        Me.Update_Screen.Controls.Add(Me.T_Label1)
        Me.Update_Screen.Controls.Add(Me.Button5)
        Me.Update_Screen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Update_Screen.Location = New System.Drawing.Point(0, 60)
        Me.Update_Screen.Name = "Update_Screen"
        Me.Update_Screen.Padding = New System.Windows.Forms.Padding(5)
        Me.Update_Screen.Size = New System.Drawing.Size(734, 401)
        Me.Update_Screen.TabIndex = 1
        Me.Update_Screen.Text = "Panel1"
        Me.Update_Screen.Visible = False
        '
        'TrackBar1
        '
        Me.TrackBar1.Enabled = False
        Me.TrackBar1.JumpToMouse = False
        Me.TrackBar1.Location = New System.Drawing.Point(12, 376)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Minimum = 0
        Me.TrackBar1.MinimumSize = New System.Drawing.Size(47, 22)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(558, 22)
        Me.TrackBar1.TabIndex = 15
        Me.TrackBar1.Text = "TrackBar1"
        Me.TrackBar1.Value = 0
        Me.TrackBar1.ValueDivison = MonoFlat.TrackBar.ValueDivisor.By1
        Me.TrackBar1.ValueToSet = 0.0!
        '
        'Separator5
        '
        Me.Separator5.Location = New System.Drawing.Point(12, 366)
        Me.Separator5.Name = "Separator5"
        Me.Separator5.Size = New System.Drawing.Size(558, 10)
        Me.Separator5.TabIndex = 14
        Me.Separator5.Text = "Separator5"
        '
        'Separator3
        '
        Me.Separator3.Location = New System.Drawing.Point(10, 5)
        Me.Separator3.Name = "Separator3"
        Me.Separator3.Size = New System.Drawing.Size(714, 10)
        Me.Separator3.TabIndex = 13
        Me.Separator3.Text = "Separator3"
        '
        'Separator4
        '
        Me.Separator4.Location = New System.Drawing.Point(10, 332)
        Me.Separator4.Name = "Separator4"
        Me.Separator4.Size = New System.Drawing.Size(714, 10)
        Me.Separator4.TabIndex = 12
        Me.Separator4.Text = "Separator4"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(10, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(714, 305)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'T_Label1
        '
        Me.T_Label1.BackColor = System.Drawing.Color.Transparent
        Me.T_Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.T_Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.T_Label1.Location = New System.Drawing.Point(12, 346)
        Me.T_Label1.Name = "T_Label1"
        Me.T_Label1.Size = New System.Drawing.Size(558, 15)
        Me.T_Label1.TabIndex = 10
        Me.T_Label1.Text = "Waiting"
        Me.T_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button5.Image = Nothing
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(580, 352)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(146, 41)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "{up_cancel_btn}"
        Me.Button5.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'GamePlay_Scene
        '
        Me.GamePlay_Scene.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.GamePlay_Scene.Controls.Add(Me.Separator2)
        Me.GamePlay_Scene.Controls.Add(Me.Separator1)
        Me.GamePlay_Scene.Controls.Add(Me.Slider)
        Me.GamePlay_Scene.Controls.Add(Me.game_info)
        Me.GamePlay_Scene.Controls.Add(Me.Button3)
        Me.GamePlay_Scene.Controls.Add(Me.Button2)
        Me.GamePlay_Scene.Controls.Add(Me.Button1)
        Me.GamePlay_Scene.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GamePlay_Scene.Location = New System.Drawing.Point(0, 60)
        Me.GamePlay_Scene.Name = "GamePlay_Scene"
        Me.GamePlay_Scene.Padding = New System.Windows.Forms.Padding(5)
        Me.GamePlay_Scene.Size = New System.Drawing.Size(734, 401)
        Me.GamePlay_Scene.TabIndex = 0
        '
        'Separator2
        '
        Me.Separator2.Location = New System.Drawing.Point(8, 6)
        Me.Separator2.Name = "Separator2"
        Me.Separator2.Size = New System.Drawing.Size(714, 10)
        Me.Separator2.TabIndex = 6
        Me.Separator2.Text = "Separator2"
        '
        'Separator1
        '
        Me.Separator1.Location = New System.Drawing.Point(8, 333)
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Size = New System.Drawing.Size(714, 10)
        Me.Separator1.TabIndex = 5
        Me.Separator1.Text = "Separator1"
        '
        'Slider
        '
        Me.Slider.Location = New System.Drawing.Point(8, 22)
        Me.Slider.Name = "Slider"
        Me.Slider.Size = New System.Drawing.Size(714, 305)
        Me.Slider.TabIndex = 4
        Me.Slider.TabStop = False
        '
        'game_info
        '
        Me.game_info.AutoSize = True
        Me.game_info.BackColor = System.Drawing.Color.Transparent
        Me.game_info.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.game_info.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.game_info.Location = New System.Drawing.Point(8, 366)
        Me.game_info.Name = "game_info"
        Me.game_info.Size = New System.Drawing.Size(80, 30)
        Me.game_info.TabIndex = 3
        Me.game_info.Text = "{game_name}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ver {version}"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button3.Image = Nothing
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(576, 352)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(146, 41)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "{exit_btn}"
        Me.Button3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button2.Image = Nothing
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(424, 352)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 41)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "{update_btn}"
        Me.Button2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button1.Image = Nothing
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(272, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "{play_btn}"
        Me.Button1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'SliderTick
        '
        Me.SliderTick.Interval = 10
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.ThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "{Launcher_name}"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ThemeContainer1.ResumeLayout(False)
        Me.Update_Screen.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GamePlay_Scene.ResumeLayout(False)
        Me.GamePlay_Scene.PerformLayout()
        CType(Me.Slider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ThemeContainer1 As MonoFlat.ThemeContainer
    Friend WithEvents GamePlay_Scene As MonoFlat.Panel
    Friend WithEvents Separator2 As MonoFlat.Separator
    Friend WithEvents Separator1 As MonoFlat.Separator
    Friend WithEvents Slider As System.Windows.Forms.PictureBox
    Friend WithEvents game_info As MonoFlat.t_Label
    Friend WithEvents Button3 As MonoFlat.Button
    Friend WithEvents Button2 As MonoFlat.Button
    Friend WithEvents Button1 As MonoFlat.Button
    Friend WithEvents Update_Screen As MonoFlat.Panel
    Friend WithEvents Separator5 As MonoFlat.Separator
    Friend WithEvents Separator3 As MonoFlat.Separator
    Friend WithEvents Separator4 As MonoFlat.Separator
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents T_Label1 As MonoFlat.t_Label
    Friend WithEvents Button5 As MonoFlat.Button
    Friend WithEvents TrackBar1 As MonoFlat.TrackBar
    Friend WithEvents SliderTick As System.Windows.Forms.Timer
    Friend WithEvents ControlBox1 As MonoFlat.ControlBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class

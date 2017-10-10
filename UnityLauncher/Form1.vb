Imports System.Net
Imports SharpCompress.Archive
Imports SharpCompress.Common
Public Class Form1

    Dim host As String = ""
    Dim exit_q As Integer = 0
    Dim slider_max As Integer = 3
    Dim files As String = ""
    Dim start_file As String = ""
    Dim auto_ext As Integer = 1
    Dim RunCode As String

    Delegate Sub ChangeTextsSafe(ByVal length As Long, ByVal position As Integer, ByVal percent As Integer, ByVal speed As Double)
    Delegate Sub DownloadCompleteSafe(ByVal cancelled As Boolean)

    Public Sub DownloadComplete(ByVal cancelled As Boolean)
        If cancelled Then
            MsgBox("indirme iptal edildi", MsgBoxStyle.Information, ThemeContainer1.Text)
            T_Label1.Text = "Waiting"
            TrackBar1.Value = 0
            Update_Screen.Visible = False
            GamePlay_Scene.Visible = True
        Else
            T_Label1.Text = "Lütfen Bekleyin"
            Timer1.Start()
            MsgBox("İşlem Başarılı!", MsgBoxStyle.Information, ThemeContainer1.Text)
            Update_Screen.Visible = False
            GamePlay_Scene.Visible = True
        End If
    End Sub

    Public Sub ChangeTexts(ByVal length As Long, ByVal position As Integer, ByVal percent As Integer, ByVal speed As Double)
        Dim s As String
        s = ((Math.Round((position / 1024)) / Math.Round((length / 1024))) * 100)
        If (s.Contains(",")) Then
            s = s.Split(",")(0)
        End If
        Dim filename, filesize, downst, downloadkb As String
        filename = files
        filesize = Math.Round(((length / 1024) / 1024)) & " MB"
        downloadkb = Math.Round(((position / 1024) / 1024), 2)
        downst = s
        T_Label1.Text = filename & "(" & filesize & ") " & downloadkb & " " & downst & "%"
        TrackBar1.Value = downst
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim theResponse As HttpWebResponse
        Dim theRequest As HttpWebRequest
        Try
            theRequest = WebRequest.Create(host & files)
            theResponse = theRequest.GetResponse
        Catch ex As Exception
            MsgBox(ex.ToString)
            Dim cancelDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)
            Me.Invoke(cancelDelegate, True)
            Exit Sub
            End
        End Try
        Dim length As Long = theResponse.ContentLength
        Dim safedelegate As New ChangeTextsSafe(AddressOf ChangeTexts)
        Me.Invoke(safedelegate, length, 0, 0, 0)
        Dim writeStream As New IO.FileStream(Application.StartupPath & "\" & files, IO.FileMode.Create)
        Dim nRead As Integer
        Dim speedtimer As New Stopwatch
        Dim currentspeed As Double = -1
        Dim readings As Integer = 0
        Do
            If BackgroundWorker1.CancellationPending Then
                Exit Do
            End If
            speedtimer.Start()
            Dim readBytes(4095) As Byte
            Dim bytesread As Integer = theResponse.GetResponseStream.Read(readBytes, 0, 4096)
            nRead += bytesread
            Dim percent As Short = (nRead * 0) / length
            Me.Invoke(safedelegate, length, nRead, percent, currentspeed)
            If bytesread = 0 Then Exit Do
            writeStream.Write(readBytes, 0, bytesread)
            speedtimer.Stop()
            readings += 1
            If readings >= 5 Then
                currentspeed = 20480 / (speedtimer.ElapsedMilliseconds / 1000)
                speedtimer.Reset()
                readings = 0
            End If
        Loop
        theResponse.GetResponseStream.Close()
        writeStream.Close()
        If Me.BackgroundWorker1.CancellationPending Then
            IO.File.Delete(Application.StartupPath & "\" & files)
            Dim cancelDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)
            Me.Invoke(cancelDelegate, True)
            Exit Sub
        End If
        Dim completeDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)
        Me.Invoke(completeDelegate, False)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If exit_q = 0 Then
            End
        Else
            If MsgBox("Çıkmak istediğinizden emin misiniz?", MsgBoxStyle.YesNo, ThemeContainer1.Text) = MsgBoxResult.Yes Then
                End
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim settings As New RichTextBox

        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\config.ini") = True Then
            settings.LoadFile(Application.StartupPath & "\config.ini", RichTextBoxStreamType.PlainText)
            For Each Text As String In settings.Lines
                If Text.Contains("host=") Then
                    host = Text.Split("=")(1)
                ElseIf Text.Contains("launcher_name=") Then
                    ThemeContainer1.Text = Text.Split("=")(1)
                ElseIf Text.Contains("game_name=") Then
                    game_info.Text = Text.Split("=")(1)
                ElseIf Text.Contains("version=") Then
                    game_info.Text &= vbNewLine & "Ver " & Text.Split("=")(1)
                ElseIf Text.Contains("play_btn=") Then
                    Button1.Text = Text.Split("=")(1)
                ElseIf Text.Contains("update_btn=") Then
                    Button2.Text = Text.Split("=")(1)
                ElseIf Text.Contains("exit_btn=") Then
                    Button3.Text = Text.Split("=")(1)
                ElseIf Text.Contains("up_cancel_btn=") Then
                    Button5.Text = Text.Split("=")(1)
                ElseIf Text.Contains("exit_q=") Then
                    exit_q = Text.Split("=")(1)
                ElseIf Text.Contains("slider_max=") Then
                    slider_max = Text.Split("=")(1)
                ElseIf Text.Contains("down_file=") Then
                    files = Text.Split("=")(1)
                ElseIf Text.Contains("start_file=") Then
                    start_file = Text.Split("=")(1)
                ElseIf Text.Contains("SerialCode=") Then
                    RunCode = Text.Split("=")(1)
                End If
            Next
        Else
            MsgBox("config.ini dosyası bulunamadı!", MsgBoxStyle.Information, "Unity Game Launcher")
        End If

        SliderTick.Start()
        SliderTick.Interval = 2000
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GamePlay_Scene.Visible = False
        Update_Screen.Visible = True
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Dim i As Integer = 0
    Private Sub SliderTick_Tick(sender As Object, e As EventArgs) Handles SliderTick.Tick
        If i = slider_max Then
            i = 0
        Else
            i += 1
        End If

        Dim tClient As WebClient = New WebClient
        Dim tImage As Bitmap = Bitmap.FromStream(New IO.MemoryStream(tClient.DownloadData(host & "/slider/slider_" & i & ".jpg")))

        Slider.SizeMode = PictureBoxSizeMode.StretchImage
        Slider.Image = tImage
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Image = tImage
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MsgBox("Yükleme iptal edilsin mi?", MsgBoxStyle.YesNo, ThemeContainer1.Text) = MsgBoxResult.Yes Then
            BackgroundWorker1.CancelAsync()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\" & start_file) = True Then
            Dim RunGame As New ProcessStartInfo
            RunGame.FileName = Application.StartupPath & "\" & start_file
            RunGame.Arguments = "code=" & RunCode
            RunGame.UseShellExecute = True
            RunGame.WindowStyle = ProcessWindowStyle.Normal
            Process.Start(RunGame)
            End
        Else
            MsgBox("Çalıştırılacak dosya bulunamadı!", MsgBoxStyle.Information, ThemeContainer1.Text)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        If auto_ext = 1 Then
            Dim archive As IArchive = ArchiveFactory.Open(Application.StartupPath & "\" & files)
            For Each entry In archive.Entries
                If Not entry.IsDirectory Then
                    Button5.Enabled = False
                    entry.WriteToDirectory(Application.StartupPath, ExtractOptions.ExtractFullPath Or ExtractOptions.Overwrite)
                End If
            Next
        End If
    End Sub
End Class

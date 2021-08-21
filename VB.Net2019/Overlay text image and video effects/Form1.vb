Imports Viscomsoft.VideoCapture

Public Class Form1

    Public _capture As VideoCapture
    Public _devices As Devices

    Public _colorOverlayText As Color = Color.Black
    Public _colorOverlayBack As Color = Color.Transparent

    Private Sub Form1_Leave(sender As Object, e As System.EventArgs) Handles Me.Leave
        _capture.Cleanup()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim i As Integer
        _capture = New VideoCapture()
        _capture.Initialize()

        _devices = New Devices()
        _capture.Encoder.OutputType = OutputType.WMV


        cbooutputimage.Items.Add("Bmp")
        cbooutputimage.Items.Add("JPEG")
        cbooutputimage.Items.Add("PNG")
        cbooutputimage.Items.Add("GIF")
        cbooutputimage.Items.Add("TIF")
        cbooutputimage.SelectedIndex = 0

        cboH264profile.Items.Add("Base")
        cboH264profile.Items.Add("Main")
        cboH264profile.Items.Add("High")
        cboH264profile.SelectedIndex = 0

        cboRotate.Items.Add("No Rotation")
        cboRotate.Items.Add("90-degree rotation without flipping")
        cboRotate.Items.Add("180-degree rotation without flipping")
        cboRotate.Items.Add("270-degree rotation without flipping")
        cboRotate.Items.Add("no rotation and a horizontal flip")
        cboRotate.Items.Add("90-degree rotation followed by a horizontal flip")
        cboRotate.Items.Add("180-degree rotation followed by a horizontal flip")
        cboRotate.Items.Add("270-degree rotation followed by a horizontal flip")
        cboRotate.Items.Add("no rotation and a vertical flip")
        cboRotate.Items.Add("90-degree rotation followed by a vertical flip")
        cboRotate.Items.Add("180-degree rotation followed by a vertical flip")
        cboRotate.Items.Add("270-degree rotation followed by a vertical flip")
        cboRotate.SelectedIndex = 0


        RefreshUI()
    End Sub

    Private Sub RefreshUI()


        If _capture.IsRunning Then
            Exit Sub
        End If

        _devices.Refresh()
        cbovideodevice.Items.Clear()

        For i = 0 To _devices.VideoDevices.Count - 1
            cbovideodevice.Items.Add(_devices.VideoDevices.Item(i).Name)
        Next

        If cbovideodevice.Items.Count > 0 Then
            cbovideodevice.SelectedIndex = 0
        End If

        cboaudiodevice.Items.Clear()

        For i = 0 To _devices.AudioDevices.Count - 1
            cboaudiodevice.Items.Add(_devices.AudioDevices.Item(i).Name)
        Next

        If cboaudiodevice.Items.Count > 0 Then
            cboaudiodevice.SelectedIndex = 0
        End If


    End Sub

    Private Sub cbovideodevice_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbovideodevice.SelectedIndexChanged
        Dim vdevice As VideoDevice
        vdevice = _devices.VideoDevices.Item(cbovideodevice.SelectedIndex)
        _capture.VideoDevice = vdevice

        cbovideoformat.Items.Clear()
        For i = 0 To vdevice.VideoResolutions.Count - 1
            cbovideoformat.Items.Add(vdevice.VideoResolutions.Item(i).Name)
        Next

        If cbovideoformat.Items.Count > 0 Then
            cbovideoformat.SelectedIndex = 0
        End If
    End Sub

    Private Sub cbovideoformat_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbovideoformat.SelectedIndexChanged
        For Each videoresolution In _capture.VideoDevice.VideoResolutions
            If videoresolution.Name.Equals(cbovideoformat.SelectedItem.ToString()) Then
                _capture.VideoDevice.SelectedResolution = videoresolution

                cboframerate.Items.Clear()

                For i = videoresolution.MinFrameRate To videoresolution.MaxFrameRate
                    cboframerate.Items.Add(i)
                Next

            End If
        Next


        If cboframerate.Items.Count > 0 Then
            cboframerate.SelectedIndex = 0
        End If
    End Sub

    Private Sub cboframerate_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboframerate.SelectedIndexChanged
        _capture.VideoDevice.FrameRate = cboframerate.SelectedItem
    End Sub

    Private Sub cboaudiodevice_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboaudiodevice.SelectedIndexChanged
        Dim device As AudioDevice = _devices.AudioDevices.Item(cboaudiodevice.SelectedIndex)
        _capture.AudioDevice = device

        cboaudiosamplerate.Items.Clear()
        For i = 0 To device.AudioSamplingRates.Count - 1
            cboaudiosamplerate.Items.Add(device.AudioSamplingRates.Item(i).Name)
        Next

        If cboaudiosamplerate.Items.Count > 0 Then
            cboaudiosamplerate.SelectedIndex = 0
        End If

        cboaudiobitrate.Items.Clear()

        For Each bitrate In _capture.Encoder.getSupportedAudioBitrates(device.AudioSamplingRates.Item(0).SampleRate, device.AudioSamplingRates.Item(0).Channels)
            cboaudiobitrate.Items.Add(bitrate)
        Next

        If cboaudiobitrate.Items.Count > 0 Then
            cboaudiobitrate.SelectedIndex = 0
        End If
    End Sub

    Private Sub cboaudiobitrate_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboaudiobitrate.SelectedIndexChanged
        _capture.Encoder.AudioBitrate = cboaudiobitrate.SelectedItem

    End Sub

    Private Sub btnpreview_Click(sender As System.Object, e As System.EventArgs) Handles btnpreview.Click
        _capture.Stop()
        _capture.Window = pictureBox1.Handle
        _capture.Mode = VideoCapture.CaptureMode.Preview
        _capture.Start()

        
        UpdateButton(True)
    End Sub

    Private Sub UpdateButton(bEnable As Boolean)

        If bEnable Then

            btnpreview.Enabled = False
            btncapture.Enabled = False

            radioWMVOutputType.Enabled = False
            radioMP4OutputType.Enabled = False
            cboH264profile.Enabled = False
            cbovideodevice.Enabled = False
            cbovideoformat.Enabled = False
            cboframerate.Enabled = False
            txtvideobitrate.Enabled = False
            cboaudiodevice.Enabled = False
            cboaudiosamplerate.Enabled = False
            cboaudiobitrate.Enabled = False

            btnstop.Enabled = True
            btnpause.Enabled = True
            btnresume.Enabled = True
            btnsnapshot.Enabled = True
            btnzoomin.Enabled = True
            btnzoomout.Enabled = True
            btnfullscreen.Enabled = True
        Else

            radioWMVOutputType.Enabled = True
            radioMP4OutputType.Enabled = True
            cboH264profile.Enabled = True
            cbovideodevice.Enabled = True
            cbovideoformat.Enabled = True
            cboframerate.Enabled = True
            txtvideobitrate.Enabled = True
            cboaudiodevice.Enabled = True
            cboaudiosamplerate.Enabled = True
            cboaudiobitrate.Enabled = True

            btnpreview.Enabled = True
            btncapture.Enabled = True
            btnstop.Enabled = False
            btnpause.Enabled = False
            btnresume.Enabled = False
            btnsnapshot.Enabled = False
            btnzoomin.Enabled = False
            btnzoomout.Enabled = False
            btnfullscreen.Enabled = False
        End If

    End Sub

    Private Sub btnstop_Click(sender As System.Object, e As System.EventArgs) Handles btnstop.Click
        _capture.Stop()
        UpdateButton(False)

    End Sub

    Private Sub btnpause_Click(sender As System.Object, e As System.EventArgs) Handles btnpause.Click
        If _capture.IsRunning Then

            _capture.Pause()
            UpdateButton2(False)
        End If

    End Sub

    Private Sub UpdateButton2(bEnable As Boolean)

        If bEnable Then

            btnsnapshot.Enabled = True
            btnzoomin.Enabled = True
            btnzoomout.Enabled = True
            btnfullscreen.Enabled = True

        Else

            btnsnapshot.Enabled = False
            btnzoomin.Enabled = False
            btnzoomout.Enabled = False
            btnfullscreen.Enabled = False

        End If


    End Sub

    Private Sub btnzoomin_Click(sender As System.Object, e As System.EventArgs) Handles btnzoomin.Click
        _capture.VideoDisplay.Zoom(ZoomType.ZoomIn)

        btnPanTop.Enabled = True
        btnPanBottom.Enabled = True
        btnPanLeft.Enabled = True
        btnPanRight.Enabled = True

    End Sub

    Private Sub btnzoomout_Click(sender As System.Object, e As System.EventArgs) Handles btnzoomout.Click
        _capture.VideoDisplay.Zoom(ZoomType.ZoomOut)

    End Sub

    Private Sub btnfullscreen_Click(sender As System.Object, e As System.EventArgs) Handles btnfullscreen.Click
        _capture.VideoDisplay.FullScreen()

    End Sub

    Private Sub btnPanTop_Click(sender As System.Object, e As System.EventArgs) Handles btnPanTop.Click
        _capture.VideoDisplay.Pan(PanType.PanTop)

    End Sub

    Private Sub btnPanLeft_Click(sender As System.Object, e As System.EventArgs) Handles btnPanLeft.Click
        _capture.VideoDisplay.Pan(PanType.PanLeft)

    End Sub

    Private Sub btnPanRight_Click(sender As System.Object, e As System.EventArgs) Handles btnPanRight.Click
        _capture.VideoDisplay.Pan(PanType.PanRight)

    End Sub

    Private Sub btnPanBottom_Click(sender As System.Object, e As System.EventArgs) Handles btnPanBottom.Click
        _capture.VideoDisplay.Pan(PanType.PanBottom)
    End Sub

    Private Sub btncapture_Click(sender As System.Object, e As System.EventArgs) Handles btncapture.Click

        Dim strItem As String = cboH264profile.SelectedItem

        If strItem = "High" Then
            If IsWindows8OrNewer() <> True Then

                MessageBox.Show("H264 high profile support on windows 8 only")
                Return
            End If
        Else

            If radioWMVOutputType.Checked Then

                SaveFileDialog1.Filter = "WMV File (*.wmv)|*.wmv"
                _capture.Encoder.OutputType = OutputType.WMV
            Else

                SaveFileDialog1.Filter = "MP4 File (*.mp4)|*.mp4"
                _capture.Encoder.OutputType = OutputType.MP4


            End If

            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

                _capture.Stop()
                _capture.OutputFile = SaveFileDialog1.FileName

                _capture.Window = pictureBox1.Handle
                _capture.Mode = VideoCapture.CaptureMode.Capture
                _capture.Encoder.VideoBitrate = Int32.Parse(txtvideobitrate.Text)


                Dim iResult As Integer = _capture.Start()

                UpdateButton(True)
                If iResult = -1 Then

                    MessageBox.Show("Video device failed")

                ElseIf (iResult = -2) Then

                    MessageBox.Show("Video Resolution failed")

                ElseIf (iResult = -3) Then

                    MessageBox.Show("Audio device failed")

                ElseIf (iResult = -4) Then

                    MessageBox.Show("Please enter the OutputFile")

                ElseIf (iResult = -5) Then

                    MessageBox.Show("Video windows failed")

                ElseIf (iResult = -6) Then

                    MessageBox.Show("Video Bitrate failed")
                ElseIf (iResult = -7) Then

                    MessageBox.Show("Audio Bitrate failed")

                ElseIf (iResult = -999) Then

                    MessageBox.Show("Registration Error")

                ElseIf (iResult <> 1) Then
                    MessageBox.Show("Error: 0x" + VideoCaptureFoundation.lastError().ToString("X"))
                End If
            End If

        End If

    End Sub


    Private Function IsWindows8OrNewer() As Boolean


        Dim os As Version = Environment.OSVersion.Version


        Return (os.Major > 6 Or (os.Major = 6 And os.Minor >= 2))

    End Function

    Private Sub radioWMVOutputType_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radioWMVOutputType.CheckedChanged
        If radioWMVOutputType.Checked Then

            If Not (_capture Is Nothing) Then
                _capture.Encoder.OutputType = OutputType.WMV
                RefreshUI()
            End If


        End If

    End Sub

    Private Sub radioMP4OutputType_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radioMP4OutputType.CheckedChanged
        If radioMP4OutputType.Checked Then
            If Not (_capture Is Nothing) Then
                _capture.Encoder.OutputType = OutputType.MP4
                RefreshUI()

            End If
        End If

    End Sub

    Private Sub btnsnapshot_Click(sender As System.Object, e As System.EventArgs) Handles btnsnapshot.Click
        If (cbooutputimage.SelectedIndex = 0) Then
            SaveFileDialog1.Filter = "BMP File (*.bmp)|*.bmp"
        ElseIf (cbooutputimage.SelectedIndex = 1) Then
            SaveFileDialog1.Filter = "JPEG File (*.jpg)|*.jpg"
        ElseIf (cbooutputimage.SelectedIndex = 2) Then
            SaveFileDialog1.Filter = "PNG File (*.png)|*.png"
        ElseIf (cbooutputimage.SelectedIndex = 3) Then
            SaveFileDialog1.Filter = "GIF File (*.gif)|*.gif"
        ElseIf (cbooutputimage.SelectedIndex = 4) Then
            SaveFileDialog1.Filter = "TIF File (*.tif)|*.tif"
        End If

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            _capture.Snapshot(SaveFileDialog1.FileName, cbooutputimage.SelectedIndex)
        End If

    End Sub

    Private Sub btnresume_Click(sender As System.Object, e As System.EventArgs) Handles btnresume.Click
        If _capture.IsPaused Then

            _capture.Resume()
            UpdateButton2(False)
        End If
    End Sub

    Private Sub btntextfont_Click(sender As System.Object, e As System.EventArgs) Handles btntextfont.Click
        FontDialog1.ShowDialog()
    End Sub

    Private Sub btntextcolor_Click(sender As System.Object, e As System.EventArgs) Handles btntextcolor.Click
        If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            _colorOverlayText = ColorDialog1.Color
        End If


    End Sub

    Private Sub btntextbgcolor_Click(sender As System.Object, e As System.EventArgs) Handles btntextbgcolor.Click
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            _colorOverlayBack = ColorDialog1.Color
        End If

    End Sub

    Private Sub btnaddtext_Click(sender As System.Object, e As System.EventArgs) Handles btnaddtext.Click
        Dim Overlay As TextOverlay = New TextOverlay()

        
        Overlay.Text = txtoverlaytext.Text
        Overlay.Position = New Point(txttextxpos.Text, txttextypos.Text)
        Overlay.FontName = FontDialog1.Font.FontFamily.Name
        Overlay.FontSize = FontDialog1.Font.Size
        If FontDialog1.Font.Bold And FontDialog1.Font.Italic Then
            Overlay.FontStyle = FontStyleEnum.BoldItalic
        ElseIf FontDialog1.Font.Bold Then
            Overlay.FontStyle = FontStyleEnum.Bold
        ElseIf FontDialog1.Font.Italic Then
            Overlay.FontStyle = FontStyleEnum.Italic
        End If


        If FontDialog1.Font.Underline Then
            Overlay.Underline = True
        
        End If

        Overlay.ForegroundColor = _colorOverlayText

        If chktranbg.Checked Then
            Overlay.BackgroundColor = Color.Transparent
        Else
            Overlay.BackgroundColor = _colorOverlayBack
        End If

        Overlay.Opacity = trackBarTextOpacity.Value

        _capture.VideoOverlay.AddOverlay(Overlay)
    End Sub

    Private Sub btncleartext_Click(sender As System.Object, e As System.EventArgs) Handles btncleartext.Click
        _capture.VideoOverlay.ClearScreen()
    End Sub

    Private Sub btnoverlayimage_Click(sender As System.Object, e As System.EventArgs) Handles btnoverlayimage.Click
        OpenFileDialog1.Filter = "PNG File (*.png)|*.png|JPEG File (*.jpg)|*.jpg|Bitmap File (*.bmp)|*.bmp|Gif File (*.gif)|*.gif|TIF File (*.tif)|*.tif"

        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtoverlayimage.Text = OpenFileDialog1.FileName
        End If


    End Sub

    Private Sub btnaddimage_Click(sender As System.Object, e As System.EventArgs) Handles btnaddimage.Click


        Dim overlay As ImageOverlay = New ImageOverlay()
        overlay.FileName = txtoverlayimage.Text
        overlay.Position = New Point(txtimagexpos.Text, txtimageypos.Text)
        overlay.Opacity = trackBarImageOpacity.Value
        _capture.VideoOverlay.AddOverlay(overlay)

    End Sub

    Private Sub btnclearimage_Click(sender As System.Object, e As System.EventArgs) Handles btnclearimage.Click
        _capture.VideoOverlay.ClearScreen()
    End Sub

    Private Sub trackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles trackBar1.Scroll
        _capture.VideoEffect.Brightness = trackBar1.Value
        lblBrightnessValue.Text = trackBar1.Value.ToString()

    End Sub

    Private Sub trackBar2_Scroll(sender As System.Object, e As System.EventArgs) Handles trackBar2.Scroll
        _capture.VideoEffect.Contrast = trackBar2.Value
        lblContrastValue.Text = trackBar2.Value.ToString()
    End Sub

    Private Sub trackBar3_Scroll(sender As System.Object, e As System.EventArgs) Handles trackBar3.Scroll
        _capture.VideoEffect.Hue = trackBar3.Value
        lblHueValue.Text = trackBar3.Value.ToString()

    End Sub

    Private Sub chkGrayScale_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkGrayScale.CheckedChanged
        _capture.VideoEffect.Grayscale = chkGrayScale.Checked

    End Sub

    Private Sub chkInvert_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkInvert.CheckedChanged
        _capture.VideoEffect.InvertColors = chkInvert.Checked
    End Sub

    Private Sub cboRotate_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboRotate.SelectedIndexChanged
        If cboRotate.SelectedIndex = 0 Then
            _capture.VideoEffect.Rotate = RotateFlipType.RotateNoneFlipNone
        ElseIf cboRotate.SelectedIndex = 1 Then
            _capture.VideoEffect.Rotate = RotateFlipType.Rotate90FlipNone
        ElseIf cboRotate.SelectedIndex = 2 Then
            _capture.VideoEffect.Rotate = RotateFlipType.Rotate180FlipNone
        ElseIf cboRotate.SelectedIndex = 3 Then
            _capture.VideoEffect.Rotate = RotateFlipType.Rotate270FlipNone
        ElseIf cboRotate.SelectedIndex = 4 Then
            _capture.VideoEffect.Rotate = RotateFlipType.RotateNoneFlipX
        ElseIf cboRotate.SelectedIndex = 5 Then
            _capture.VideoEffect.Rotate = RotateFlipType.Rotate90FlipX
        ElseIf cboRotate.SelectedIndex = 6 Then
            _capture.VideoEffect.Rotate = RotateFlipType.Rotate180FlipX
        ElseIf cboRotate.SelectedIndex = 7 Then
            _capture.VideoEffect.Rotate = RotateFlipType.Rotate270FlipX
        ElseIf cboRotate.SelectedIndex = 8 Then
            _capture.VideoEffect.Rotate = RotateFlipType.RotateNoneFlipY
        ElseIf cboRotate.SelectedIndex = 9 Then
            _capture.VideoEffect.Rotate = RotateFlipType.Rotate90FlipY
        ElseIf cboRotate.SelectedIndex = 10 Then
            _capture.VideoEffect.Rotate = RotateFlipType.Rotate180FlipY
        ElseIf cboRotate.SelectedIndex = 11 Then
            _capture.VideoEffect.Rotate = RotateFlipType.Rotate270FlipY
        End If

    End Sub
End Class

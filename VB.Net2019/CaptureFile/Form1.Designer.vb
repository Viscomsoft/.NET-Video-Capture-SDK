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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbovideodevice = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbovideoformat = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboframerate = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtvideobitrate = New System.Windows.Forms.TextBox()
        Me.cboaudiobitrate = New System.Windows.Forms.ComboBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.cboaudiosamplerate = New System.Windows.Forms.ComboBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.cboaudiodevice = New System.Windows.Forms.ComboBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.btnresume = New System.Windows.Forms.Button()
        Me.btnpause = New System.Windows.Forms.Button()
        Me.cboH264profile = New System.Windows.Forms.ComboBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.btncapture = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.radioMP4OutputType = New System.Windows.Forms.RadioButton()
        Me.radioWMVOutputType = New System.Windows.Forms.RadioButton()
        Me.btnPanBottom = New System.Windows.Forms.Button()
        Me.btnPanLeft = New System.Windows.Forms.Button()
        Me.btnPanRight = New System.Windows.Forms.Button()
        Me.btnPanTop = New System.Windows.Forms.Button()
        Me.label8 = New System.Windows.Forms.Label()
        Me.btnfullscreen = New System.Windows.Forms.Button()
        Me.btnzoomout = New System.Windows.Forms.Button()
        Me.btnzoomin = New System.Windows.Forms.Button()
        Me.btnsnapshot = New System.Windows.Forms.Button()
        Me.btnstop = New System.Windows.Forms.Button()
        Me.btnpreview = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.label9 = New System.Windows.Forms.Label()
        Me.cbooutputimage = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(18, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(380, 274)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(454, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Video Device"
        '
        'cbovideodevice
        '
        Me.cbovideodevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideodevice.FormattingEnabled = True
        Me.cbovideodevice.Location = New System.Drawing.Point(562, 14)
        Me.cbovideodevice.Name = "cbovideodevice"
        Me.cbovideodevice.Size = New System.Drawing.Size(275, 20)
        Me.cbovideodevice.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(454, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Resolution"
        '
        'cbovideoformat
        '
        Me.cbovideoformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideoformat.FormattingEnabled = True
        Me.cbovideoformat.Location = New System.Drawing.Point(562, 52)
        Me.cbovideoformat.Name = "cbovideoformat"
        Me.cbovideoformat.Size = New System.Drawing.Size(275, 20)
        Me.cbovideoformat.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(454, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Frame Rate"
        '
        'cboframerate
        '
        Me.cboframerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboframerate.FormattingEnabled = True
        Me.cboframerate.Location = New System.Drawing.Point(562, 94)
        Me.cboframerate.Name = "cboframerate"
        Me.cboframerate.Size = New System.Drawing.Size(105, 20)
        Me.cboframerate.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(454, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Video Bitrate"
        '
        'txtvideobitrate
        '
        Me.txtvideobitrate.Location = New System.Drawing.Point(562, 139)
        Me.txtvideobitrate.Name = "txtvideobitrate"
        Me.txtvideobitrate.Size = New System.Drawing.Size(73, 21)
        Me.txtvideobitrate.TabIndex = 8
        Me.txtvideobitrate.Text = "1000000"
        '
        'cboaudiobitrate
        '
        Me.cboaudiobitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboaudiobitrate.FormattingEnabled = True
        Me.cboaudiobitrate.Location = New System.Drawing.Point(562, 245)
        Me.cboaudiobitrate.Name = "cboaudiobitrate"
        Me.cboaudiobitrate.Size = New System.Drawing.Size(120, 20)
        Me.cboaudiobitrate.TabIndex = 21
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(458, 245)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(83, 12)
        Me.label7.TabIndex = 20
        Me.label7.Text = "Audio Bitrate"
        '
        'cboaudiosamplerate
        '
        Me.cboaudiosamplerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboaudiosamplerate.FormattingEnabled = True
        Me.cboaudiosamplerate.Location = New System.Drawing.Point(562, 212)
        Me.cboaudiosamplerate.Name = "cboaudiosamplerate"
        Me.cboaudiosamplerate.Size = New System.Drawing.Size(258, 20)
        Me.cboaudiosamplerate.TabIndex = 19
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(458, 212)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(107, 12)
        Me.label6.TabIndex = 18
        Me.label6.Text = "Audio Sample Rate"
        '
        'cboaudiodevice
        '
        Me.cboaudiodevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboaudiodevice.FormattingEnabled = True
        Me.cboaudiodevice.Location = New System.Drawing.Point(562, 173)
        Me.cboaudiodevice.Name = "cboaudiodevice"
        Me.cboaudiodevice.Size = New System.Drawing.Size(258, 20)
        Me.cboaudiodevice.TabIndex = 17
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(458, 175)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(77, 12)
        Me.label5.TabIndex = 16
        Me.label5.Text = "Audio Device"
        '
        'btnresume
        '
        Me.btnresume.Enabled = False
        Me.btnresume.Location = New System.Drawing.Point(595, 353)
        Me.btnresume.Name = "btnresume"
        Me.btnresume.Size = New System.Drawing.Size(123, 36)
        Me.btnresume.TabIndex = 44
        Me.btnresume.Text = "Resume"
        Me.btnresume.UseVisualStyleBackColor = True
        '
        'btnpause
        '
        Me.btnpause.Enabled = False
        Me.btnpause.Location = New System.Drawing.Point(456, 353)
        Me.btnpause.Name = "btnpause"
        Me.btnpause.Size = New System.Drawing.Size(123, 36)
        Me.btnpause.TabIndex = 43
        Me.btnpause.Text = "Pause"
        Me.btnpause.UseVisualStyleBackColor = True
        '
        'cboH264profile
        '
        Me.cboH264profile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboH264profile.FormattingEnabled = True
        Me.cboH264profile.Location = New System.Drawing.Point(303, 23)
        Me.cboH264profile.Name = "cboH264profile"
        Me.cboH264profile.Size = New System.Drawing.Size(120, 20)
        Me.cboH264profile.TabIndex = 27
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(229, 23)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(83, 12)
        Me.label10.TabIndex = 2
        Me.label10.Text = "H.264 Profile"
        '
        'btncapture
        '
        Me.btncapture.Location = New System.Drawing.Point(167, 353)
        Me.btncapture.Name = "btncapture"
        Me.btncapture.Size = New System.Drawing.Size(129, 36)
        Me.btncapture.TabIndex = 42
        Me.btncapture.Text = "Capture"
        Me.btncapture.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.cboH264profile)
        Me.groupBox1.Controls.Add(Me.label10)
        Me.groupBox1.Controls.Add(Me.groupBox2)
        Me.groupBox1.Location = New System.Drawing.Point(18, 293)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(511, 55)
        Me.groupBox1.TabIndex = 41
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Capture"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.radioMP4OutputType)
        Me.groupBox2.Controls.Add(Me.radioWMVOutputType)
        Me.groupBox2.Location = New System.Drawing.Point(6, 12)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(209, 33)
        Me.groupBox2.TabIndex = 1
        Me.groupBox2.TabStop = False
        '
        'radioMP4OutputType
        '
        Me.radioMP4OutputType.AutoSize = True
        Me.radioMP4OutputType.Location = New System.Drawing.Point(123, 13)
        Me.radioMP4OutputType.Name = "radioMP4OutputType"
        Me.radioMP4OutputType.Size = New System.Drawing.Size(27, 11)
        Me.radioMP4OutputType.TabIndex = 1
        Me.radioMP4OutputType.Text = "MP4"
        Me.radioMP4OutputType.UseVisualStyleBackColor = True
        '
        'radioWMVOutputType
        '
        Me.radioWMVOutputType.AutoSize = True
        Me.radioWMVOutputType.Checked = True
        Me.radioWMVOutputType.Location = New System.Drawing.Point(17, 14)
        Me.radioWMVOutputType.Name = "radioWMVOutputType"
        Me.radioWMVOutputType.Size = New System.Drawing.Size(27, 11)
        Me.radioWMVOutputType.TabIndex = 0
        Me.radioWMVOutputType.TabStop = True
        Me.radioWMVOutputType.Text = "WMV"
        Me.radioWMVOutputType.UseVisualStyleBackColor = True
        '
        'btnPanBottom
        '
        Me.btnPanBottom.Enabled = False
        Me.btnPanBottom.Location = New System.Drawing.Point(130, 544)
        Me.btnPanBottom.Name = "btnPanBottom"
        Me.btnPanBottom.Size = New System.Drawing.Size(58, 33)
        Me.btnPanBottom.TabIndex = 40
        Me.btnPanBottom.Text = "B"
        Me.btnPanBottom.UseVisualStyleBackColor = True
        '
        'btnPanLeft
        '
        Me.btnPanLeft.Enabled = False
        Me.btnPanLeft.Location = New System.Drawing.Point(67, 499)
        Me.btnPanLeft.Name = "btnPanLeft"
        Me.btnPanLeft.Size = New System.Drawing.Size(58, 33)
        Me.btnPanLeft.TabIndex = 39
        Me.btnPanLeft.Text = "L"
        Me.btnPanLeft.UseVisualStyleBackColor = True
        '
        'btnPanRight
        '
        Me.btnPanRight.Enabled = False
        Me.btnPanRight.Location = New System.Drawing.Point(202, 499)
        Me.btnPanRight.Name = "btnPanRight"
        Me.btnPanRight.Size = New System.Drawing.Size(58, 33)
        Me.btnPanRight.TabIndex = 38
        Me.btnPanRight.Text = "R"
        Me.btnPanRight.UseVisualStyleBackColor = True
        '
        'btnPanTop
        '
        Me.btnPanTop.Enabled = False
        Me.btnPanTop.Location = New System.Drawing.Point(130, 456)
        Me.btnPanTop.Name = "btnPanTop"
        Me.btnPanTop.Size = New System.Drawing.Size(58, 33)
        Me.btnPanTop.TabIndex = 37
        Me.btnPanTop.Text = "T"
        Me.btnPanTop.UseVisualStyleBackColor = True
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(268, 456)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(209, 12)
        Me.label8.TabIndex = 36
        Me.label8.Text = "Press ESC to close the full screen"
        '
        'btnfullscreen
        '
        Me.btnfullscreen.Enabled = False
        Me.btnfullscreen.Location = New System.Drawing.Point(312, 400)
        Me.btnfullscreen.Name = "btnfullscreen"
        Me.btnfullscreen.Size = New System.Drawing.Size(122, 35)
        Me.btnfullscreen.TabIndex = 35
        Me.btnfullscreen.Text = "Full Screen"
        Me.btnfullscreen.UseVisualStyleBackColor = True
        '
        'btnzoomout
        '
        Me.btnzoomout.Enabled = False
        Me.btnzoomout.Location = New System.Drawing.Point(167, 400)
        Me.btnzoomout.Name = "btnzoomout"
        Me.btnzoomout.Size = New System.Drawing.Size(130, 36)
        Me.btnzoomout.TabIndex = 34
        Me.btnzoomout.Text = "Zoom Out"
        Me.btnzoomout.UseVisualStyleBackColor = True
        '
        'btnzoomin
        '
        Me.btnzoomin.Enabled = False
        Me.btnzoomin.Location = New System.Drawing.Point(18, 400)
        Me.btnzoomin.Name = "btnzoomin"
        Me.btnzoomin.Size = New System.Drawing.Size(130, 36)
        Me.btnzoomin.TabIndex = 33
        Me.btnzoomin.Text = "Zoom In"
        Me.btnzoomin.UseVisualStyleBackColor = True
        '
        'btnsnapshot
        '
        Me.btnsnapshot.Enabled = False
        Me.btnsnapshot.Location = New System.Drawing.Point(736, 353)
        Me.btnsnapshot.Name = "btnsnapshot"
        Me.btnsnapshot.Size = New System.Drawing.Size(122, 36)
        Me.btnsnapshot.TabIndex = 32
        Me.btnsnapshot.Text = "Snapshot"
        Me.btnsnapshot.UseVisualStyleBackColor = True
        '
        'btnstop
        '
        Me.btnstop.Enabled = False
        Me.btnstop.Location = New System.Drawing.Point(312, 353)
        Me.btnstop.Name = "btnstop"
        Me.btnstop.Size = New System.Drawing.Size(123, 36)
        Me.btnstop.TabIndex = 31
        Me.btnstop.Text = "Stop"
        Me.btnstop.UseVisualStyleBackColor = True
        '
        'btnpreview
        '
        Me.btnpreview.Location = New System.Drawing.Point(21, 353)
        Me.btnpreview.Name = "btnpreview"
        Me.btnpreview.Size = New System.Drawing.Size(127, 36)
        Me.btnpreview.TabIndex = 30
        Me.btnpreview.Text = "Preview"
        Me.btnpreview.UseVisualStyleBackColor = True
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(641, 323)
        Me.label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(77, 12)
        Me.label9.TabIndex = 46
        Me.label9.Text = "Output Image"
        '
        'cbooutputimage
        '
        Me.cbooutputimage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbooutputimage.FormattingEnabled = True
        Me.cbooutputimage.Location = New System.Drawing.Point(727, 321)
        Me.cbooutputimage.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbooutputimage.Name = "cbooutputimage"
        Me.cbooutputimage.Size = New System.Drawing.Size(132, 20)
        Me.cbooutputimage.TabIndex = 45
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 627)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.cbooutputimage)
        Me.Controls.Add(Me.btnresume)
        Me.Controls.Add(Me.btnpause)
        Me.Controls.Add(Me.btncapture)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.btnPanBottom)
        Me.Controls.Add(Me.btnPanLeft)
        Me.Controls.Add(Me.btnPanRight)
        Me.Controls.Add(Me.btnPanTop)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.btnfullscreen)
        Me.Controls.Add(Me.btnzoomout)
        Me.Controls.Add(Me.btnzoomin)
        Me.Controls.Add(Me.btnsnapshot)
        Me.Controls.Add(Me.btnstop)
        Me.Controls.Add(Me.btnpreview)
        Me.Controls.Add(Me.cboaudiobitrate)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.cboaudiosamplerate)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.cboaudiodevice)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txtvideobitrate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboframerate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbovideoformat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbovideodevice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = ".Net Capture File"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbovideodevice As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbovideoformat As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboframerate As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents txtvideobitrate As System.Windows.Forms.TextBox
    Private WithEvents cboaudiobitrate As System.Windows.Forms.ComboBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents cboaudiosamplerate As System.Windows.Forms.ComboBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents cboaudiodevice As System.Windows.Forms.ComboBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents btnresume As System.Windows.Forms.Button
    Private WithEvents btnpause As System.Windows.Forms.Button
    Private WithEvents cboH264profile As System.Windows.Forms.ComboBox
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents btncapture As System.Windows.Forms.Button
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents radioMP4OutputType As System.Windows.Forms.RadioButton
    Private WithEvents radioWMVOutputType As System.Windows.Forms.RadioButton
    Private WithEvents btnPanBottom As System.Windows.Forms.Button
    Private WithEvents btnPanLeft As System.Windows.Forms.Button
    Private WithEvents btnPanRight As System.Windows.Forms.Button
    Private WithEvents btnPanTop As System.Windows.Forms.Button
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents btnfullscreen As System.Windows.Forms.Button
    Private WithEvents btnzoomout As System.Windows.Forms.Button
    Private WithEvents btnzoomin As System.Windows.Forms.Button
    Private WithEvents btnsnapshot As System.Windows.Forms.Button
    Private WithEvents btnstop As System.Windows.Forms.Button
    Private WithEvents btnpreview As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents cbooutputimage As System.Windows.Forms.ComboBox

End Class

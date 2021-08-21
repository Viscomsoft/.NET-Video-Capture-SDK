namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbovideodevice = new System.Windows.Forms.ComboBox();
            this.btnpreview = new System.Windows.Forms.Button();
            this.cbovideoformat = new System.Windows.Forms.ComboBox();
            this.cboframerate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtvideobitrate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboaudiodevice = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboaudiosamplerate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboaudiobitrate = new System.Windows.Forms.ComboBox();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnsnapshot = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnzoomin = new System.Windows.Forms.Button();
            this.btnzoomout = new System.Windows.Forms.Button();
            this.btnfullscreen = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPanTop = new System.Windows.Forms.Button();
            this.btnPanRight = new System.Windows.Forms.Button();
            this.btnPanLeft = new System.Windows.Forms.Button();
            this.btnPanBottom = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboH264profile = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioMP4OutputType = new System.Windows.Forms.RadioButton();
            this.radioWMVOutputType = new System.Windows.Forms.RadioButton();
            this.btncapture = new System.Windows.Forms.Button();
            this.btnpause = new System.Windows.Forms.Button();
            this.btnresume = new System.Windows.Forms.Button();
            this.cbooutputimage = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 296);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbovideodevice
            // 
            this.cbovideodevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbovideodevice.FormattingEnabled = true;
            this.cbovideodevice.Location = new System.Drawing.Point(539, 20);
            this.cbovideodevice.Name = "cbovideodevice";
            this.cbovideodevice.Size = new System.Drawing.Size(258, 20);
            this.cbovideodevice.TabIndex = 1;
            this.cbovideodevice.SelectedIndexChanged += new System.EventHandler(this.cbovideodevice_SelectedIndexChanged);
            // 
            // btnpreview
            // 
            this.btnpreview.Location = new System.Drawing.Point(25, 367);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(127, 36);
            this.btnpreview.TabIndex = 2;
            this.btnpreview.Text = "Preview";
            this.btnpreview.UseVisualStyleBackColor = true;
            this.btnpreview.Click += new System.EventHandler(this.btnpreview_Click);
            // 
            // cbovideoformat
            // 
            this.cbovideoformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbovideoformat.FormattingEnabled = true;
            this.cbovideoformat.Location = new System.Drawing.Point(539, 60);
            this.cbovideoformat.Name = "cbovideoformat";
            this.cbovideoformat.Size = new System.Drawing.Size(258, 20);
            this.cbovideoformat.TabIndex = 3;
            this.cbovideoformat.SelectedIndexChanged += new System.EventHandler(this.cbovideoformat_SelectedIndexChanged);
            // 
            // cboframerate
            // 
            this.cboframerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboframerate.FormattingEnabled = true;
            this.cboframerate.Location = new System.Drawing.Point(539, 100);
            this.cboframerate.Name = "cboframerate";
            this.cboframerate.Size = new System.Drawing.Size(120, 20);
            this.cboframerate.TabIndex = 4;
            this.cboframerate.SelectedIndexChanged += new System.EventHandler(this.cboframerate_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Frame Rate";
            // 
            // txtvideobitrate
            // 
            this.txtvideobitrate.Location = new System.Drawing.Point(539, 134);
            this.txtvideobitrate.Name = "txtvideobitrate";
            this.txtvideobitrate.Size = new System.Drawing.Size(73, 21);
            this.txtvideobitrate.TabIndex = 6;
            this.txtvideobitrate.Text = "1000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Video Bitrate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Video Device";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resolution";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Audio Device";
            // 
            // cboaudiodevice
            // 
            this.cboaudiodevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboaudiodevice.FormattingEnabled = true;
            this.cboaudiodevice.Location = new System.Drawing.Point(539, 158);
            this.cboaudiodevice.Name = "cboaudiodevice";
            this.cboaudiodevice.Size = new System.Drawing.Size(258, 20);
            this.cboaudiodevice.TabIndex = 11;
            this.cboaudiodevice.SelectedIndexChanged += new System.EventHandler(this.cboaudiodevice_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "Audio Sample Rate";
            // 
            // cboaudiosamplerate
            // 
            this.cboaudiosamplerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboaudiosamplerate.FormattingEnabled = true;
            this.cboaudiosamplerate.Location = new System.Drawing.Point(539, 197);
            this.cboaudiosamplerate.Name = "cboaudiosamplerate";
            this.cboaudiosamplerate.Size = new System.Drawing.Size(258, 20);
            this.cboaudiosamplerate.TabIndex = 13;
            this.cboaudiosamplerate.SelectedIndexChanged += new System.EventHandler(this.cboaudiosamplerate_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "Audio Bitrate";
            // 
            // cboaudiobitrate
            // 
            this.cboaudiobitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboaudiobitrate.FormattingEnabled = true;
            this.cboaudiobitrate.Location = new System.Drawing.Point(539, 230);
            this.cboaudiobitrate.Name = "cboaudiobitrate";
            this.cboaudiobitrate.Size = new System.Drawing.Size(120, 20);
            this.cboaudiobitrate.TabIndex = 15;
            this.cboaudiobitrate.SelectedIndexChanged += new System.EventHandler(this.cboaudiobitrate_SelectedIndexChanged);
            // 
            // btnstop
            // 
            this.btnstop.Enabled = false;
            this.btnstop.Location = new System.Drawing.Point(316, 367);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(123, 36);
            this.btnstop.TabIndex = 16;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnsnapshot
            // 
            this.btnsnapshot.Enabled = false;
            this.btnsnapshot.Location = new System.Drawing.Point(740, 367);
            this.btnsnapshot.Name = "btnsnapshot";
            this.btnsnapshot.Size = new System.Drawing.Size(122, 36);
            this.btnsnapshot.TabIndex = 17;
            this.btnsnapshot.Text = "Snapshot";
            this.btnsnapshot.UseVisualStyleBackColor = true;
            this.btnsnapshot.Click += new System.EventHandler(this.btnsnapshot_Click);
            // 
            // btnzoomin
            // 
            this.btnzoomin.Enabled = false;
            this.btnzoomin.Location = new System.Drawing.Point(22, 413);
            this.btnzoomin.Name = "btnzoomin";
            this.btnzoomin.Size = new System.Drawing.Size(130, 36);
            this.btnzoomin.TabIndex = 18;
            this.btnzoomin.Text = "Zoom In";
            this.btnzoomin.UseVisualStyleBackColor = true;
            this.btnzoomin.Click += new System.EventHandler(this.btnzoomin_Click);
            // 
            // btnzoomout
            // 
            this.btnzoomout.Enabled = false;
            this.btnzoomout.Location = new System.Drawing.Point(171, 413);
            this.btnzoomout.Name = "btnzoomout";
            this.btnzoomout.Size = new System.Drawing.Size(130, 36);
            this.btnzoomout.TabIndex = 19;
            this.btnzoomout.Text = "Zoom Out";
            this.btnzoomout.UseVisualStyleBackColor = true;
            this.btnzoomout.Click += new System.EventHandler(this.btnzoomout_Click);
            // 
            // btnfullscreen
            // 
            this.btnfullscreen.Enabled = false;
            this.btnfullscreen.Location = new System.Drawing.Point(316, 413);
            this.btnfullscreen.Name = "btnfullscreen";
            this.btnfullscreen.Size = new System.Drawing.Size(122, 35);
            this.btnfullscreen.TabIndex = 20;
            this.btnfullscreen.Text = "Full Screen";
            this.btnfullscreen.UseVisualStyleBackColor = true;
            this.btnfullscreen.Click += new System.EventHandler(this.btnfullscreen_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "Press ESC to close the full screen";
            // 
            // btnPanTop
            // 
            this.btnPanTop.Enabled = false;
            this.btnPanTop.Location = new System.Drawing.Point(134, 469);
            this.btnPanTop.Name = "btnPanTop";
            this.btnPanTop.Size = new System.Drawing.Size(58, 33);
            this.btnPanTop.TabIndex = 22;
            this.btnPanTop.Text = "T";
            this.btnPanTop.UseVisualStyleBackColor = true;
            this.btnPanTop.Click += new System.EventHandler(this.btnPanTop_Click);
            // 
            // btnPanRight
            // 
            this.btnPanRight.Enabled = false;
            this.btnPanRight.Location = new System.Drawing.Point(206, 511);
            this.btnPanRight.Name = "btnPanRight";
            this.btnPanRight.Size = new System.Drawing.Size(58, 33);
            this.btnPanRight.TabIndex = 23;
            this.btnPanRight.Text = "R";
            this.btnPanRight.UseVisualStyleBackColor = true;
            this.btnPanRight.Click += new System.EventHandler(this.btnPanRight_Click);
            // 
            // btnPanLeft
            // 
            this.btnPanLeft.Enabled = false;
            this.btnPanLeft.Location = new System.Drawing.Point(71, 511);
            this.btnPanLeft.Name = "btnPanLeft";
            this.btnPanLeft.Size = new System.Drawing.Size(58, 33);
            this.btnPanLeft.TabIndex = 24;
            this.btnPanLeft.Text = "L";
            this.btnPanLeft.UseVisualStyleBackColor = true;
            this.btnPanLeft.Click += new System.EventHandler(this.btnPanLeft_Click);
            // 
            // btnPanBottom
            // 
            this.btnPanBottom.Enabled = false;
            this.btnPanBottom.Location = new System.Drawing.Point(134, 557);
            this.btnPanBottom.Name = "btnPanBottom";
            this.btnPanBottom.Size = new System.Drawing.Size(58, 33);
            this.btnPanBottom.TabIndex = 25;
            this.btnPanBottom.Text = "B";
            this.btnPanBottom.UseVisualStyleBackColor = true;
            this.btnPanBottom.Click += new System.EventHandler(this.btnPanBottom_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboH264profile);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(22, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 55);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Capture";
            // 
            // cboH264profile
            // 
            this.cboH264profile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboH264profile.FormattingEnabled = true;
            this.cboH264profile.Location = new System.Drawing.Point(303, 23);
            this.cboH264profile.Name = "cboH264profile";
            this.cboH264profile.Size = new System.Drawing.Size(120, 20);
            this.cboH264profile.TabIndex = 27;
            this.cboH264profile.SelectedIndexChanged += new System.EventHandler(this.cboH264profile_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(229, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "H.264 Profile";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioMP4OutputType);
            this.groupBox2.Controls.Add(this.radioWMVOutputType);
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 33);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // radioMP4OutputType
            // 
            this.radioMP4OutputType.AutoSize = true;
            this.radioMP4OutputType.Location = new System.Drawing.Point(123, 13);
            this.radioMP4OutputType.Name = "radioMP4OutputType";
            this.radioMP4OutputType.Size = new System.Drawing.Size(27, 11);
            this.radioMP4OutputType.TabIndex = 1;
            this.radioMP4OutputType.Text = "MP4";
            this.radioMP4OutputType.UseVisualStyleBackColor = true;
            this.radioMP4OutputType.CheckedChanged += new System.EventHandler(this.radioMP4OutputType_CheckedChanged);
            // 
            // radioWMVOutputType
            // 
            this.radioWMVOutputType.AutoSize = true;
            this.radioWMVOutputType.Checked = true;
            this.radioWMVOutputType.Location = new System.Drawing.Point(17, 14);
            this.radioWMVOutputType.Name = "radioWMVOutputType";
            this.radioWMVOutputType.Size = new System.Drawing.Size(27, 11);
            this.radioWMVOutputType.TabIndex = 0;
            this.radioWMVOutputType.TabStop = true;
            this.radioWMVOutputType.Text = "WMV";
            this.radioWMVOutputType.UseVisualStyleBackColor = true;
            this.radioWMVOutputType.CheckedChanged += new System.EventHandler(this.radioWMVOutputType_CheckedChanged);
            // 
            // btncapture
            // 
            this.btncapture.Location = new System.Drawing.Point(171, 367);
            this.btncapture.Name = "btncapture";
            this.btncapture.Size = new System.Drawing.Size(129, 36);
            this.btncapture.TabIndex = 27;
            this.btncapture.Text = "Capture";
            this.btncapture.UseVisualStyleBackColor = true;
            this.btncapture.Click += new System.EventHandler(this.btncapture_Click);
            // 
            // btnpause
            // 
            this.btnpause.Enabled = false;
            this.btnpause.Location = new System.Drawing.Point(460, 367);
            this.btnpause.Name = "btnpause";
            this.btnpause.Size = new System.Drawing.Size(123, 36);
            this.btnpause.TabIndex = 28;
            this.btnpause.Text = "Pause";
            this.btnpause.UseVisualStyleBackColor = true;
            this.btnpause.Click += new System.EventHandler(this.btnpause_Click);
            // 
            // btnresume
            // 
            this.btnresume.Enabled = false;
            this.btnresume.Location = new System.Drawing.Point(599, 367);
            this.btnresume.Name = "btnresume";
            this.btnresume.Size = new System.Drawing.Size(123, 36);
            this.btnresume.TabIndex = 29;
            this.btnresume.Text = "Resume";
            this.btnresume.UseVisualStyleBackColor = true;
            this.btnresume.Click += new System.EventHandler(this.btnresume_Click);
            // 
            // cbooutputimage
            // 
            this.cbooutputimage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbooutputimage.FormattingEnabled = true;
            this.cbooutputimage.Location = new System.Drawing.Point(731, 333);
            this.cbooutputimage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbooutputimage.Name = "cbooutputimage";
            this.cbooutputimage.Size = new System.Drawing.Size(132, 20);
            this.cbooutputimage.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(644, 335);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 31;
            this.label9.Text = "Output Image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 612);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbooutputimage);
            this.Controls.Add(this.btnresume);
            this.Controls.Add(this.btnpause);
            this.Controls.Add(this.btncapture);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPanBottom);
            this.Controls.Add(this.btnPanLeft);
            this.Controls.Add(this.btnPanRight);
            this.Controls.Add(this.btnPanTop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnfullscreen);
            this.Controls.Add(this.btnzoomout);
            this.Controls.Add(this.btnzoomin);
            this.Controls.Add(this.btnsnapshot);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.cboaudiobitrate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboaudiosamplerate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboaudiodevice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtvideobitrate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboframerate);
            this.Controls.Add(this.cbovideoformat);
            this.Controls.Add(this.btnpreview);
            this.Controls.Add(this.cbovideodevice);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = ".Net Capture File";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onFormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbovideodevice;
        private System.Windows.Forms.Button btnpreview;
        private System.Windows.Forms.ComboBox cbovideoformat;
        private System.Windows.Forms.ComboBox cboframerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtvideobitrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboaudiodevice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboaudiosamplerate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboaudiobitrate;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnsnapshot;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnzoomin;
        private System.Windows.Forms.Button btnzoomout;
        private System.Windows.Forms.Button btnfullscreen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPanTop;
        private System.Windows.Forms.Button btnPanRight;
        private System.Windows.Forms.Button btnPanLeft;
        private System.Windows.Forms.Button btnPanBottom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioMP4OutputType;
        private System.Windows.Forms.RadioButton radioWMVOutputType;
        private System.Windows.Forms.ComboBox cboH264profile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btncapture;
        private System.Windows.Forms.Button btnpause;
        private System.Windows.Forms.Button btnresume;
        private System.Windows.Forms.ComboBox cbooutputimage;
        private System.Windows.Forms.Label label9;
    }
}


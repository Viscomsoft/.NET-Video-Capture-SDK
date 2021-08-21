using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Viscomsoft.VideoCapture;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private VideoCapture _capture;
        private Devices _devices;
        public Form1()
        {
            //Viscomsoft.VideoCapture.dll
            //Viscomsoft.VideoCapture.Foundation.dll

            InitializeComponent();
            _capture = new VideoCapture();
            _capture.Initialize();

            _devices = new Devices();
            _capture.Encoder.OutputType = OutputType.WMV;
            refresh();

        }

        private void refresh()
        {
            if (_capture.IsRunning)
                return;

            _devices.Refresh();

            this.cbovideodevice.Items.Clear();

            for (int i = 0; i < _devices.VideoDevices.Count; i++)
                cbovideodevice.Items.Add(_devices.VideoDevices[i].Name);

            this.cbovideoformat.Items.Clear();
            this.cboframerate.Items.Clear();

            if (cbovideodevice.Items.Count > 0)
                cbovideodevice.SelectedIndex = 0;

            this.cboaudiodevice.Items.Clear();
            for (int i = 0; i < _devices.AudioDevices.Count; i++)
                cboaudiodevice.Items.Add(_devices.AudioDevices[i].Name);

            if (cboaudiodevice.Items.Count > 0)
                cboaudiodevice.SelectedIndex = 0;

        }
        private void UpdateButton(bool bEnable)
        {
          
            if (bEnable)
            {
                if (_capture.Mode == VideoCapture.CaptureMode.Capture)
                {
                    this.btnpreview.Enabled = false;
                    this.btncapture.Enabled = false;
                  
                
                }
                else
                {
                    this.btnpreview.Enabled = false;
                    this.btncapture.Enabled = false;
                   
                }

                this.radioWMVOutputType.Enabled = false;
                this.radioMP4OutputType.Enabled = false;
                this.cboH264profile.Enabled = false;
                this.cbovideodevice.Enabled = false;
                this.cbovideoformat.Enabled = false;
                this.cboframerate.Enabled = false;
                this.txtvideobitrate.Enabled = false;
                this.cboaudiodevice.Enabled = false;
                this.cboaudiosamplerate.Enabled = false;
                this.cboaudiobitrate.Enabled = false;

                this.btnstop.Enabled = true;
                this.btnpause.Enabled = true;
                this.btnresume.Enabled = true;
                this.btnsnapshot.Enabled = true;
                this.btnzoomin.Enabled = true;
                this.btnzoomout.Enabled = true;
                this.btnfullscreen.Enabled = true;
            }
            else
            {
                this.radioWMVOutputType.Enabled = true;
                this.radioMP4OutputType.Enabled = true;
                this.cboH264profile.Enabled = true;
                this.cbovideodevice.Enabled = true;
                this.cbovideoformat.Enabled = true;
                this.cboframerate.Enabled = true;
                this.txtvideobitrate.Enabled = true;
                this.cboaudiodevice.Enabled = true;
                this.cboaudiosamplerate.Enabled = true;
                this.cboaudiobitrate.Enabled = true;

                this.radioWMVOutputType.Enabled = true;
                this.radioMP4OutputType.Enabled = true;
                this.cboH264profile.Enabled = true;

                this.btnpreview.Enabled = true;
                this.btncapture.Enabled = true;
                this.btnstop.Enabled = false;
                this.btnpause.Enabled = false;
                this.btnresume.Enabled = false;
                this.btnsnapshot.Enabled = false;
                this.btnzoomin.Enabled = false;
                this.btnzoomout.Enabled = false;
                this.btnfullscreen.Enabled = false;

            }
        }

        private void UpdateButton2(bool bEnable)
        {

            if (bEnable)
            {
                this.btnsnapshot.Enabled = true;
                this.btnzoomin.Enabled = true;
                this.btnzoomout.Enabled = true;
                this.btnfullscreen.Enabled = true;
            }
            else
            {
                this.btnsnapshot.Enabled = false;
                this.btnzoomin.Enabled = false;
                this.btnzoomout.Enabled = false;
                this.btnfullscreen.Enabled = false;

            }
        }

        private void onFormClosed(object sender, FormClosedEventArgs e)
        {
            _capture.Cleanup();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            cbooutputimage.Items.Add("Bmp");
            cbooutputimage.Items.Add("JPEG");
            cbooutputimage.Items.Add("PNG");
            cbooutputimage.Items.Add("GIF");
            cbooutputimage.Items.Add("TIF");
            cbooutputimage.SelectedIndex = 0;

           

         foreach (var item in Enum.GetValues(typeof(H264Profile)))
             cboH264profile.Items.Add(item);
         if (cboH264profile.Items.Count > 0)
            cboH264profile.SelectedIndex = 0;


        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            _capture.Stop();
            _capture.Window = pictureBox1.Handle;
            _capture.Mode = VideoCapture.CaptureMode.Preview;
              _capture.Start();

              UpdateButton(true);
        }

        private void cbovideodevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            VideoDevice vdevice = _devices.VideoDevices[cbovideodevice.SelectedIndex];
            _capture.VideoDevice = vdevice;

            cbovideoformat.Items.Clear();
            for (int i = 0; i < vdevice.VideoResolutions.Count; i++)
                cbovideoformat.Items.Add(vdevice.VideoResolutions[i].Name);

            if (cbovideoformat.Items.Count > 0)
                cbovideoformat.SelectedIndex = 0;
        }

        private void cbovideoformat_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (VideoResolution videoresolution in _capture.VideoDevice.VideoResolutions)
            {
                if (videoresolution.Name.Equals(cbovideoformat.SelectedItem.ToString()))
                {
                    _capture.VideoDevice.SelectedResolution =  videoresolution;

                    cboframerate.Items.Clear();
                    for (int i = videoresolution.MinFrameRate; i <= videoresolution.MaxFrameRate; i++)
                        cboframerate.Items.Add(i);

                    break;
                }
            }

            if (cboframerate.Items.Count > 0)
                cboframerate.SelectedIndex = 0;
        }

        private void cboframerate_SelectedIndexChanged(object sender, EventArgs e)
        {
            _capture.VideoDevice.FrameRate = (int)cboframerate.SelectedItem;
        }

        private void cboaudiodevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            AudioDevice device = _devices.AudioDevices[cboaudiodevice.SelectedIndex];
            _capture.AudioDevice = device;

            cboaudiosamplerate.Items.Clear();
            for (int i = 0; i < device.AudioSamplingRates.Count; i++)
                cboaudiosamplerate.Items.Add(device.AudioSamplingRates[i].Name);

            if (cboaudiosamplerate.Items.Count > 0)
                cboaudiosamplerate.SelectedIndex = 0;

            cboaudiobitrate.Items.Clear();

            foreach (int bitrate in _capture.Encoder.getSupportedAudioBitrates(device.AudioSamplingRates[0].SampleRate, device.AudioSamplingRates[0].Channels))
                cboaudiobitrate.Items.Add(bitrate);

            if (cboaudiobitrate.Items.Count > 0)
                cboaudiobitrate.SelectedIndex = 0;

        }

        private void btnsnapshot_Click(object sender, EventArgs e)
        {
            if(cbooutputimage.SelectedIndex==0)
             this.saveFileDialog1.Filter = "BMP File (*.bmp)|*.bmp";
            else if (cbooutputimage.SelectedIndex == 1)
                this.saveFileDialog1.Filter = "JPEG File (*.jpg)|*.jpg";
            else if (cbooutputimage.SelectedIndex == 2)
                this.saveFileDialog1.Filter = "PNG File (*.png)|*.png";
            else if (cbooutputimage.SelectedIndex == 3)
                this.saveFileDialog1.Filter = "GIF File (*.gif)|*.gif";
            else if (cbooutputimage.SelectedIndex == 4)
                this.saveFileDialog1.Filter = "TIF File (*.tif)|*.tif";


            if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
          
                _capture.Snapshot(saveFileDialog1.FileName, cbooutputimage.SelectedIndex);
            }
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            _capture.Stop();
            UpdateButton(false);
        }

        private void btnzoomin_Click(object sender, EventArgs e)
        {
            _capture.VideoDisplay.Zoom(ZoomType.ZoomIn);

            btnPanTop.Enabled = true;
            btnPanBottom.Enabled = true;
            btnPanLeft.Enabled = true;
            btnPanRight.Enabled = true;


        }

        private void btnzoomout_Click(object sender, EventArgs e)
        {
            _capture.VideoDisplay.Zoom(ZoomType.ZoomOut);

        }

        private void btnfullscreen_Click(object sender, EventArgs e)
        {
            _capture.VideoDisplay.FullScreen();
        }

        private void btnPanTop_Click(object sender, EventArgs e)
        {
            _capture.VideoDisplay.Pan(PanType.PanTop);
        }

        private void btnPanRight_Click(object sender, EventArgs e)
        {
            _capture.VideoDisplay.Pan(PanType.PanRight);
        }

        private void btnPanLeft_Click(object sender, EventArgs e)
        {
            _capture.VideoDisplay.Pan(PanType.PanLeft);
        }

        private void btnPanBottom_Click(object sender, EventArgs e)
        {
            _capture.VideoDisplay.Pan(PanType.PanBottom);
        }

        private void btncapture_Click(object sender, EventArgs e)
        {
            H264Profile profile = (H264Profile)cboH264profile.SelectedItem;

            if (profile == H264Profile.High)
            {

                if (!IsWindows8OrNewer())
                {
                    MessageBox.Show("H264 high profile support on windows 8 only");
                    return;
                }

            }

            if (radioWMVOutputType.Checked)
            {
                this.saveFileDialog1.Filter = "WMV File (*.wmv)|*.wmv";
                _capture.Encoder.OutputType = OutputType.WMV;
            }
            else
            {
                this.saveFileDialog1.Filter = "MP4 File (*.mp4)|*.mp4";
                _capture.Encoder.OutputType = OutputType.MP4;
            }
        
            if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                //when capture to wmv or mp4, make sure setup video frame rate, audio bitrate , video bitrate, otherwise it will failed
                 _capture.Stop();
                 _capture.OutputFile = saveFileDialog1.FileName;
                 
                _capture.Window = pictureBox1.Handle;
                _capture.Mode = VideoCapture.CaptureMode.Capture;
                _capture.Encoder.VideoBitrate = Int32.Parse(txtvideobitrate.Text);


                int iResult = _capture.Start();
                UpdateButton(true);

                if (iResult == -1)
                {
                    MessageBox.Show("Video device failed");
                }
                else if (iResult == -2)
                {
                    MessageBox.Show("Video Resolution failed");
                }
                else if (iResult == -3)
                {
                    MessageBox.Show("Audio device failed");
                }
                else if (iResult == -4)
                {
                    MessageBox.Show("Please enter the OutputFile");
                }
                else if (iResult == -5)
                {
                    MessageBox.Show("Video windows failed");
                }
                else if(iResult !=1)
                    MessageBox.Show("Error: 0x" + VideoCaptureFoundation.lastError().ToString("X"));


                
            }
        }
        private bool IsWindows8OrNewer()
        {
            var os = Environment.OSVersion;
            return os.Platform == PlatformID.Win32NT &&
                   (os.Version.Major > 6 || (os.Version.Major == 6 && os.Version.Minor >= 2));
        }

        private void cboH264profile_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            _capture.Encoder.H264Profile = (H264Profile)cboH264profile.SelectedItem;
        }

        private void radioWMVOutputType_CheckedChanged(object sender, EventArgs e)
        {
            if (radioWMVOutputType.Checked)
            {
                _capture.Encoder.OutputType = OutputType.WMV;
                refresh();
               
            }
        }

        private void radioMP4OutputType_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMP4OutputType.Checked)
            {
                _capture.Encoder.OutputType = OutputType.MP4;
                refresh();
            }
        }

        private void cboaudiobitrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            _capture.Encoder.AudioBitrate = (int)cboaudiobitrate.SelectedItem;
        }

        private void btnpause_Click(object sender, EventArgs e)
        {
            if (_capture.IsRunning)
            {
                _capture.Pause();
                UpdateButton2(false);
            }
        }

        private void btnresume_Click(object sender, EventArgs e)
        {
            if (_capture.IsPaused)
            {
                _capture.Resume();
                UpdateButton2(true);
            }
        }

        private void cboaudiosamplerate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

  

      
    }
}

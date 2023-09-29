using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing.Imaging;

namespace PBKK_230915_MediaCapture
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection perangkatRekam;
        private VideoCaptureDevice sumberVideo;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxWebcam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sumberVideo.IsRunning)
            {
                sumberVideo.SignalToStop();
                sumberVideo.WaitForStop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
            }

            sumberVideo = new VideoCaptureDevice(perangkatRekam[comboBoxWebcam.SelectedIndex].MonikerString);
            sumberVideo.NewFrame += new NewFrameEventHandler(SumberVideo_NewFrame);
            sumberVideo.Start();
        }

        private void SumberVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogSimpan = new SaveFileDialog();
            dialogSimpan.Title = "Simpan gambar";
            dialogSimpan.Filter = "File gambar (*.jpg, *.png) | *.jpg, *.png";
            ImageFormat formatGambar = ImageFormat.Png;

            if (dialogSimpan.ShowDialog() == DialogResult.OK)
            {
                string ekst = System.IO.Path.GetExtension(dialogSimpan.FileName);

                switch (ekst)
                {
                    case ".jpg":
                        formatGambar = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        formatGambar = ImageFormat.Png;
                        break;
                }

                pictureBox2.Image.Save(dialogSimpan.FileName, formatGambar);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            perangkatRekam = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo daftarPerangkat in perangkatRekam)
            {
                comboBoxWebcam.Items.Add(daftarPerangkat.Name);
            }

            comboBoxWebcam.SelectedIndex = 0;
            sumberVideo = new VideoCaptureDevice();
        }
    }
}
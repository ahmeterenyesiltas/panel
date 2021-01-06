using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panel
{
    public partial class kamera : Form
    {
        public kamera()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void button1_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
            pictureBox2.Image = (Bitmap)eventArgs.Frame.Clone();
            pictureBox3.Image = (Bitmap)eventArgs.Frame.Clone();
            pictureBox4.Image = (Bitmap)eventArgs.Frame.Clone();
            pictureBox5.Image = (Bitmap)eventArgs.Frame.Clone();
            pictureBox6.Image = (Bitmap)eventArgs.Frame.Clone();
            pictureBox7.Image = (Bitmap)eventArgs.Frame.Clone();
            pictureBox8.Image = (Bitmap)eventArgs.Frame.Clone();
            pictureBox9.Image = (Bitmap)eventArgs.Frame.Clone();
            pictureBox10.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void kamera_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            for (int i = 0; i < filterInfoCollection.Count; i++)
            {
                comboBox1.Items.Add(filterInfoCollection[i].Name);
            }
            videoCaptureDevice = new VideoCaptureDevice();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            videoCaptureDevice.Stop();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            videoCaptureDevice.SignalToStop();
            videoCaptureDevice.NewFrame -= VideoCaptureDevice_NewFrame;
            videoCaptureDevice = null;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            pictureBox10.Image = null;
        }

   
    }
}

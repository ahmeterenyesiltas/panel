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
    public partial class MediaPlayer : Form
    {
        public MediaPlayer()
        {
            InitializeComponent();
        }

        private void btnMediaAdd_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    listMedia.Items.Add(openFileDialog1.FileNames[i]);
                }
                if (listMedia.Items.Count > 0)
                {
                    listMedia.SelectedIndex = 0;
                }
            }
        }

        private void listMedia_DoubleClick(object sender, EventArgs e)
        {
            lblMedia.Text = listMedia.SelectedItem.ToString();
        }

        private void MediaPlayer_Load(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = listMedia.SelectedItem.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.URL = listMedia.SelectedItem.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btnPause_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void btnMediaDelete_Click(object sender, EventArgs e)
        {
            listMedia.Items.RemoveAt(listMedia.SelectedIndex);
        }


        private void btnMediaDown_Click(object sender, EventArgs e)
        {
            listMedia.SelectedIndex++;
            axWindowsMediaPlayer1.URL = listMedia.SelectedItem.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btnMediaUp_Click(object sender, EventArgs e)
        {
            listMedia.SelectedIndex--;
            axWindowsMediaPlayer1.URL = listMedia.SelectedItem.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btnVolumeUp_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume += 3;
        }

        private void btnVolumeDown_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume -= 3;
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastForward();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastReverse();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar2.Value;
           
            
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace panel
{
    public partial class formACHome : Form
    {
        public formACHome()
        {
            InitializeComponent();
        }

        private void formACHome_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void UptadeBackground(string Name)
        {

            try
            {
                foreach (var Control in panelLeftMenu.Controls)
                {
                    if (Control is Button)
                    {
                        var button = (Button)Control;

                        if (button.Name == Name)
                        {
                            button.BackColor = Color.Green;
                        }

                        else
                        {
                            button.BackColor = Color.DarkRed;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UptadeBackground(((Button)sender).Name);

                formCampaignAdd newForm = new formCampaignAdd();

                newForm.ShowDialog();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                UptadeBackground(((Button)sender).Name);

                formCampaignUpdate newForm = new formCampaignUpdate();

                newForm.ShowDialog();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                UptadeBackground(((Button)sender).Name);

                formCampaignDelete newForm = new formCampaignDelete();

                newForm.ShowDialog();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                UptadeBackground(((Button)sender).Name);

                formAnnouncementAdd newForm = new formAnnouncementAdd();

                newForm.ShowDialog();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                UptadeBackground(((Button)sender).Name);

                formAnnouncementUpdate newForm = new formAnnouncementUpdate();

                newForm.ShowDialog();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                UptadeBackground(((Button)sender).Name);

                formAnnouncementDelete newForm = new formAnnouncementDelete();

                newForm.ShowDialog();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                lblTitle.Text = "Campaign Details";



                Campaign C1 = new Campaign();

                dataGridViewDATA.DataSource = C1.GetAllCampaign();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                lblTitle.Text = "Announcement Details";



                Announcement A1 = new Announcement();

                dataGridViewDATA.DataSource = A1.GetAllAnnouncement();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

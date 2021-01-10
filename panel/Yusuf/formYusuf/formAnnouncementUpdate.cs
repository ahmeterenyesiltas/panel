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
    public partial class formAnnouncementUpdate : Form
    {
        public formAnnouncementUpdate()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                labelMessage.Text = "";

                labelMessage.ForeColor = Color.Black;

                int announcementID = int.Parse(tBID.Text);

                string announcementName = tBName.Text;

                string announcementText = rTBText.Text;

                if (string.IsNullOrWhiteSpace(Name))
                {
                    //tBName.Focus();

                    throw new Exception("Announcement Name cannot be EMPTY!");
                }

                Announcement A1 = new Announcement();
                A1.AnnouncementID = announcementID;
                A1.AnnouncementName = announcementName;
                A1.AnnouncementText = announcementText;

                int Result = A1.UpdateAnnouncement(A1);

                if (Result > 0)
                {
                    labelMessage.Text = "Announcement Updated!";

                    labelMessage.ForeColor = Color.Green;
                }

            }
            catch (Exception Ex)
            {

                labelMessage.Text = Ex.Message;

                labelMessage.ForeColor = Color.Red;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

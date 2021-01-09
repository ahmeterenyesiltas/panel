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
    public partial class formAnnouncementAdd : Form
    {
        public formAnnouncementAdd()
        {
            InitializeComponent();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                labelMessage.Text = "";

                labelMessage.ForeColor = Color.Black;

                string Name = tBName.Text;

                string Text = rTBText.Text;

                if (string.IsNullOrWhiteSpace(Name))
                {
                    tBName.Focus();

                    throw new Exception("Announcement Name cannot be EMPTY!");
                }

                Announcement A1 = new Announcement();
                A1.AnnouncementName = Name;
                A1.AnnouncementText = Text;

                int Result = A1.AddAnnouncement(A1);

                if (Result > 0)
                {
                    labelMessage.Text = "Announcement Added!";

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

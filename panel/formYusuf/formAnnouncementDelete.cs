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
    public partial class formAnnouncementDelete : Form
    {
        public formAnnouncementDelete()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                labelMessage.Text = "";

                labelMessage.ForeColor = Color.Black;

                int announcementID = int.Parse(tBAnnouncementID.Text);

                if (announcementID == 0)
                {
                    tBAnnouncementID.Focus();

                    throw new Exception("Announcement ID cannot be EMPTY!");
                }

                Announcement A1 = new Announcement();
                A1.AnnouncementID = announcementID;


                int Result = A1.DeleteAnnouncement(A1.AnnouncementID);

                if (Result > 0)
                {
                    labelMessage.Text = "Announcement Deleted!";

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

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
    public partial class formCampaignDelete : Form
    {
        public formCampaignDelete()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                labelMessage.Text = "";

                labelMessage.ForeColor = Color.Black;

                int campaignID = int.Parse(tBCampaignID.Text);

                if (campaignID == 0)
                {
                    tBCampaignID.Focus();

                    throw new Exception("Campaign ID cannot be EMPTY!");
                }

                Campaign C1 = new Campaign();
                C1.CampaignID = campaignID;
                

                int Result = C1.DeleteCampaign(C1.CampaignID);

                if (Result > 0)
                {
                    labelMessage.Text = "Campaign Deleted!";

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

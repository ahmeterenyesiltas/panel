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
    public partial class formCampaignUpdate : Form
    {
        public formCampaignUpdate()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                labelMessage.Text = "";

                labelMessage.ForeColor = Color.Black;

                int campaignID = int.Parse(tBID.Text);

                string campaignName = tBName.Text;

                int discountRate = (int)nUDDiscount.Value;
                
                if (string.IsNullOrWhiteSpace(campaignName))
                {
                    tBName.Focus();

                    throw new Exception("Campaign Name cannot be EMPTY!");
                }

                Campaign C1 = new Campaign();

                C1.CampaignID = campaignID;
                C1.CampaignName = campaignName;
                C1.DiscountRate = discountRate;

                int Result = C1.UpdateCampaign(C1);

                if (Result > 0)
                {
                    labelMessage.Text = "Campaign Updated!";

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

        private void tBID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

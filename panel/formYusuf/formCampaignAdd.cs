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
    public partial class formCampaignAdd : Form
    {
        public formCampaignAdd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                labelMessage.Text = "";

                labelMessage.ForeColor = Color.Black;

                string campaignName = tBName.Text;

                int discountRate = (int)nUDDiscount.Value;

                DateTime startDate = dTPStart.Value;

                DateTime finishDate = dTPFinish.Value;

                if (string.IsNullOrWhiteSpace(campaignName))
                {
                    tBName.Focus();

                    throw new Exception("Campaign Name cannot be EMPTY!");
                }

                Campaign C1 = new Campaign();
                C1.CampaignName = campaignName;
                C1.DiscountRate = discountRate;
                C1.StartDate = startDate;
                C1.FinishDate = finishDate;

                int Result = C1.AddCampaign(C1);

                if (Result > 0)
                {
                    labelMessage.Text = "Campaign Added!";

                    labelMessage.ForeColor = Color.Green;
                }

            }
            catch (Exception Ex)
            {

                labelMessage.Text = Ex.Message;

                labelMessage.ForeColor = Color.Red;
            }
        }
    }
}

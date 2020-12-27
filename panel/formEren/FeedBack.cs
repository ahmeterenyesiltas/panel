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
    public partial class FeedBack : Form
    {
        public FeedBack()
        {
            InitializeComponent();
        }

        private void RateBtn_Click(object sender, EventArgs e)
        {
            if (Radiobtn1.Checked)
            {
                StarBtn1.BackColor = Color.Green;
                StarBtn2.BackColor = Color.Red;
                StarBtn3.BackColor = Color.Red;
                StarBtn4.BackColor = Color.Red;
                StarBtn5.BackColor = Color.Red;
                
            }
            if (Radiobtn2.Checked)
            {
                StarBtn1.BackColor = Color.Green;
                StarBtn2.BackColor = Color.Green;
                StarBtn3.BackColor = Color.Red;
                StarBtn4.BackColor = Color.Red;
                StarBtn5.BackColor = Color.Red;

            }
            if (Radiobtn3.Checked)
            {
                StarBtn1.BackColor = Color.Green;
                StarBtn2.BackColor = Color.Green;
                StarBtn3.BackColor = Color.Green;
                StarBtn4.BackColor = Color.Red;
                StarBtn5.BackColor = Color.Red;

            }
            if (Radiobtn4.Checked)
            {
                StarBtn1.BackColor = Color.Green;
                StarBtn2.BackColor = Color.Green;
                StarBtn3.BackColor = Color.Green;
                StarBtn4.BackColor = Color.Green;
                StarBtn5.BackColor = Color.Red;

            }
            if (Radiobtn5.Checked)
            {
                StarBtn1.BackColor = Color.Green;
                StarBtn2.BackColor = Color.Green;
                StarBtn3.BackColor = Color.Green;
                StarBtn4.BackColor = Color.Green;
                StarBtn5.BackColor = Color.Green;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int point = (int)numericUpDown1.Value;        //Numeric updown Decimal türünden değer veriyor o yüzden inte çevirip öyle kullandım ve altta yazdırdım

            lblPoint.Text = "Your Point is: " + point+" Thank you for rating us";
            lblPoint.ForeColor = Color.Green;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            FeedBackSQL feedBack = new FeedBackSQL();
            feedBack.ShowDialog();


        }
    }
}

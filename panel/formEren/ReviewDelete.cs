using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panel.formEren
{
    public partial class ReviewDelete : Form
    {
        public ReviewDelete()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                var result = MessageBox.Show("Are you sure to delete ?", "System Message", MessageBoxButtons.YesNo);

                int ID = int.Parse(tbID.Text.ToString()); //TextBoxdan aldığım ID yi yolluyorum bu sayede

                if (result == DialogResult.Yes)
                {
                    FeedBacks feedback = new FeedBacks();
                    var x = feedback.FeedBackDelete(ID);

                    if (x > 0)
                    {
                        lblMessage.Text = "FeedBack Deleted Succesfully";
                        lblMessage.ForeColor = Color.White;
                        
                    }
                    else
                    {
                        MessageBox.Show("Course NOT Deleted.");
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

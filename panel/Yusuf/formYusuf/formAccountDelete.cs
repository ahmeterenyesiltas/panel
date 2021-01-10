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
    public partial class formAccountDelete : Form
    {
        public formAccountDelete()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                labelMessage.Text = "";

                labelMessage.ForeColor = Color.Black;

                int entryID = int.Parse(tBAccountID.Text);

                if (entryID == 0)
                {
                    tBAccountID.Focus();

                    throw new Exception("Account ID cannot be NEGATIVE!");
                }

                Accounting A1 = new Accounting();
                A1.EntryID = entryID;

                int Result = A1.DeleteAccount(entryID);

                if (Result > 0)
                {
                    labelMessage.Text = "Account Deleted!";

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

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
    public partial class formAccountAdd : Form
    {
        public formAccountAdd()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            //string entryName;

            //string entryMType;

            //string entryType;

            //float entryAmount;

            try
            {
                labelMessage.Text = "";

                labelMessage.ForeColor = Color.Black;

                string entryName = tBEntryName.Text;

                string entryMType = cBEntryMainType.Text;

                string entryType = tBEntryType.Text;

                float entryAmount = float.Parse(tBEntryAmount.Text);

                if (string.IsNullOrWhiteSpace(entryAmount.ToString()))
                {
                    tBEntryName.Focus();

                    throw new Exception("Entry Amount cannot be EMPTY!");
                }
                //.
                //.
                //.

                Accounting A1 = new Accounting();
                A1.EntryAmount = entryAmount;
                A1.EntryName = entryName;
                A1.EntryMType = entryMType;
                A1.EntryType = entryMType;

                int Result = A1.AddAccount(A1);

                if (Result > 0)
                {
                    labelMessage.Text = "Account Added!";

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

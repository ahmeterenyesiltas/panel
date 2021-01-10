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
    public partial class formAccountUpdate : Form
    {
        public formAccountUpdate()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //int entryID;

            //string entryName;

            //string entryMType;

            //string entryType;

            //float entryAmount;

            try
            {
                labelMessage.Text = "";

                labelMessage.ForeColor = Color.Black;

                int entryID = int.Parse(tBEntryID.Text);

                string entryName = tBEntryName.Text;

                string entryMType = cBEntryMainType.Text;

                string entryType = tBEntryType.Text;

                float entryAmount = float.Parse(tBEntryAmount.Text);

                if (string.IsNullOrWhiteSpace(entryAmount.ToString()))
                {
                    tBEntryName.Focus();

                    throw new Exception("Entry Amount cannot be EMPTY!");
                }



                Accounting A1 = new Accounting();
                A1.EntryID = entryID;
                A1.EntryName = entryName;
                A1.EntryMType = entryMType;
                A1.EntryType = entryType;
                A1.EntryAmount = entryAmount;

                int Result = A1.UpdateAccount(A1);

                if (Result > 0)
                {
                    labelMessage.Text = "Account Updated!";

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

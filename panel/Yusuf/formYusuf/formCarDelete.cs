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
    public partial class formCarDelete : Form
    {
        public formCarDelete()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                labelMessage.Text = "";

                labelMessage.ForeColor = Color.Black;

                int carID = int.Parse(tBCarID.Text);

                if (carID == 0)
                {
                    tBCarID.Focus();

                    throw new Exception("Car ID cannot be NEGATIVE!");
                }

                Car C1 = new Car();
                C1.CarID = carID;

                int Result = C1.DeleteCar(C1.CarID);

                if (Result > 0)
                {
                    labelMessage.Text = "Car Deleted!";

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

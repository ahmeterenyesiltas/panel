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
    public partial class formCarAdd : Form
    {
        public formCarAdd()
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

                int parkingNo = (int)nUDParkingNo.Value;

                string numberPlate = tBNumberPlate.Text;

                float hourRate = float.Parse(tBHourRate.Text);

                DateTime startTime = dTPStart.Value;

                DateTime finishTime = dTPFinish.Value;

                if (string.IsNullOrWhiteSpace(numberPlate))
                {
                    tBNumberPlate.Focus();

                    throw new Exception("Number Plate cannot be EMPTY!");
                }

                Car C1 = new Car();
                C1.ParkingNo = parkingNo;
                C1.NumberPlate = numberPlate;
                C1.HourRate = hourRate;
                C1.StartTime = startTime;
                C1.FinishTime = finishTime;

                int Result = C1.AddCar(C1);

                if (Result > 0)
                {
                    labelMessage.Text = "Car Added!";

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

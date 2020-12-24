using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panel
{
    public partial class ilkform : Form
    {
        public ilkform()
        {
            InitializeComponent();
        }
        public void verial() {
            string conString = "Server=EKOSR;Database=gorselodev;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
}
     
        private void btnMasaBos_Click(object sender, EventArgs e)
        {
            if (checkBoxMasa1.Checked)
            {
                btnMasa1.BackColor = Color.Green;
                lblMasa1.BackColor = Color.Green;
                checkBoxMasa1.Text = "Boş";
                checkBoxMasa1.Checked = false;
            }
            if (checkBoxMasa2.Checked)
            {
                btnMasa2.BackColor = Color.Green;
                lblMasa2.BackColor = Color.Green;
                checkBoxMasa2.Text = "Boş";
                checkBoxMasa2.Checked = false;
            }
            if (checkBoxMasa3.Checked)
            {
                btnMasa3.BackColor = Color.Green;
                lblMasa3.BackColor = Color.Green;
                checkBoxMasa3.Text = "Boş";
                checkBoxMasa3.Checked = false;
            }
            if (checkBoxMasa4.Checked)
            {
                btnMasa4.BackColor = Color.Green;
                lblMasa4.BackColor = Color.Green;
                checkBoxMasa4.Text = "Boş";
                checkBoxMasa4.Checked = false;
            }
            if (checkBoxMasa5.Checked)
            {
                btnMasa5.BackColor = Color.Green;
                lblMasa5.BackColor = Color.Green;
                checkBoxMasa5.Text = "Boş";
                checkBoxMasa5.Checked = false;
            }
            if (checkBoxMasa6.Checked)
            {
                btnMasa6.BackColor = Color.Green;
                lblMasa6.BackColor = Color.Green;
                checkBoxMasa6.Text = "Boş";
                checkBoxMasa6.Checked = false;
            }
            if (checkBoxMasa7.Checked)
            {
                btnMasa7.BackColor = Color.Green;
                lblMasa7.BackColor = Color.Green;
                checkBoxMasa7.Text = "Boş";
                checkBoxMasa7.Checked = false;
            }
            if (checkBoxMasa8.Checked)
            {
                btnMasa8.BackColor = Color.Green;
                lblMasa8.BackColor = Color.Green;
                checkBoxMasa8.Text = "Boş";
                checkBoxMasa8.Checked = false;
            }
            if (checkBoxMasa9.Checked)
            {
                btnMasa9.BackColor = Color.Green;
                lblMasa9.BackColor = Color.Green;
                checkBoxMasa9.Text = "Boş";
                checkBoxMasa9.Checked = false;
            }
            if (checkBoxMasa10.Checked)
            {
                btnMasa10.BackColor = Color.Green;
                lblMasa10.BackColor = Color.Green;
                checkBoxMasa10.Text = "Boş";
                checkBoxMasa10.Checked = false;
            }
            if (checkBoxMasa11.Checked)
            {
                btnMasa11.BackColor = Color.Green;
                lblMasa11.BackColor = Color.Green;
                checkBoxMasa11.Text = "Boş";
                checkBoxMasa11.Checked = false;
            }
            if (checkBoxMasa12.Checked)
            {
                btnMasa12.BackColor = Color.Green;
                lblMasa12.BackColor = Color.Green;
                checkBoxMasa12.Text = "Boş";
                checkBoxMasa12.Checked = false;
            }
            if (checkBoxMasa13.Checked)
            {
                btnMasa13.BackColor = Color.Green;
                lblMasa13.BackColor = Color.Green;
                checkBoxMasa13.Text = "Boş";
                checkBoxMasa13.Checked = false;
            }
            if (checkBoxMasa14.Checked)
            {
                btnMasa14.BackColor = Color.Green;
                lblMasa14.BackColor = Color.Green;
                checkBoxMasa14.Text = "Boş";
                checkBoxMasa14.Checked = false;
            }
        }

        private void btnMasaDolu_Click(object sender, EventArgs e)
        {
            if (checkBoxMasa1.Checked)
            {
                btnMasa1.BackColor = Color.Red;
                lblMasa1.BackColor = Color.Red;
                checkBoxMasa1.Text = "Dolu";
                checkBoxMasa1.Checked = false;
            }
            if (checkBoxMasa2.Checked)
            {
                btnMasa2.BackColor = Color.Red;
                lblMasa2.BackColor = Color.Red;
                checkBoxMasa2.Text = "Dolu";
                checkBoxMasa2.Checked = false;
            }
            if (checkBoxMasa3.Checked)
            {
                btnMasa3.BackColor = Color.Red;
                lblMasa3.BackColor = Color.Red;
                checkBoxMasa3.Text = "Dolu";
                checkBoxMasa3.Checked = false;
            }
            if (checkBoxMasa4.Checked)
            {
                btnMasa4.BackColor = Color.Red;
                lblMasa4.BackColor = Color.Red;
                checkBoxMasa4.Text = "Dolu";
                checkBoxMasa4.Checked = false;
            }
            if (checkBoxMasa5.Checked)
            {
                btnMasa5.BackColor = Color.Red;
                lblMasa5.BackColor = Color.Red;
                checkBoxMasa5.Text = "Dolu";
                checkBoxMasa5.Checked = false;
            }
            if (checkBoxMasa6.Checked)
            {
                btnMasa6.BackColor = Color.Red;
                lblMasa6.BackColor = Color.Red;
                checkBoxMasa6.Text = "Dolu";
                checkBoxMasa6.Checked = false;
            }
            if (checkBoxMasa7.Checked)
            {
                btnMasa7.BackColor = Color.Red;
                lblMasa7.BackColor = Color.Red;
                checkBoxMasa7.Text = "Dolu";
                checkBoxMasa7.Checked = false;
            }
            if (checkBoxMasa8.Checked)
            {
                btnMasa8.BackColor = Color.Red;
                lblMasa8.BackColor = Color.Red;
                checkBoxMasa8.Text = "Dolu";
                checkBoxMasa8.Checked = false;
            }
            if (checkBoxMasa9.Checked)
            {
                btnMasa9.BackColor = Color.Red;
                lblMasa9.BackColor = Color.Red;
                checkBoxMasa9.Text = "Dolu";
                checkBoxMasa9.Checked = false;
            }
            if (checkBoxMasa10.Checked)
            {
                btnMasa10.BackColor = Color.Red;
                lblMasa10.BackColor = Color.Red;
                checkBoxMasa10.Text = "Dolu";
                checkBoxMasa10.Checked = false;
            }
            if (checkBoxMasa11.Checked)
            {
                btnMasa11.BackColor = Color.Red;
                lblMasa11.BackColor = Color.Red;
                checkBoxMasa11.Text = "Dolu";
                checkBoxMasa11.Checked = false;
            }
            if (checkBoxMasa12.Checked)
            {
                btnMasa12.BackColor = Color.Red;
                lblMasa12.BackColor = Color.Red;
                checkBoxMasa12.Text = "Dolu";
                checkBoxMasa12.Checked = false;
            }
            if (checkBoxMasa13.Checked)
            {
                btnMasa13.BackColor = Color.Red;
                lblMasa13.BackColor = Color.Red;
                checkBoxMasa13.Text = "Dolu";
                checkBoxMasa13.Checked = false;
            }
            if (checkBoxMasa14.Checked)
            {
                btnMasa14.BackColor = Color.Red;
                lblMasa14.BackColor = Color.Red;
                checkBoxMasa14.Text = "Dolu";
                checkBoxMasa14.Checked = false;
            }


        }

        private void btnMasaRezerve_Click(object sender, EventArgs e)
        {
            if (checkBoxMasa1.Checked)
            {
                btnMasa1.BackColor = Color.Blue;
                lblMasa1.BackColor = Color.Blue;
                checkBoxMasa1.Text = "Rezerve";
                checkBoxMasa1.Checked = false;
            }
            if (checkBoxMasa2.Checked)
            {
                btnMasa2.BackColor = Color.Blue;
                lblMasa2.BackColor = Color.Blue;
                checkBoxMasa2.Text = "Rezerve";
                checkBoxMasa2.Checked = false;
            }
            if (checkBoxMasa3.Checked)
            {
                btnMasa3.BackColor = Color.Blue;
                lblMasa3.BackColor = Color.Blue;
                checkBoxMasa3.Text = "Rezerve";
                checkBoxMasa3.Checked = false;
            }
            if (checkBoxMasa4.Checked)
            {
                btnMasa4.BackColor = Color.Blue;
                lblMasa4.BackColor = Color.Blue;
                checkBoxMasa4.Text = "Rezerve";
                checkBoxMasa4.Checked = false;
            }
            if (checkBoxMasa5.Checked)
            {
                btnMasa5.BackColor = Color.Blue;
                lblMasa5.BackColor = Color.Blue;
                checkBoxMasa5.Text = "Rezerve";
                checkBoxMasa5.Checked = false;
            }
            if (checkBoxMasa6.Checked)
            {
                btnMasa6.BackColor = Color.Blue;
                lblMasa6.BackColor = Color.Blue;
                checkBoxMasa6.Text = "Rezerve";
                checkBoxMasa6.Checked = false;
            }
            if (checkBoxMasa7.Checked)
            {
                btnMasa7.BackColor = Color.Blue;
                lblMasa7.BackColor = Color.Blue;
                checkBoxMasa7.Text = "Rezerve";
                checkBoxMasa7.Checked = false;
            }
            if (checkBoxMasa8.Checked)
            {
                btnMasa8.BackColor = Color.Blue;
                lblMasa8.BackColor = Color.Blue;
                checkBoxMasa8.Text = "Rezerve";
                checkBoxMasa8.Checked = false;
            }
            if (checkBoxMasa9.Checked)
            {
                btnMasa9.BackColor = Color.Blue;
                lblMasa9.BackColor = Color.Blue;
                checkBoxMasa9.Text = "Rezerve";
                checkBoxMasa9.Checked = false;
            }
            if (checkBoxMasa10.Checked)
            {
                btnMasa10.BackColor = Color.Blue;
                lblMasa10.BackColor = Color.Blue;
                checkBoxMasa10.Text = "Rezerve";
                checkBoxMasa10.Checked = false;
            }
            if (checkBoxMasa11.Checked)
            {
                btnMasa11.BackColor = Color.Blue;
                lblMasa11.BackColor = Color.Blue;
                checkBoxMasa11.Text = "Rezerve";
                checkBoxMasa11.Checked = false;
            }
            if (checkBoxMasa12.Checked)
            {
                btnMasa12.BackColor = Color.Blue;
                lblMasa12.BackColor = Color.Blue;
                checkBoxMasa12.Text = "Rezerve";
                checkBoxMasa12.Checked = false;
            }
            if (checkBoxMasa13.Checked)
            {
                btnMasa13.BackColor = Color.Blue;
                lblMasa13.BackColor = Color.Blue;
                checkBoxMasa13.Text = "Rezerve";
                checkBoxMasa13.Checked = false;
            }
            if (checkBoxMasa14.Checked)
            {
                btnMasa14.BackColor = Color.Blue;
                lblMasa14.BackColor = Color.Blue;
                checkBoxMasa14.Text = "Rezerve";
                checkBoxMasa14.Checked = false;
            }


        }

        private void btnMasaKapalı_Click(object sender, EventArgs e)
        {


            if (checkBoxMasa1.Checked)
            {
                btnMasa1.BackColor = Color.White;
                lblMasa1.BackColor = Color.Maroon;
                checkBoxMasa1.Text = "KAPALI";
                checkBoxMasa1.Checked = false;
            }
            if (checkBoxMasa2.Checked)
            {
                btnMasa2.BackColor = Color.White;
                lblMasa2.BackColor = Color.Maroon;
                checkBoxMasa2.Text = "KAPALI";
                checkBoxMasa2.Checked = false;
            }
            if (checkBoxMasa3.Checked)
            {
                btnMasa3.BackColor = Color.White;
                lblMasa3.BackColor = Color.Maroon;
                checkBoxMasa3.Text = "KAPALI";
                checkBoxMasa3.Checked = false;
            }
            if (checkBoxMasa4.Checked)
            {
                btnMasa4.BackColor = Color.White;
                lblMasa4.BackColor = Color.Maroon;
                checkBoxMasa4.Text = "KAPALI";
                checkBoxMasa4.Checked = false;
            }
            if (checkBoxMasa5.Checked)
            {
                btnMasa5.BackColor = Color.White;
                lblMasa5.BackColor = Color.Maroon;
                checkBoxMasa5.Text = "KAPALI";
                checkBoxMasa5.Checked = false;
            }
            if (checkBoxMasa6.Checked)
            {
                btnMasa6.BackColor = Color.White;
                lblMasa6.BackColor = Color.Maroon;
                checkBoxMasa6.Text = "KAPALI";
                checkBoxMasa6.Checked = false;
            }
            if (checkBoxMasa7.Checked)
            {
                btnMasa7.BackColor = Color.White;
                lblMasa7.BackColor = Color.Maroon;
                checkBoxMasa7.Text = "KAPALI";
                checkBoxMasa7.Checked = false;
            }
            if (checkBoxMasa8.Checked)
            {
                btnMasa8.BackColor = Color.White;
                lblMasa8.BackColor = Color.Maroon;
                checkBoxMasa8.Text = "KAPALI";
                checkBoxMasa8.Checked = false;
            }
            if (checkBoxMasa9.Checked)
            {
                btnMasa9.BackColor = Color.White;
                lblMasa9.BackColor = Color.Maroon;
                checkBoxMasa9.Text = "KAPALI";
                checkBoxMasa9.Checked = false;
            }
            if (checkBoxMasa10.Checked)
            {
                btnMasa10.BackColor = Color.White;
                lblMasa10.BackColor = Color.Maroon;
                checkBoxMasa10.Text = "KAPALI";
                checkBoxMasa10.Checked = false;
            }
            if (checkBoxMasa11.Checked)
            {
                btnMasa11.BackColor = Color.White;
                lblMasa11.BackColor = Color.Maroon;
                checkBoxMasa11.Text = "KAPALI";
                checkBoxMasa11.Checked = false;
            }
            if (checkBoxMasa12.Checked)
            {
                btnMasa12.BackColor = Color.White;
                lblMasa12.BackColor = Color.Maroon;
                checkBoxMasa12.Text = "KAPALI";
                checkBoxMasa12.Checked = false;
            }
            if (checkBoxMasa13.Checked)
            {
                btnMasa13.BackColor = Color.White;
                lblMasa13.BackColor = Color.Maroon;
                checkBoxMasa13.Text = "KAPALI";
                checkBoxMasa13.Checked = false;
            }
            if (checkBoxMasa14.Checked)
            {
                btnMasa14.BackColor = Color.White;
                lblMasa14.BackColor = Color.Maroon;
                checkBoxMasa14.Text = "KAPALI";
                checkBoxMasa14.Checked = false;
            }

        }

        private void ilkform_Load(object sender, EventArgs e)
        {

        }
    }
}

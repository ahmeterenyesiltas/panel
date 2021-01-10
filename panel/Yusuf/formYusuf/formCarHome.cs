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
    public partial class formCarHome : Form
    {
        public formCarHome()
        {
            InitializeComponent();
        }
        private void formCarHome_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void UptadeBackground(string Name)
        {

            try
            {
                foreach (var Control in panelLeftMenu.Controls)
                {
                    if (Control is Button)
                    {
                        var button = (Button)Control;

                        if (button.Name == Name)
                        {
                            button.BackColor = Color.RoyalBlue;
                        }

                        else
                        {
                            button.BackColor = Color.MidnightBlue;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UptadeBackground(((Button)sender).Name);
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                UptadeBackground(((Button)sender).Name);
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                UptadeBackground(((Button)sender).Name);
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                UptadeBackground(((Button)sender).Name);
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                UptadeBackground(((Button)sender).Name);
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                UptadeBackground(((Button)sender).Name);
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                lblTitle.Text = "Car Details";



                Car C1 = new Car();

                dataGridViewDATA.DataSource = C1.GetAllCar();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                formCarAdd newForm = new formCarAdd();

                newForm.ShowDialog();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {

                formCarUpdate newForm = new formCarUpdate();

                newForm.ShowDialog();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {

                formCarDelete newForm = new formCarDelete();

                newForm.ShowDialog();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }
    }
}

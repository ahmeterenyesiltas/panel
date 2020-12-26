using panel.Models;
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
    public partial class PersonelDelete : Form
    {
        public PersonelDelete()
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
                    Employee emp = new Employee();
                    var x = emp.EmployeeDelete(ID);

                    if (x > 0)
                    {
                        lblMessage.Text = "Employee Deleted Succesfully";
                        lblMessage.ForeColor = Color.Green;
                                   //silindikten sonraki halini görmek için direkt olarak
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

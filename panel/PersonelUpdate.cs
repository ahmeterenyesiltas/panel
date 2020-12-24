
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
    public partial class PersonelUpdate : Form
    {

        //Course course=null;
        Employee employee = null;


        public PersonelUpdate(Employee e)     //burda başlar başlamaz id yi yazdırmak için parametre aldık constructora kendi classının 
        {
            InitializeComponent();
            
            employee = e;
        }

        private void formCourseEdit_Load(object sender, EventArgs e)  //LOAD EVENTİ FORMUN EVENTLERDEN AÇTIK FORM BAŞLAR BAŞLAMAZ DEDİĞİMİZİ YAPMASI İÇİN KULLANIYORUZ
        {
            try
            {
                //if (course != null)
                //{
                //    tbCourseID.Text = course.CourseID.ToString();        //BU 3 Ü DEFAULT OLARAK BİLGİLERİ YAZDIRICAK COURSEUN
                //    tbName.Text = course.Name;
                //    nudCredit.Value = course.Credit;
                //}

                if(employee != null)
                {
                    tbCourseID.Text = employee.EmployeeID.ToString();
                    //tbFirstName.Text = employee.Firstname.ToString();
                    //tbLastName.Text = employee.LastName.ToString();
                    //tbEmail.Text = employee.Email1.ToString();
                    //tbPassword.Text = employee.Password1.ToString();
                    //tbSalary.Text = employee.Salary.ToString();
                    //tbGender.Text = employee.Gender1.ToString();
                    //tbDepartmentID.Text = employee.DepartmentID1.ToString();
;
                       
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            try
            {
                lblMessage.Text = "";
                lblMessage.ForeColor = Color.Black;     //başlarken message lbli boş tanımladık

                string Firstname = tbFirstName.Text.Trim();

                if (string.IsNullOrWhiteSpace(Firstname))
                {
                    tbFirstName.Focus();
                    throw new Exception("First Name Cannot be empty");
                }

                string LastName = tbLastName.Text.Trim();

                if (string.IsNullOrWhiteSpace(LastName))
                {
                    tbFirstName.Focus();
                    throw new Exception("Last Name Cannot be empty");
                }

                string Email = tbEmail.Text.Trim();

                if (string.IsNullOrWhiteSpace(Email))
                {
                    tbEmail.Focus();
                    throw new Exception(" Email Cannot be empty");
                }

                string Password = tbPassword.Text.Trim();

                if (string.IsNullOrWhiteSpace(Password))
                {
                    tbPassword.Focus();
                    throw new Exception("Password Cannot be empty");
                }

                float Salary =float.Parse(tbSalary.Text.Trim());

                if (Salary<0)
                {
                    tbSalary.Focus();
                    throw new Exception("Salary Cannot be less than 0");
                }

                string Gender = label9.Text.Trim();

                if (string.IsNullOrWhiteSpace(Gender))
                {
                    label9.Focus();
                    throw new Exception("Gender Cannot be empty");
                }

                int DepartmentID = int.Parse(tbDepartmentID.Text.Trim());

                if (DepartmentID<1000 && DepartmentID>1004)
                {
                    tbDepartmentID.Focus();
                    throw new Exception("Department ID must be between 1000 1004");
                }

                Employee emp = new Employee();
                emp.EmployeeID = employee.EmployeeID;
                emp.Firstname = Firstname;
                emp.Lastname = LastName;
                emp.Email1 = Email;
                emp.Password1 = Password;
                emp.Salary = Salary;
                emp.Gender1 = Gender;
                emp.DepartmentID1 = DepartmentID;

               

                var result = emp.EmployeeUpdate(emp);

                if (result > 0)
                {
                    lblMessage.Text = "Employee Updated Succesfully.";
                    lblMessage.ForeColor = Color.Green;

                }

            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
                lblMessage.ForeColor = Color.Red;
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
            tbSalary.Text = "";
            tbGender.Text = "";
            tbDepartmentID.Text = "";


        }
    }
}

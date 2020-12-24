
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
    public partial class PersonelAdd : Form
    {
       
        private void PersonelAdd_Load(object sender, EventArgs e)
        {

        }


        public PersonelAdd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
                                                                //ADD BUTTON
        private void button1_Click(object sender, EventArgs e) 
        {
            try
            {                            
                lblMessage.Text = "";
                lblMessage.ForeColor = Color.Black;

                string Firstname = tbFirstName.Text.Trim();     //burda yazılan değeri kullanıcıdan isim olarak arakladık altta ekliyoruz bunu yazdığımız class ve fonksiyon ile
                string Lastname = tbLastName.Text.Trim();
                string Email = tbEmail.Text.Trim();
                string Password = tbPassword.Text.Trim();
                float Salary = float.Parse(tbSalary.Text.ToString());
                string Gender = tbGender.Text.Trim();
                int DepartmentID = int.Parse(tbDepartmentID.Text.ToString());
                
                //int credit = (int)nudCredit.Value;    //aynı şekilde burdada credit için aynı işlemi yapıp altta atıyoruz add butonuna basılınca

                if (string.IsNullOrWhiteSpace(Firstname))
                {
                    tbFirstName.Focus();
                    throw new Exception("First name is empty");
                }
                if (string.IsNullOrWhiteSpace(Lastname))
                {
                    tbLastName.Focus();
                    throw new Exception("Lastname  is empty");
                }
                if (string.IsNullOrWhiteSpace(Email))
                {
                    tbEmail.Focus();
                    throw new Exception("Email is empty");
                }

                if (string.IsNullOrWhiteSpace(Password))
                {
                    tbPassword.Focus();
                    throw new Exception("Password is empty");
                }
                if (Salary<0)
                {
                    tbSalary.Focus();
                    throw new Exception("Salary  is cannot less than 0 ");
                }
                if (string.IsNullOrWhiteSpace(Gender))
                {
                    tbGender.Focus();
                    throw new Exception("Gender is empty");
                }
                if (DepartmentID<1000 && DepartmentID>1004)
                {
                    tbFirstName.Focus();
                    throw new Exception("Department Id must be between 1000 and 1004");
                }

                Employee obj = new Employee();
                obj.Firstname = Firstname;
                obj.Lastname = Lastname;
                obj.Email1 = Email;
                obj.Password1 = Password;
                obj.Salary = Salary;
                obj.Gender1 = Gender;
                obj.DepartmentID1 = DepartmentID;

               int result= obj.EmployeeAdd(obj);  //Burda istedigimiz int deger vardi ekleme fonksiyonunda onu result ile gonderiyoruz

                if (result > 0)
                {
                    lblMessage.Text = "Employee Added Successfully";
                    lblMessage.ForeColor = Color.Green;
                }

                //obj.Credit = credit;       //bu sayı seçmeli kutunun değeri kredi almıştık onun şeyi

               //int result= obj.CourseAdd(obj);
               
               // if (result > 0)   //Burda control yapıyoruz resulta gerek yoktu ama eğer result 0 dan büyükse kullanıcıya bilgi veriyoruz
               // {
               //     lblMessage.Text = "Course added successfully.";
               //     lblMessage.ForeColor = Color.Green; 
               // }

            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
                lblMessage.ForeColor = Color.Red;
            }
        }

       
    }
}

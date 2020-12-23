
using panel.Models;           //BUNU İMPORT ETMEMİZ LAZIM KULLANMAK İÇİN UNUTMA 
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
    public partial class PersonelManagerLogin : Form
    {
        public PersonelManagerLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //string x= "   pak   "         //trim örneği
            //string y = x.Trim();
            // Trim() foknsiyonu boşluk varsa onu silicek atıyorum adımızı girerken boşluk karakteri olsun istemiyoruz onu algılasın istiyoruz onun için 8 ekim ilk ders dakika 34 den sonra anlatıyor hoca önemli baya   
            //İlk ve son eğer boşluk varsa silecek

            string email = tbEmail.Text.Trim();           //Trimli versiyonunu atıyoruz email ve passworda gelen şeyin direk başı ve sonundaki boşlukları siliyor
            string password = tbPassword.Text.Trim();

            lblMessage.Text = "";                         //Butona her bastığımızda bu mesajın içini boşluyoruz ki boş bırakınca çıkan mesaj içini doldurup tekrar tıklayınca silinsin diye 

            

            if(email == "")
            {
                lblMessage.Text = "Please enter your email !!!";
                lblMessage.ForeColor = Color.Red;
                tbEmail.Focus();              


                return;            
            }
            
            if(password == "")
            {
                lblMessage.Text = "Please enter your password !!!";
                lblMessage.ForeColor = Color.Red;
                tbPassword.Focus();  
                return;
            }

            Employee emp = new Employee();                   //BURDA OLUŞTURDUĞUMUZ NESNEYİ EMPLOYEE CLASSI İÇİNDEKİ LOGİN ÖZELLİĞİNİ KULLANARAK ÇAĞIRDIK
            var employee =emp.Login(email, password);        //VE BU FONKSİYON Employee tipinde bir değişken döndürüyor ve bu değişken boş değilse LOGİN YAPIYOR

            if (employee !=null)
            {
                lblMessage.Text = "Welcome";
                PersonelManager form = new PersonelManager(employee);
                form.Person = employee;
                form.ShowDialog();
            }
            else
            {
                lblMessage.Text = "Email or Password is incorrect";
                lblMessage.ForeColor = Color.Red;
            }

        }

        private void button2_Click(object sender, EventArgs e) 
        {
            lblMessage.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
            

        }
    }
}

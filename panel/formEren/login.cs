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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)        //clear button
        {
            lblMessage.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
            cbRemember.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)        //login button
        {
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();


            lblMessage.Text = "";



            if (email == "")
            {
                lblMessage.Text = "Please enter your email !!!";
                lblMessage.ForeColor = Color.Red;
                tbEmail.Focus();              //BU FONKSİYON ÇOK İYİ EĞER HATA VARSA MAİLDE FOCUSU ONA YAP DİYOR YANİ HATA OLDUMMU İMLEÇ YAZMA YERİ DİREK ONDA FOKUS OLUCAK UNUTMA GÜZEL DETAY HOCA KULLANDI 8 ekim ilk ders dakika 40


                return;            //Burda return sebebi buraya girdikten sorna başa dönsün aşşağı gitmesin email boşsa yani ilk onu doldurmamızı istesin diye yazdık
                                   //Aslında burda else if de yapabilirdik eğer bu doluysa alttaki boşsa bu çalışsın gibisindende hoca returnle yapmayı uygun gördü

            }

            if (password == "")
            {
                lblMessage.Text = "Please enter your password !!!";
                lblMessage.ForeColor = Color.Red;
                tbPassword.Focus();  //passwordde hata varsa focusu passworde textine götür yani imleçi ordan başlat gibi
                return;
            }


            Employee emp = new Employee();                   //BURDA OLUŞTURDUĞUMUZ NESNEYİ EMPLOYEE CLASSI İÇİNDEKİ LOGİN ÖZELLİĞİNİ KULLANARAK ÇAĞIRDIK
            var employee = emp.Login(email, password);        //VE BU FONKSİYON Employee tipinde bir değişken döndürüyor ve bu değişken boş değilse LOGİN YAPIYOR
         
            
            if (employee != null)
            {
                

                lblMessage.Text = "Welcome";
                Form1 form = new Form1();

                form.ShowDialog();

                if (!cbRemember.Checked)              //remember checked ise login ekranı kapanmıyor eğer değil ise kapanıyor
                {
                    this.Close();

                }


            }
            else
            {
                lblMessage.Text = "Email or Password is incorrect";
                lblMessage.ForeColor = Color.Red;
            }
            

        }

    }
    
}



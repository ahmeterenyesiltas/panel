
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

                string name = tbFirstName.Text.Trim();     //burda yazılan değeri kullanıcıdan isim olarak arakladık altta ekliyoruz bunu yazdığımız class ve fonksiyon ile
                
                
                //int credit = (int)nudCredit.Value;    //aynı şekilde burdada credit için aynı işlemi yapıp altta atıyoruz add butonuna basılınca

                if (string.IsNullOrWhiteSpace(name))
                {
                    tbFirstName.Focus();
                    throw new Exception("Course name is empty");
                }

                Employee obj = new Employee();
                obj.FirstName = name;
                
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

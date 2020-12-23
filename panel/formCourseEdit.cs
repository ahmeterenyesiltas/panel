
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeDemoBIM
{
    public partial class formCourseEdit : Form
    {

        //Course course=null;

        public formCourseEdit(/*Course c*/)     //burda başlar başlamaz id yi yazdırmak için parametre aldık constructora kendi classının 
        {
            InitializeComponent();
            //course = c;
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

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) //update butonu için Course u güncelleyecek
        {

            try
            {
                lblMessage.Text = "";
                lblMessage.ForeColor = Color.Black;     //başlarken message lbli boş tanımladık

                string name = tbName.Text.Trim();
                if (string.IsNullOrWhiteSpace(name))
                {
                    tbName.Focus();
                    throw new Exception("Course Name Cannot be empty");
                }

               // Course obj = new Course();
               // obj.CourseID = course.CourseID;
               // obj.Name = name;
               // obj.Credit = (int)nudCredit.Value;

               //var result= obj.CourseUpdate(obj);
               
                //if (result > 0)
                //{
                //    lblMessage.Text = "Course Updated Succesfully.";
                //    lblMessage.ForeColor = Color.Green;
                    
                //}

            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
                lblMessage.ForeColor = Color.Red;
            }

        }
    }
}

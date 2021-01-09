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
        //int ID = -1;
        //public Person Person { get; set; }

        //public Person Person { get; set; } //Çok önemli!
        public formCarHome() //Person p
        {
            InitializeComponent();

            //Person = p;
        }

        //public Person Person { get; set; }

        //private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var Result = MessageBox.Show("Do you want to close?", "System Message",
        //            MessageBoxButtons.YesNo);

        //        if (Result == DialogResult.Yes)
        //        {
        //            this.Close();
        //        }
        //    }
        //    catch (Exception Ex)
        //    {

        //        MessageBox.Show(Ex.Message);
        //    }
        //}

        private void formCarHome_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    if (Person != null)
            //    {
            //        lblWelcome2.Text = Person.FirstName + " " + Person.LastName;
            //    }
            //}
            //catch (Exception Ex)
            //{

            //    MessageBox.Show(Ex.Message);
            //}
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

        //private void editToolStripMenuItem1_Click(object sender, EventArgs e) //Edit
        //{
        //        //MessageBox.Show("Edit Clicked!!!");

        //    try
        //    {
        //        Course C1 = new Course();

        //        var dt = C1.GetAllCourseByID(ID);

        //        if (dt.Rows.Count > 0)
        //        {
        //            //C1.CourseID = int.Parse(dt.Rows[0]["CourseID"].ToString());
        //            C1.CourseID = ID;
        //            C1.Name = dt.Rows[0]["CourseID"].ToString();
        //            C1.CourseID = int.Parse(dt.Rows[0]["Credit"].ToString());
        //        }

        //        formCourseEdit formNew = new formCourseEdit(C1);

        //        formNew.ShowDialog();


        //    }
        //    catch (Exception Ex)
        //    {

        //        MessageBox.Show(Ex.Message);
        //    }
        //}

        //private void dataGridViewDATA_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    try
        //    {
        //        if (e.ColumnIndex != -1 && e.RowIndex != -1 )
        //        {
        //            if (e.Button == MouseButtons.Right)
        //            {
        //                //"yani bu sayede hangi row selected oldu görebiliyorum..."
        //                dataGridViewDATA.Rows[e.RowIndex].Selected = true;

        //                // "demek ki 0, index'te CourseID okudum..."
        //                ID = int.Parse(dataGridViewDATA.Rows[e.RowIndex].Cells[0].Value.ToString()); 

        //                //var relativePosition = dataGridViewDATA.PointToClient(Cursor.Position);

        //                contextMenuStrip1.Show(dataGridViewDATA, dataGridViewDATA.PointToClient(Cursor.Position));
        //            }
        //        }
        //    }
        //    catch (Exception Ex)
        //    {

        //        MessageBox.Show(Ex.Message);
        //    }
        //}

        //private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (ID == -1)
        //        {
        //            return;
        //        }

        //        var Result = MessageBox.Show("Are you sure to DELETE?", "System Message", MessageBoxButtons.YesNo);

        //        if (Result == DialogResult.Yes)
        //        {
        //            Course C1 = new Course();

        //            var Result2= C1.DeleteCourse(ID);

        //            if (Result2 >0)
        //            {
        //                MessageBox.Show("Course DELETED!");

        //                dataGridViewDATA.DataSource = C1.GetAllCourse(); //F5, Refresh
        //            }

        //            else
        //            {
        //                MessageBox.Show("Course NOT DELETED!");
        //            }
        //        }
        //    }
        //    catch (Exception Ex)
        //    {

        //        MessageBox.Show(Ex.Message);
        //    }
        //}

        //private void addToolStripMenuItem1_Click(object sender, EventArgs e) //Add 
        //{
        //    try
        //    {
        //        formCourseAdd formNew = new formCourseAdd();

        //        formNew.ShowDialog();
        //    }
        //    catch (Exception Ex)
        //    {

        //        MessageBox.Show(Ex.Message);
        //    }
        //}
    }
}

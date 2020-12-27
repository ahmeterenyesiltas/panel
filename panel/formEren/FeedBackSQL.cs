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
using panel.ModelEren;


namespace panel
{
    public partial class FeedBackSQL : Form
    {

        int ID = -1;

        public FeedBackSQL()
        {
            InitializeComponent();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                FeedBacks feedback = new FeedBacks();               //BURADA TÜM SATIRLARI ALMAK İÇİN GEREKLİ OLAN İŞLEMİ BÖYLE ÇAĞIRIYORUZ
                dgvData.DataSource = feedback.GetAllFeedBack();  //FONKSİYONU ZATEN EMPLOYEE.CS DE YAZMIŞTIK
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FeedBacks feedback = new FeedBacks();
                var dt = feedback.GetCustomerByID(ID);

                if (dt.Rows.Count > 0)
                {
                                                           //direkt istersek c.CourseID=ID de diyebiliriz bunun için
                    feedback.CustomerName = dt.Rows[0]["CustomerName"].ToString();
                    feedback.CustomerReview = dt.Rows[0]["CustomerReview"].ToString();
                    feedback.CustomerPoint = float.Parse(dt.Rows[0]["CustomerPoint"].ToString());
                    feedback.RestaurantQuality = float.Parse(dt.Rows[0]["RestaurantQuality"].ToString());

                    lblName.Text = feedback.CustomerName.ToString();
                    lblReview.Text = feedback.CustomerReview.ToString();


                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        private void dgvData_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

            //mouse a sağ click attığında çıkan şey için
            {                                                    //11.12.2020      11 aralık dersi birşey anlamadım pek fazla bundan
                try
                {
                    if (e.ColumnIndex != -1 && e.RowIndex != -1)
                    {
                        if (e.Button == MouseButtons.Right)
                        {
                            dgvData.Rows[e.RowIndex].Selected = true;                       //buda sağ click attığımız satırı seçili hale getiricek
                            ID = int.Parse(dgvData.Rows[e.RowIndex].Cells[0].Value.ToString());

                            var relativepos = dgvData.PointToClient(Cursor.Position);       //sağ clickde seçeneklerin nerde çıkıcağını seçtik cursorda çıktı tam olarak mouseda yani
                            contextMenuStrip1.Show(dgvData, relativepos);
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
}

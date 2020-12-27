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
    }
}

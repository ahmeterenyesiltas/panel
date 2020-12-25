using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using panel.DbOperations;

namespace panel
{
    public partial class müsteri_takip : Form
    {
        #region Değişkenler
        Common common = new Common();
        #endregion
        public müsteri_takip()
        {
            InitializeComponent();
        }

        

        //Müşterileri listeleyen iç metod.
        private void musteriGoruntule()
        {
            DataTable tablo = common.MusterileriGoruntule();
            dataGridView1.DataSource = tablo;
        }

        private void btnMusteri4_Click(object sender, EventArgs e)
        {
            musteriGoruntule();
        }
    }
}

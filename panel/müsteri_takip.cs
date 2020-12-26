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
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;


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

        private void btnMusteri1_Click(object sender, EventArgs e)
        {

            con = new SqlConnection("Server=94.73.144.8;Database=u8846052_DBRMS01;User Id=u8846052_RMS01;Password=TYgv18I1HFbi19X;");
            con.Open();
            cmd = new SqlCommand("INSERT INTO MUSTERILER(AD_SOYAD, TELEFON, e_mail, ADRES, cinsiyet) VALUES (@AD_SOYAD, @TELEFON, @e_mail, @ADRES, @cinsiyet)", con);
            cmd.Parameters.AddWithValue("@AD_SOYAD", StoktextBox1.Text);
            cmd.Parameters.AddWithValue("@TELEFON", StoktextBox2.Text);
            cmd.Parameters.AddWithValue("@e_mail", StoktextBox3.Text);
            cmd.Parameters.AddWithValue("@ADRES", StoktextBox4.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", StoktextBox5.Text);
            cmd.ExecuteNonQuery();
        }
    }
}

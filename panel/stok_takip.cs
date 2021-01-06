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

    public partial class stok_takip : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;


        #region Değişkenler
        Common common = new Common();
        #endregion
        public stok_takip()
        {
            InitializeComponent();
        }




        //Stokları listeleyen iç metod.
        private void stokGoruntule()
        {
            DataTable tablo = common.stokGoruntule();
            dataGridView1.DataSource = tablo;
        }

        private void btnStok4_Click(object sender, EventArgs e)
        {
            stokGoruntule();
        }

        private void btnStok1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=94.73.144.8;Database=u8846052_DBRMS01;User Id=u8846052_RMS01;Password=TYgv18I1HFbi19X;");
            con.Open();
            cmd = new SqlCommand("INSERT INTO STOK(STOK_KODU, STOK_TURU, STOK_ADI, STOK_FIYAT, STOK_ADET,STOK_BIRIM) VALUES (@STOK_KODU, @STOK_TURU, @STOK_ADI, @STOK_FIYAT, @STOK_ADET, @STOK_BIRIM)", con);
            cmd.Parameters.AddWithValue("@STOK_KODU", StoktextBox1.Text);
            cmd.Parameters.AddWithValue("@STOK_TURU", StoktextBox2.Text);
            cmd.Parameters.AddWithValue("@STOK_ADI", StoktextBox3.Text);
            cmd.Parameters.AddWithValue("@STOK_FIYAT", StoktextBox4.Text);
            cmd.Parameters.AddWithValue("@STOK_ADET", StoktextBox5.Text);
            cmd.Parameters.AddWithValue("@STOK_BIRIM", StoktextBox6.Text);
            cmd.ExecuteNonQuery();

            StoktextBox1.Text = "";
            StoktextBox2.Text = "";
            StoktextBox3.Text = "";
            StoktextBox4.Text = "";
            StoktextBox5.Text = "";
            StoktextBox6.Text = "";

            stokGoruntule();
        }

        private void btnStok2_Click(object sender, EventArgs e)
        {

            con = new SqlConnection("Server=94.73.144.8;Database=u8846052_DBRMS01;User Id=u8846052_RMS01;Password=TYgv18I1HFbi19X;");
            con.Open();

            SqlCommand cmdSil = new SqlCommand("DELETE STOK WHERE STOK_ADET= '" + dataGridView1.CurrentRow.Cells[4].Value.ToString() + "'", con);
            cmdSil.ExecuteNonQuery();

            stokGoruntule();
        }
    }
    }


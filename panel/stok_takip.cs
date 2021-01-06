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

        private void btnStok3_Click(object sender, EventArgs e)
        {
            btnStok3.Visible = false;
            button5.Visible = true;

            con = new SqlConnection("Server=94.73.144.8;Database=u8846052_DBRMS01;User Id=u8846052_RMS01;Password=TYgv18I1HFbi19X;");
            con.Open();

            SqlCommand cmdGuncelle = new SqlCommand("SELECT * FROM STOK WHERE STOK_KODU='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' AND STOK_TURU = '" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'   AND STOK_ADI = '" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "'    AND STOK_FIYAT = '" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "'     AND STOK_ADET = '" + dataGridView1.CurrentRow.Cells[4].Value.ToString() + "'  AND STOK_BIRIM = '" + dataGridView1.CurrentRow.Cells[5].Value.ToString() + "'    ", con);
            SqlDataReader dr = cmdGuncelle.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            DataRow row = dt.Rows[0];
            StoktextBox1.Text = row["STOK_KODU"].ToString();

            DataRow row1 = dt.Rows[0];
            StoktextBox2.Text = row1["STOK_TURU"].ToString();

            DataRow row2 = dt.Rows[0];
            StoktextBox3.Text = row2["STOK_ADI"].ToString();

            DataRow row3 = dt.Rows[0];
            StoktextBox4.Text = row3["STOK_FIYAT"].ToString();

            DataRow row4 = dt.Rows[0];
            StoktextBox5.Text = row4["STOK_ADET"].ToString();

            DataRow row5 = dt.Rows[0];
            StoktextBox6.Text = row5["STOK_BIRIM"].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnStok3.Visible = true;
            button5.Visible = false;

            con = new SqlConnection("Server=94.73.144.8;Database=u8846052_DBRMS01;User Id=u8846052_RMS01;Password=TYgv18I1HFbi19X;");
            con.Open();

            SqlCommand cmdKaydet = new SqlCommand("UPDATE STOK SET STOK_KODU= '" + StoktextBox1.Text + "',STOK_TURU= '" + StoktextBox2.Text + "',STOK_ADI= '" + StoktextBox3.Text + "',STOK_FIYAT= '" + StoktextBox4.Text + "',STOK_ADET= '" + StoktextBox5.Text + "',STOK_BIRIM= '" + StoktextBox6.Text + "'  where STOK_KODU='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", con);
            cmdKaydet.ExecuteNonQuery();
            
            StoktextBox1.Text = "";
            StoktextBox2.Text = "";
            StoktextBox3.Text = "";
            StoktextBox4.Text = "";
            StoktextBox5.Text = "";
            StoktextBox6.Text = "";

            stokGoruntule();
        }

        private void btnStokAra_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=94.73.144.8;Database=u8846052_DBRMS01;User Id=u8846052_RMS01;Password=TYgv18I1HFbi19X;");
            con.Open();

            SqlCommand cmdAra = new SqlCommand("SELECT * FROM  STOK WHERE STOK_KODU= '" + StoktextBox7.Text.ToString() + "'", con);
            cmdAra.ExecuteNonQuery();
            da = new SqlDataAdapter(cmdAra);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;


        }
    }
    }


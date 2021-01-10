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

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=94.73.144.8;Database=u8846052_DBRMS01;User Id=u8846052_RMS01;Password=TYgv18I1HFbi19X;");
            con.Open();

            SqlCommand cmdFirma = new SqlCommand("SELECT * FROM FIRMA", con);
            cmdFirma.ExecuteNonQuery();
            da = new SqlDataAdapter(cmdFirma);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView2.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=94.73.144.8;Database=u8846052_DBRMS01;User Id=u8846052_RMS01;Password=TYgv18I1HFbi19X;");
            con.Open();
            cmd = new SqlCommand("INSERT INTO FIRMA(FIRMA, AD_SOYAD, TELEFON, E_MAIL, STOK_KODU,VERGI_NO, UNVAN, ACIKLAMA) VALUES (@FIRMA, @AD_SOYAD, @TELEFON, @E_MAIL, @STOK_KODU, @VERGI_NO, @UNVAN, @ACIKLAMA)", con);
            cmd.Parameters.AddWithValue("@FIRMA", StoktextBox8.Text);
            cmd.Parameters.AddWithValue("@AD_SOYAD", StoktextBox9.Text);
            cmd.Parameters.AddWithValue("@TELEFON", StoktextBox10.Text);
            cmd.Parameters.AddWithValue("@E_MAIL", StoktextBox11.Text);
            cmd.Parameters.AddWithValue("@STOK_KODU", StoktextBox12.Text);
            cmd.Parameters.AddWithValue("@VERGI_NO", StoktextBox13.Text);
            cmd.Parameters.AddWithValue("@UNVAN", StoktextBox14.Text);
            cmd.Parameters.AddWithValue("@ACIKLAMA", StoktextBox15.Text);
            cmd.ExecuteNonQuery();

            StoktextBox8.Text = "";
            StoktextBox9.Text = "";
            StoktextBox10.Text = "";
            StoktextBox11.Text = "";
            StoktextBox12.Text = "";
            StoktextBox13.Text = "";
            StoktextBox14.Text = "";
            StoktextBox15.Text = "";

            SqlCommand cmdFirma = new SqlCommand("SELECT * FROM FIRMA", con);
            cmdFirma.ExecuteNonQuery();
            da = new SqlDataAdapter(cmdFirma);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView2.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=94.73.144.8;Database=u8846052_DBRMS01;User Id=u8846052_RMS01;Password=TYgv18I1HFbi19X;");
            con.Open();

            SqlCommand cmdSil2 = new SqlCommand("DELETE FIRMA WHERE FIRMA= '" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'", con);
            cmdSil2.ExecuteNonQuery();

            SqlCommand cmdFirma = new SqlCommand("SELECT * FROM FIRMA", con);
            cmdFirma.ExecuteNonQuery();
            da = new SqlDataAdapter(cmdFirma);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView2.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button6.Visible = true;

            con = new SqlConnection("Server=94.73.144.8;Database=u8846052_DBRMS01;User Id=u8846052_RMS01;Password=TYgv18I1HFbi19X;");
            con.Open();

            SqlCommand cmdGuncelle = new SqlCommand("SELECT * FROM FIRMA WHERE FIRMA='" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "' AND AD_SOYAD = '" + dataGridView2.CurrentRow.Cells[1].Value.ToString() + "'   AND TELEFON = '" + dataGridView2.CurrentRow.Cells[2].Value.ToString() + "'    AND E_MAIL = '" + dataGridView2.CurrentRow.Cells[3].Value.ToString() + "'     AND STOK_KODU = '" + dataGridView2.CurrentRow.Cells[4].Value.ToString() + "'  AND VERGI_NO = '" + dataGridView2.CurrentRow.Cells[5].Value.ToString() + "'     AND UNVAN = '" + dataGridView2.CurrentRow.Cells[6].Value.ToString() + "'    AND ACIKLAMA = '" + dataGridView2.CurrentRow.Cells[7].Value.ToString() + "'    ", con);
            SqlDataReader dr = cmdGuncelle.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            DataRow row = dt.Rows[0];
            StoktextBox8.Text = row["FIRMA"].ToString();

            DataRow row1 = dt.Rows[0];
            StoktextBox9.Text = row1["AD_SOYAD"].ToString();

            DataRow row2 = dt.Rows[0];
            StoktextBox10.Text = row2["TELEFON"].ToString();

            DataRow row3 = dt.Rows[0];
            StoktextBox11.Text = row3["E_MAIL"].ToString();

            DataRow row4 = dt.Rows[0];
            StoktextBox12.Text = row4["STOK_KODU"].ToString();

            DataRow row5 = dt.Rows[0];
            StoktextBox13.Text = row5["VERGI_NO"].ToString();

            DataRow row6 = dt.Rows[0];
            StoktextBox14.Text = row4["UNVAN"].ToString();

            DataRow row7 = dt.Rows[0];
            StoktextBox15.Text = row5["ACIKLAMA"].ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button6.Visible = false;

            con = new SqlConnection("Server=94.73.144.8;Database=u8846052_DBRMS01;User Id=u8846052_RMS01;Password=TYgv18I1HFbi19X;");
            con.Open();

            SqlCommand cmdKaydet = new SqlCommand("UPDATE FIRMA SET FIRMA= '" + StoktextBox8.Text + "',AD_SOYAD= '" + StoktextBox9.Text + "',TELEFON= '" + StoktextBox10.Text + "',E_MAIL= '" + StoktextBox11.Text + "',STOK_KODU= '" + StoktextBox12.Text + "',VERGI_NO= '" + StoktextBox13.Text + "',UNVAN= '" + StoktextBox14.Text + "',ACIKLAMA= '" + StoktextBox15.Text + "'  where FIRMA='" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'", con);
            cmdKaydet.ExecuteNonQuery();

            StoktextBox8.Text = "";
            StoktextBox9.Text = "";
            StoktextBox10.Text = "";
            StoktextBox11.Text = "";
            StoktextBox12.Text = "";
            StoktextBox13.Text = "";
            StoktextBox14.Text = "";
            StoktextBox15.Text = "";


            SqlCommand cmdFirma = new SqlCommand("SELECT * FROM FIRMA", con);
            cmdFirma.ExecuteNonQuery();
            da = new SqlDataAdapter(cmdFirma);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView2.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=94.73.144.8;Database=u8846052_DBRMS01;User Id=u8846052_RMS01;Password=TYgv18I1HFbi19X;");
            con.Open();

            SqlCommand cmdAra = new SqlCommand("SELECT * FROM  FIRMA WHERE FIRMA= '" + textBox1.Text.ToString() + "'", con);
            cmdAra.ExecuteNonQuery();
            da = new SqlDataAdapter(cmdAra);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
    }


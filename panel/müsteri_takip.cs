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

            StoktextBox1.Text = "";
            StoktextBox2.Text = "";
            StoktextBox3.Text = "";
            StoktextBox4.Text = "";
            StoktextBox5.Text = "";
        }

        private void btnMusteri2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=94.73.144.8;Database=u8846052_DBRMS01;User Id=u8846052_RMS01;Password=TYgv18I1HFbi19X;");
            con.Open();

            SqlCommand cmdSil = new SqlCommand("DELETE MUSTERILER WHERE TELEFON= '" + dataGridView1.CurrentRow.Cells[1].Value.ToString()+"'",con);
            cmdSil.ExecuteNonQuery();

        }

        private void btnMusteri3_Click(object sender, EventArgs e)
        {
            btnMusteri3.Visible = false;
            btn_kaydet.Visible = true;

            con = new SqlConnection("Server=94.73.144.8;Database=u8846052_DBRMS01;User Id=u8846052_RMS01;Password=TYgv18I1HFbi19X;");
            con.Open();

            SqlCommand cmdGuncelle = new SqlCommand("SELECT * FROM MUSTERILER WHERE AD_SOYAD='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' AND TELEFON = '" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'   AND e_mail = '" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "'    AND ADRES = '" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "'     AND cinsiyet = '" + dataGridView1.CurrentRow.Cells[4].Value.ToString() + "' ", con);
            SqlDataReader dr = cmdGuncelle.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            DataRow row = dt.Rows[0];
            StoktextBox1.Text = row["AD_SOYAD"].ToString();

            DataRow row1 = dt.Rows[0];
            StoktextBox2.Text = row1["TELEFON"].ToString();

            DataRow row2 = dt.Rows[0];
            StoktextBox3.Text = row2["e_mail"].ToString();

            DataRow row3 = dt.Rows[0];
            StoktextBox4.Text = row3["ADRES"].ToString();

            DataRow row4 = dt.Rows[0];
            StoktextBox5.Text = row4["cinsiyet"].ToString();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            btnMusteri3.Visible = true;
            btn_kaydet.Visible = false;

            con = new SqlConnection("Server=94.73.144.8;Database=u8846052_DBRMS01;User Id=u8846052_RMS01;Password=TYgv18I1HFbi19X;");
            con.Open();

            SqlCommand cmdKaydet = new SqlCommand("UPDATE MUSTERILER SET AD_SOYAD= '"+StoktextBox1.Text+ "' where AD_SOYAD='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'",con  );
            cmdKaydet.ExecuteNonQuery();
            StoktextBox1.Text = "";
            StoktextBox2.Text = "";
            StoktextBox3.Text = "";
            StoktextBox4.Text = "";
            StoktextBox5.Text = "";
        }
    }
}

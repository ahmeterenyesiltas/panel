using System;
using System.Data.SqlClient;
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
    
    public partial class info : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        
        public info()
        {
            InitializeComponent();
        }
        public void verialin()
        {
            baglanti = new SqlConnection("server=EKOSR;Initial Catalog=gorselodev;Interated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM Tablo_3",baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
           // adres.DataSource = tablo;
            baglanti.Close();


            //string conString = "Server=EKOSR;Database=gorselodev;Trusted_Connection=True;";
            //SqlConnection connection = new SqlConnection(conString);
            //connection.Open();
        }
        private void İnfo_Load(object sender,EventArgs e)
        {
            verialin();
        }

        private void adres_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO gorselodev(adres) VALUES(@adres)";
            komut = new SqlCommand(sorgu,baglanti);
           // komut.Parameters.AddWithValue("@adres");
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        
    }
}

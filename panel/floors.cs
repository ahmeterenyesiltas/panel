using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panel
{
    public partial class floors : Form
    {
        public floors()
        {
            InitializeComponent();
            int kat;
            Console.WriteLine("seçmek istediğiniz masayı giriniz:");
            kat = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("seçtiğiniz kat:"+kat);
}
        public void fveri()
        {
            string conString = "Server=EKOSR;Database=odev;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

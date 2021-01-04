using panel.DbOperations;
using System;
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
        Common common = new Common();
        public info()
        {
            InitializeComponent();
        }

        private void adres_Click(object sender, EventArgs e)
        {
            var adresDatatable = common.AdresiGoruntule();

            string message = adresDatatable.Rows.Count == 0 ? "Adres bulunamadı." : adresDatatable.Rows[0].Field<string>("adres");      

            MessageBox.Show(message, "Adres");
        }

        private void kampanya_Click(object sender, EventArgs e)
        {
            string message = "Bugüne özel kampanya bulunmamaktadır.";
            string title = "Kampanyalar";
            MessageBox.Show(message, title);
        }

        private void websitemiz_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://restaurant.com");
            //web sitesi yapamayacağımız için öylesine açılmayan bir link ekledim
        }

        private void yemeksepeti_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.yemeksepeti.com");
        }

        private void bilgilendirme_Click(object sender, EventArgs e)
        {
            string message = "Adres için=>Neredeyiz kısmına tıklayınız.";
            string title = "Bilgilendirme";
            MessageBox.Show(message, title);
        }

        private void hakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Biz bir restoranız.");
        }
    }
}

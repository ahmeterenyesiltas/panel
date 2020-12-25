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

    }
}

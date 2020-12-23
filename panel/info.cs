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
        public info()
        {
            InitializeComponent();
        }
        public void iveri()
        {
            string conString = "Server=EKOSR;Database=odev;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
        }
    }
}

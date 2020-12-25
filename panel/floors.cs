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
    public partial class floors : Form
    {
        public floors()
        {
            InitializeComponent();
        }
      public void verial()
        {
            string kat;
            Console.WriteLine("kat seçiniz:");
            kat = Console.ReadLine();

            Console.WriteLine("girdiğiniz kat:"+kat);
            Console.ReadKey();
        }
        //private void button3_Click(object sender, EventArgs e)
        //{
           
        //}

        
    }
}

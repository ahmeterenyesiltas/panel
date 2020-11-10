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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Controls.Clear();
            ilkform test2 = new ilkform();
            test2.TopLevel = false;
            panel3.Controls.Add(test2);
            test2.Show();
            test2.Dock = DockStyle.Fill;
            test2.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Controls.Clear();
            ikinciform test2 = new ikinciform();
            test2.TopLevel = false;
            panel3.Controls.Add(test2);
            test2.Show();
            test2.Dock = DockStyle.Fill;
            test2.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == true)
            {
                panel3.Visible = false;
            }
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

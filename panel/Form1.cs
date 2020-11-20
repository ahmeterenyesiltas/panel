using panel.Properties;          //Resources klasörünü kullanmak için Panel Properties kütüphanesini include ettim
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
            timer1.Start();
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

        private void button13_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Controls.Clear();
            MediaPlayer test2 = new MediaPlayer();
            test2.TopLevel = false;
            panel3.Controls.Add(test2);
            test2.Show();
            test2.Dock = DockStyle.Fill;
            test2.BringToFront();
        }

        private void Orderbtn_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Controls.Clear();
            siparis siparis = new siparis();
            siparis.TopLevel = false;
            panel3.Controls.Add(siparis);
            siparis.Show();
            siparis.Dock = DockStyle.Fill;
            siparis.BringToFront();
        }

        private void OrderLeftbtn_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Controls.Clear();
            siparis siparis = new siparis();
            siparis.TopLevel = false;
            panel3.Controls.Add(siparis);
            siparis.Show();
            siparis.Dock = DockStyle.Fill;
            siparis.BringToFront();
        }

        private void leftfloor1btn_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Controls.Clear();
            floors test2 = new floors();
            test2.TopLevel = false;
            panel3.Controls.Add(test2);
            test2.Show();
            test2.Dock = DockStyle.Fill;
            test2.BringToFront();
        }
        

        private bool isCollapsed;   //Dropdown panel Button
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                button2.Image = Resources.up_30px;
                panelFloorDrop.Height += 10;
                if (panelFloorDrop.Size == panelFloorDrop.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                button2.Image = Resources.Down_30px;
                panelFloorDrop.Height -= 10;
                if (panelFloorDrop.Size == panelFloorDrop.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Controls.Clear();
            YemekMenu menu = new YemekMenu();
            menu.TopLevel = false;
            panel3.Controls.Add(menu);
            menu.Show();
            menu.Dock = DockStyle.Fill;
            menu.BringToFront();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Controls.Clear();
            info infsayfa = new info();
            infsayfa.TopLevel = false;
            panel3.Controls.Add(infsayfa);
            infsayfa.Show();
            infsayfa.Dock = DockStyle.Fill;
            infsayfa.BringToFront();
        }

        private void btnMenuLeft_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Controls.Clear();
            YemekMenu menu = new YemekMenu();
            menu.TopLevel = false;
            panel3.Controls.Add(menu);
            menu.Show();
            menu.Dock = DockStyle.Fill;
            menu.BringToFront();
        }

        private void btnInfoLeft_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Controls.Clear();
            info infsayfa = new info();
            infsayfa.TopLevel = false;
            panel3.Controls.Add(infsayfa);
            infsayfa.Show();
            infsayfa.Dock = DockStyle.Fill;
            infsayfa.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Controls.Clear();
            PersonelManager pmanager = new PersonelManager();
            pmanager.TopLevel = false;
            panel3.Controls.Add(pmanager);
            pmanager.Show();
            pmanager.Dock = DockStyle.Fill;
            pmanager.BringToFront();
        }
    }
}

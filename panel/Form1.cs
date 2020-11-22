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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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

        

       
         //yusuf Car Park
        private void button25_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Controls.Clear();
            AddCar addCar = new AddCar();
            addCar.TopLevel = false;
            panel3.Controls.Add(addCar);
            addCar.Show();
            addCar.Dock = DockStyle.Fill;
            addCar.BringToFront();
        }

        private void panelParkDroop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                button25.Image = Resources.up_30px;
                panelParkDroop.Height += 10;
                if (panelParkDroop.Size == panelParkDroop.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                button25.Image = Resources.Down_30px;
                panelParkDroop.Height -= 10;
                if (panelParkDroop.Size == panelParkDroop.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }
        //Yusuf Car Park
        
        }
        
        
        //Yusuf Campaign
        private void panel6_Paint(object sender, PaintEventArgs e)         //Bu panel Campaign Classının Dropdown Paneli
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Controls.Clear();
            AddCampaign addcampaign = new AddCampaign();
            addcampaign.TopLevel = false;
            panel3.Controls.Add(addcampaign);
            addcampaign.Show();
            addcampaign.Dock = DockStyle.Fill;
            addcampaign.BringToFront();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                button9.Image = Resources.up_30px;
                panel6.Height += 10;
                if (panel6.Size == panel6.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                button9.Image = Resources.Down_30px;
                panel6.Height -= 10;
                if (panel6.Size == panel6.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsed = true;
                }
            }
        }




        //Yusuf Campaign

        private void stok_takip_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Controls.Clear();
            stok_takip stok_takip = new stok_takip();
            stok_takip.TopLevel = false;
            panel3.Controls.Add(stok_takip);
            stok_takip.Show();
            stok_takip.Dock = DockStyle.Fill;
            stok_takip.BringToFront();
        }

        private void btnKamera_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Controls.Clear();
            kamera kamera = new kamera();
            kamera.TopLevel = false;
            panel3.Controls.Add(kamera);
            kamera.Show();
            kamera.Dock = DockStyle.Fill;
            kamera.BringToFront();
        }

        private void musteri_yonetim_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Controls.Clear();
            müsteri_takip musteri_takip = new müsteri_takip();
            musteri_takip.TopLevel = false;
            panel3.Controls.Add(musteri_takip);
            musteri_takip.Show();
            musteri_takip.Dock = DockStyle.Fill;
            musteri_takip.BringToFront();
        }


        //Enes butonlar
        private void FoodDeliverybtn_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Controls.Clear();
            paket_siparis pktsiparis = new paket_siparis();
            pktsiparis.TopLevel = false;
            panel3.Controls.Add(pktsiparis);
            pktsiparis.Show();
            pktsiparis.Dock = DockStyle.Fill;
            pktsiparis.BringToFront();
        }

        private void Courierbtn_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Controls.Clear();
            motorcuKURYE motorcu = new motorcuKURYE();
            motorcu.TopLevel = false;
            panel3.Controls.Add(motorcu);
            motorcu.Show();
            motorcu.Dock = DockStyle.Fill;
            motorcu.BringToFront();
        }

        private void Reservationbtn_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Controls.Clear();
            rezarvasyon reservation = new rezarvasyon();
            reservation.TopLevel = false;
            panel3.Controls.Add(reservation);
            reservation.Show();
            reservation.Dock = DockStyle.Fill;
            reservation.BringToFront();
        }



        //Enes butonlar

    }
}

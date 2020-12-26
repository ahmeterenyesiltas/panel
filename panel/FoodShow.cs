using panel.ModelEren;
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
    public partial class FoodShow : Form
    {
        public FoodShow()
        {
            InitializeComponent();
        }

        private void FoodShow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Show Food Button
        {
            try
            {
                lblTitle.Text = "Food Details";
                Food food = new Food();               //BURADA TÜM SATIRLARI ALMAK İÇİN GEREKLİ OLAN İŞLEMİ BÖYLE ÇAĞIRIYORUZ
                dgvData.DataSource = food.GetAllFood();  //FONKSİYONU ZATEN EMPLOYEE.CS DE YAZMIŞTIK
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) //Show Dessert Buttpn
        {
            try
            {
                lblTitle.Text = "Dessert Details";
                FoodDesserts desserts = new FoodDesserts();               //BURADA TÜM SATIRLARI ALMAK İÇİN GEREKLİ OLAN İŞLEMİ BÖYLE ÇAĞIRIYORUZ
                dgvData.DataSource = desserts.GetAllDeserts();  //FONKSİYONU ZATEN EMPLOYEE.CS DE YAZMIŞTIK
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}

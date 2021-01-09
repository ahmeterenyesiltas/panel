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

    public partial class FeedBack : Form
    {

        public float RestaurantQualityControl=-1;

        public FeedBack()
        {
            InitializeComponent();
        }

        private void RateBtn_Click(object sender, EventArgs e)
        {
            RatebtnStarColor();
        }

       private void RatebtnStarColor()
        {
            if (Radiobtn1.Checked)
            {
                StarBtn1.BackColor = Color.Green;
                StarBtn2.BackColor = Color.Red;
                StarBtn3.BackColor = Color.Red;
                StarBtn4.BackColor = Color.Red;
                StarBtn5.BackColor = Color.Red;

                RestaurantQualityControl = 1;
            }
            if (Radiobtn2.Checked)
            {
                StarBtn1.BackColor = Color.Green;
                StarBtn2.BackColor = Color.Green;
                StarBtn3.BackColor = Color.Red;
                StarBtn4.BackColor = Color.Red;
                StarBtn5.BackColor = Color.Red;

                RestaurantQualityControl = 2;
            }
            if (Radiobtn3.Checked)
            {
                StarBtn1.BackColor = Color.Green;
                StarBtn2.BackColor = Color.Green;
                StarBtn3.BackColor = Color.Green;
                StarBtn4.BackColor = Color.Red;
                StarBtn5.BackColor = Color.Red;

                RestaurantQualityControl = 3;
            }
            if (Radiobtn4.Checked)
            {
                StarBtn1.BackColor = Color.Green;
                StarBtn2.BackColor = Color.Green;
                StarBtn3.BackColor = Color.Green;
                StarBtn4.BackColor = Color.Green;
                StarBtn5.BackColor = Color.Red;

                RestaurantQualityControl = 4;
            }
            if (Radiobtn5.Checked)
            {
                StarBtn1.BackColor = Color.Green;
                StarBtn2.BackColor = Color.Green;
                StarBtn3.BackColor = Color.Green;
                StarBtn4.BackColor = Color.Green;
                StarBtn5.BackColor = Color.Green;

                RestaurantQualityControl = 5;
            }

        }        //Burda yazdığım kodu direkt üste yapıştırdım bu metodu istersem başka yerlerdede kullanabilirim
                                             //şimdilik kodlarını gizledim anlatımda aç 



        private void button1_Click(object sender, EventArgs e)
        {
            int point = (int)CustomerPointNUD.Value;        //Numeric updown Decimal türünden değer veriyor o yüzden inte çevirip öyle kullandım ve altta yazdırdım

            lblPoint.Text = "Your Point is: " + point+" Thank you for rating us";
            lblPoint.ForeColor = Color.Green;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            FeedBackSQL feedBack = new FeedBackSQL();
            feedBack.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                lblMessage.Text = "";
                lblMessage.ForeColor = Color.Black;

                string Customername = CustomerName.Text.Trim();     //burda yazılan değeri kullanıcıdan isim olarak arakladık altta ekliyoruz bunu yazdığımız class ve fonksiyon ile
                string Customerreview = CustomerReview.Text.Trim();
                float Customerpoint = (float)CustomerPointNUD.Value;
                float RestaurantQuality = RestaurantQualityControl;


                //int credit = (int)nudCredit.Value;    //aynı şekilde burdada credit için aynı işlemi yapıp altta atıyoruz add butonuna basılınca

                if (string.IsNullOrWhiteSpace(Customername))
                {
                    CustomerName.Focus();
                    throw new Exception("Customer name is empty");
                }
               
                if (string.IsNullOrWhiteSpace(Customerreview))
                {
                    CustomerReview.Focus();
                    throw new Exception("Customer Review is empty");
                }
                
                if (Customerpoint<0)
                {
                    CustomerPointNUD.Focus();
                    throw new Exception("CustomerPoint cannot be less than 0 ");
                }
               
                if (RestaurantQualityControl < 0)
                {
                    lblMessage.Text="Restaurant Quality is Empty";
                }

                FeedBacks feedback = new FeedBacks();          //üstte tanımladığım sabit değişkenleri atıyorum textboxları değil dikkat
                feedback.CustomerName = Customername;         //değişken değerlerine önce textboxları atadım sonra onları bu nesneye atıyorum
                feedback.CustomerPoint = Customerpoint;
                feedback.CustomerReview = Customerreview;
                feedback.RestaurantQuality=RestaurantQuality;

                int result = feedback.FeedbackAdd(feedback);  //Burda istedigimiz int deger vardi ekleme fonksiyonunda onu result ile gonderiyoruz

                if (result > 0)
                {
                    lblMessage.Text = "Feedback Added Successfully";
                    lblMessage.ForeColor = Color.Green;
                }



            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
                lblMessage.ForeColor = Color.Red;
            }


        }
    }
}

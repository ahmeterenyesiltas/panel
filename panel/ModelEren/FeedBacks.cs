using panel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel
{
    class FeedBacks
    {
        string customerName;
        string customerReview;
        float customerPoint;
        float restaurantQuality;
        int customerID;
        


        public string CustomerName
        {
            get => customerName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot Be empty");
                }
                customerName = value;
            }
        }
        public string CustomerReview
        {
            get => customerReview;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Customer Review Cannot be empty");
                }

                customerReview = value;
            }
        }

        public float CustomerPoint
        {
            get => customerPoint;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Point cannot be less than 1");
                }

                customerPoint = value;

            }
        }


        public float RestaurantQuality
        {
            get => restaurantQuality;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Restaurant quality cannot be less than 0");
                }
                restaurantQuality = value;
            }
        }

        public int CustomerID { get => customerID; set => customerID = value; }


        public DataTable GetAllFeedBack()        //Bunda Loginden farklı olarak tüm table ı okumak almak istiyoruz burası önemli
        {                                        //Data grid view da göstermek istediğimiz için galiba DataTable türünde oldu o kısmı anlamadım
                                                 //10 aralık dersinin sonunda yapıyor bunu oldukça önemli görünüyor
            SqlConnection connection = null;
            try
            {


                string conString = "Server=94.73.144.8;Database=u8846052_DBRMS01;User Id=u8846052_RMS01;Password=TYgv18I1HFbi19X;";
                connection = new SqlConnection(conString);
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    string query = "select * from Feedback";     //Burda direkt yazdırdık tüm employeeleri
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;

                }
                return null;
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }

            finally               //BAĞLANTIYI AÇTIĞIMIZ GİBİ KAPATMAMIZDA LAZIM FİNALLYDE KAPATIYORUZ BUNU 
            {
                connection.Close();
            }


        }


        public DataTable GetCustomerByID(int id)        //Bunda Loginden farklı olarak tüm table ı okumak almak istiyoruz burası önemli
        {                                        //Data grid view da göstermek istediğimiz için galiba DataTable türünde oldu o kısmı anlamadım
                                                 //10 aralık dersinin sonunda yapıyor bunu oldukça önemli görünüyor

            try
            {
                string query = $"select * from Feedback where CustomerID={id}";     //Burda id ye göre değer aldık burası çok önemliiiiiiiiiiiii
                return dbHelper.ExecuteQuery(query);


            }


            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }

        }

        public int FeedbackAdd(FeedBacks feedback)
        {

            SqlConnection connection = null;
            try
            {
                //if (EmployeeExists(e.Firstname + e.lastname))                            //Burda bir üstte tanımladığımız fonksiyonu kullanıp denedik eğer course var ve true dönerse hata gönder
                //{
                //    throw new Exception("Employee already Exits");
                //}

                //else
                //{
                    string query = $"INSERT INTO Feedback(CustomerName,CustomerReview,CustomerPoint,RestaurantQuality) VALUES('{feedback.CustomerName}','{feedback.CustomerReview}','{feedback.CustomerPoint}','{feedback.RestaurantQuality}')";
                    return dbHelper.ExecuteNonQuery(query);
                //}
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public int FeedBackDelete(int customerID)   
        {

            SqlConnection connection = null;
            try
            {
                string query = $"Delete Feedback WHERE CustomerID={customerID} ";  
                                                                           
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }

        }



    }
}

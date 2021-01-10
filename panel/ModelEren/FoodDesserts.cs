using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel.ModelEren
{
    class FoodDesserts
    {

        string Name;
        int FoodID;
        float price;

        public string Name1
        {
            get => Name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name is empty");
                }
                Name = value;
            }
        }


        public int FoodID1
        {
            get => FoodID; set
            {
                if (value < 0)
                {
                    throw new Exception("Id is empty");
                }
                FoodID = value;
            }
        }



        public float Price
        {
            get => price;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Price is empty");
                }
                price = value;

            }
        }

        public DataTable GetAllDeserts()        //Bunda Loginden farklı olarak tüm table ı okumak almak istiyoruz burası önemli
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
                    string query = "select * from FoodDesserts";     //Burda direkt yazdırdık tüm employeeleri
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




    }
}

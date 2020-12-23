using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;                             
using System.Text;
using System.Threading.Tasks;

namespace panel.Model //BU CLASSIN AMACI BİZİ EKSTRA FONKSİYONLARDAN KURTARSIN VERİ TABANI KONUSUNDA DİREKT OLARAK ÇAĞIRABİLELİM İSTİYORUZ
{                            //BU CLASS VE FONKSİYONLAR SADECE PARAMETRE ALIP TÜM İŞİ YAPICAK ve böylece temiz bir koda kavuşucaz diğer classlar içinde                   
     
   public static class dbHelper   //bundan nesne oluşturabilmeyi istemiyoruz ondan static tanımladık
    {
         
        //BU CLASS STATİC OLDUĞU İÇİN BU FONKSİYONDA STATİC OLMAK ZORUNDA
         
        //SHOW

        public static DataTable ExecuteQuery(string query)        
        {                                        
            SqlConnection connection = null;
            try
            {


                string conString = "Server = DESKTOP-HCPGI0N; Database = SMSBIM; Trusted_Connection = True";
                connection = new SqlConnection(conString);
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                        //Byrda
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                   
                }
                return null;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            finally               //BAĞLANTIYI AÇTIĞIMIZ GİBİ KAPATMAMIZDA LAZIM FİNALLYDE KAPATIYORUZ BUNU 
            {
                connection.Close();
            }


        }


        //DELETE UPDATE OR INSERT

        public static int ExecuteNonQuery(string query)
        {
            SqlConnection connection = null;
            try
            {


                string conString = "Server = DESKTOP-HCPGI0N; Database = SMSBIM; Trusted_Connection = True";
                connection = new SqlConnection(conString);
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    //Byrda
                    SqlCommand command = new SqlCommand(query, connection);
                    return command.ExecuteNonQuery();

                }
                else
                {
                    throw new Exception("Unable to Login");
                }
              
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            finally               //BAĞLANTIYI AÇTIĞIMIZ GİBİ KAPATMAMIZDA LAZIM FİNALLYDE KAPATIYORUZ BUNU 
            {
                connection.Close();
            }


        }





    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;                  //BUNLARI EKLEMEYİ UNUTMA DATA VE DATA.SQLCLİENT
using System.Data.SqlClient;

namespace panel.Models
{
    class Student : Person
    {

        private int studentID;
        int programID;

        float fees;
        
        //private static string address;

        public int StudentID { get => studentID; set => studentID = value; }
        public int ProgramID { get => programID; set => programID = value; }
        public float Fees { get => fees; set => fees = value; }

        public Student()
        {
            //Console.WriteLine("Student Constructor");
        }

        public Student(int studentID, string firstName, string lastName, 
            string gender, string email, string password, string address, int departmentID, int programID, float fees)
            
        {
            this.StudentID = studentID;
            this.ProgramID = programID;
            this.Fees = fees;
        }



        public void Display()
        {

            Console.WriteLine($"ID: {this.StudentID}\t Name: {this.FirstName} {this.LastName}");

        }


        public DataTable GetAllStudent()        //bu direkt employee den aldığım fonksiyonun aynısı altta sadece tek değişiklik var
        {                                        
                                                 
            SqlConnection connection = null;
            try
            {


                string conString = "Server = DESKTOP-HCPGI0N; Database = SMSBIM; Trusted_Connection = True";
                connection = new SqlConnection(conString);
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    string query = "select * from Student";     //Burda direkt yazdırdık tüm studentları tek farkı from Student yaptık
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

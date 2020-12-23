using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;                 //BUNLARI EKLEMEYİ UNUTMA DATA VE DATA.SQLCLİENT
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel.Models
{
    public class Employee : Person
    {

        int employeeID;
        float salary;

        public Employee()
        {
            
        }

        public Employee(int employeeID, float salary)
        {
            this.employeeID = employeeID;
            this.salary = salary;
        }

        public Employee(string firstName, string lastName, string gender, 
            string email, string password, string address, int departmentID, int employeeID, float salary)
            
        {

            this.EmployeeID = employeeID;
            this.Salary = salary;

        }

        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public float Salary { get => salary; set => salary = value; }

                                                                               //EN ÖNEMLİ FONKSİYON SQL E DAİR
        public override Person Login(string email, string password)
        {
            SqlConnection connection = null;     //İLK BAŞTA BURDA BUNU TANIMLAMAMIZ GEREKİYORKİ TÜM HEPSİ GÖRSÜN TRY CATCH FİNALLY
            try
            {
                 //connection string bizim sql serverımıza bağlanmak için kullandığımız string bu

                string conString = "Server = DESKTOP-HCPGI0N; Database = SMSBIM; Trusted_Connection = True";
                connection = new SqlConnection(conString);     //using System.Data.SqlClient; bunu import etmeliyiz unutma
                connection.Open();
              if (connection.State == System.Data.ConnectionState.Open)
              {   //BURDA DOLAR($"{nesne} ") İŞARETİ KOYARAK İÇİNE YAZMA YÖNTEMİ YAPTIK BU YÖNTEM ÖNEMLİ SQLE BÖYLECE EMAİL PASSWORD YAZDIRDIK
                     
                    string query = $"select * from Employee where email= '{email}' AND Password='{password}' ";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable dt = new DataTable();    //using System.Data; şart
                    adapter.Fill(dt); 

                    if (dt.Rows.Count>0)
                    {
                        Employee emp = new Employee();
                        emp.employeeID =int.Parse(dt.Rows[0]["EmployeeID"].ToString());
                        emp.FirstName= dt.Rows[0]["FirstName"].ToString();
                        emp.LastName = dt.Rows[0]["LastName"].ToString();
                        emp.Email = dt.Rows[0]["Email"].ToString();     //BURDA YAPTIĞIMIZ ŞEY BİR NESNE DÖNDÜRÜYORUZ CLASSDAN OLUŞTURUP VE EĞER NESNE BOŞ DEĞİLSE
                                                                        //TRUE VERİYOR LOGİN YAPIYORUZ FORM LOGİN İÇİNDE
                        return emp;
                    }            
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

        public DataTable GetAllEmployee()        //Bunda Loginden farklı olarak tüm table ı okumak almak istiyoruz burası önemli
        {                                        //Data grid view da göstermek istediğimiz için galiba DataTable türünde oldu o kısmı anlamadım
                                                 //10 aralık dersinin sonunda yapıyor bunu oldukça önemli görünüyor
            SqlConnection connection = null;    
            try
            {
                

                string conString = "Server = DESKTOP-HCPGI0N; Database = SMSBIM; Trusted_Connection = True";
                connection = new SqlConnection(conString);     
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {     
                    string query ="select * from Employee";     //Burda direkt yazdırdık tüm employeeleri
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    
                    DataTable dt = new DataTable();   
                    adapter.Fill(dt);
                    return dt;
                    //if (dt.Rows.Count > 0)
                    //{
                    //    Employee emp = new Employee();
                    //    emp.employeeID = int.Parse(dt.Rows[0]["EmployeeID"].ToString());
                    //    emp.FirstName = dt.Rows[0]["FirstName"].ToString();
                    //    emp.LastName = dt.Rows[0]["LastName"].ToString();
                    //    emp.Email = dt.Rows[0]["Email"].ToString();                                                    
                    //    return emp;
                    //}
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

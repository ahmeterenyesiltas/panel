using panel.Model;
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
         string firstname;
         string lastname;
         string email;
         string gender;
         string password;
         int DepartmentID;

        

        public Employee()
        {
            
        }


        public int EmployeeID { get => employeeID;
            set {
                if (value<0)
                {
                    throw new Exception("ID is empty");
                }
                employeeID = value;
            }
        }


        public float Salary { get => salary;
            set {
                if (value<0)
                {
                    throw new Exception("Salary is Empty");
                }

                salary = value; 
            }
        }


        public string Firstname { get => firstname;
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Firstname is Empty");
                }
                firstname = value; 
            
            }
        }

        public string Lastname { get => lastname; set {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Lastname is Empty");
                }

                lastname = value; 
            } 
        
        }

        public string Email1 { get => email; 
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Email is Empty");
                }
                email = value; 
            } 
        }

        public string Gender1 { get => gender;

            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Gender is Empty");
                }
                gender = value; 
            }
        }

        public string Password1 { get => password; 
            set {
                if (string.IsNullOrWhiteSpace(value))
                {

                }

                password = value; 
            }
        }


        public int DepartmentID1 { get => DepartmentID;
            set {
                if (value < 0)
                {
                    throw new Exception("Department ID is empty");
                }

                DepartmentID = value; 
            }
        }

        

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

                    if (dt.Rows.Count > 0)
                    {
                        Employee emp = new Employee();
                        emp.employeeID = int.Parse(dt.Rows[0]["EmployeeID"].ToString());
                        emp.FirstName = dt.Rows[0]["FirstName"].ToString();
                        emp.LastName = dt.Rows[0]["LastName"].ToString();
                        emp.Email = dt.Rows[0]["Email"].ToString();     //BURDA YAPTIĞIMIZ ŞEY BİR NESNE DÖNDÜRÜYORUZ CLASSDAN OLUŞTURUP VE EĞER NESNE BOŞ DEĞİLSE
                        emp.salary = float.Parse(dt.Rows[0]["Salary"].ToString());
                        emp.gender = dt.Rows[0]["Gender"].ToString();                                                //TRUE VERİYOR LOGİN YAPIYORUZ FORM LOGİN İÇİNDE
                        emp.password = dt.Rows[0]["Password"].ToString();
                        emp.DepartmentID = int.Parse(dt.Rows[0]["DepartmentID"].ToString());

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


        public DataTable GetEmployeeByID(int id)        //Bunda Loginden farklı olarak tüm table ı okumak almak istiyoruz burası önemli
        {                                        //Data grid view da göstermek istediğimiz için galiba DataTable türünde oldu o kısmı anlamadım
                                                 //10 aralık dersinin sonunda yapıyor bunu oldukça önemli görünüyor

            try
            {
                string query = $"select * from Employee where EmployeeID={id}";     //Burda id ye göre değer aldık burası çok önemliiiiiiiiiiiii
                return dbHelper.ExecuteQuery(query);

               
            }


            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }

        }


        public DataTable GetEmployeeByName(string name)        //Bunda Loginden farklı olarak tüm table ı okumak almak istiyoruz burası önemli
        {                                        //Data grid view da göstermek istediğimiz için galiba DataTable türünde oldu o kısmı anlamadım
                                                 //10 aralık dersinin sonunda yapıyor bunu oldukça önemli görünüyor   

            SqlConnection connection = null;
            try
            {
                string query = $"Select * from Employee where FirstName LIKE '%{name}%' ";
                return dbHelper.ExecuteQuery(query);

            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }

        }

        private static bool EmployeeExists(string name)
        {


            SqlConnection connection = null;
            try
            {
                string query = $"Select * from Employee where FirstName+LastName= '{name}' "; //bu direkt equals (=) isim direkt buna eşit olmalı yani
                return dbHelper.ExecuteQuery(query).Rows.Count >= 1; //eğer böyle bir course varsa yani aynı addan bir course daha eklemek istemeyiz o yüzden true döndürcez ve varsa hata verdiricez 
                                                                     //oldukca önemli ve elzem birşey bu
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }

        }

        public int EmployeeAdd(Employee e)
        {

            SqlConnection connection = null;
            try
            {
                if (EmployeeExists(e.Firstname+e.lastname))                            //Burda bir üstte tanımladığımız fonksiyonu kullanıp denedik eğer course var ve true dönerse hata gönder
                {
                    throw new Exception("Employee already Exits");
                }
               
                else 
                { 
                string query = $"INSERT INTO Employee(FirstName,LastName,Email,Password,Salary,Gender,DepartmentID) VALUES('{e.Firstname}','{e.Lastname}'," +
                    $"'{e.Email1}','{e.Password1}','{e.Salary}','{e.Gender1}','{e.DepartmentID1}')";  
                                                                                         //BU BAYA ÖNEMLİ ELLE EKLEME YAPIYORUZ
                                                                                            //Burda $ işareti ve {} kullanımı işimizi baya kolaylaştırıyor unutma bu yzma yöntemini
                return dbHelper.ExecuteNonQuery(query);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public int EmployeeDelete(int eID)   //silmek için sadece ID yeterli Delete Course where ID=5 yapabiliriz silmek için örneğin
        {

            SqlConnection connection = null;
            try
            {
                string query = $"Delete Employee WHERE EmployeeID={eID} ";  //BU BAYA ÖNEMLİ ELLE DELETE YAPIYORUZ
                                                                        //Burda $ işareti ve {} kullanımı işimizi baya kolaylaştırıyor unutma bu yzma yöntemini
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }

        }


    }
}

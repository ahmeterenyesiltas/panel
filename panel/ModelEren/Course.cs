using panel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel.Models
{
   public class Course
    {

        private int courseID;
        private string name;
        private int credit;
         
        public int CourseID { get => courseID; set => courseID = value; }
        
        public string Name { get => name;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Course name is empty.");
                }

                name = value;

            }
        
        }
        
        public int Credit { get => credit;
            set
            {
                if(value<0)
                {
                    throw new Exception("Course Credit cannot be negative.");
                }

                credit = value;
            
            }    
        }



        public DataTable GetAllCourse()        //Bunda Loginden farklı olarak tüm table ı okumak almak istiyoruz burası önemli
        {                                        //Data grid view da göstermek istediğimiz için galiba DataTable türünde oldu o kısmı anlamadım
                                                 //10 aralık dersinin sonunda yapıyor bunu oldukça önemli görünüyor
            
            try
            {
                   string query = "select * from Course";     //Burda direkt yazdırdık tüm employeeleri
                return dbHelper.ExecuteQuery(query);       //BURDA DİREKT YAZDIĞIMIZ dbHelper classındaki fonksiyonu kullandık sadece
                                                           //OBJECT ORİENTED PROGRRAMMİNG YAPTIK KISACA
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }

        }

        public DataTable GetCourseByID(int id)        //Bunda Loginden farklı olarak tüm table ı okumak almak istiyoruz burası önemli
        {                                        //Data grid view da göstermek istediğimiz için galiba DataTable türünde oldu o kısmı anlamadım
                                                 //10 aralık dersinin sonunda yapıyor bunu oldukça önemli görünüyor
            
            try
            {
                  string query = $"select * from Course where CourseID={id}";     //Burda id ye göre değer aldık burası çok önemliiiiiiiiiiiii
                return dbHelper.ExecuteQuery(query);


            }
                
            
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }

        }

        public DataTable GetCourseByName(string name)        //Bunda Loginden farklı olarak tüm table ı okumak almak istiyoruz burası önemli
        {                                        //Data grid view da göstermek istediğimiz için galiba DataTable türünde oldu o kısmı anlamadım
                                                 //10 aralık dersinin sonunda yapıyor bunu oldukça önemli görünüyor   

            SqlConnection connection = null;
            try
            {
                string query = $"select * from Course where Name LIKE '%{name}%' "; 
                return dbHelper.ExecuteQuery(query);

            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }

        }

        private static bool CourseExists(string name)        
        {                                        
                                                   

            SqlConnection connection = null;
            try
            {
                string query = $"select * from Course where Name = '{name}' "; //bu direkt equals (=) isim direkt buna eşit olmalı yani
                return dbHelper.ExecuteQuery(query).Rows.Count>=1; //eğer böyle bir course varsa yani aynı addan bir course daha eklemek istemeyiz o yüzden true döndürcez ve varsa hata verdiricez 
                                                                   //oldukca önemli ve elzem birşey bu
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }

        }

        public int CourseAdd(Course c)        
        {                                           

            SqlConnection connection = null;
            try
            {
                if (CourseExists(c.Name))                            //Burda bir üstte tanımladığımız fonksiyonu kullanıp denedik eğer course var ve true dönerse hata gönder
                {
                    throw new Exception("Course already Exits");
                }
                
                string query = $"INSERT INTO Course(Name,Credit) VALUES('{c.Name}','{c.Credit}' ) ";  //BU BAYA ÖNEMLİ ELLE EKLEME YAPIYORUZ
                                                                                                     //Burda $ işareti ve {} kullanımı işimizi baya kolaylaştırıyor unutma bu yzma yöntemini
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public int CourseUpdate(Course c)
        {

            SqlConnection connection = null;
            try
            { 
                
               /*ÇOKKKKKK ÖNEMLİ BURDA DİKKAT ET İÇERLERE HEP c.Name c.Credit c.CourseID YAZDIM c.name vb. değil çünkü bunlar private
                biz ise aşşağıya metodları yani büyük olanları get set ile yaptıklarımızı yazıyoruz bu yüzden baya önemli */

                string query = $"UPDATE Course SET NAME = '{c.Name}', Credit ={c.Credit} WHERE CourseID= {c.CourseID} ";  
                                                                                        //BU BAYA ÖNEMLİ ELLE UPDATE YAPIYORUZ
                                                                       //Burda $ işareti ve {} kullanımı işimizi baya kolaylaştırıyor unutma bu yzma yöntemini
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }

        }

        public int CourseDelete(int cID)   //silmek için sadece ID yeterli Delete Course where ID=5 yapabiliriz silmek için örneğin
        {

            SqlConnection connection = null;
            try
            {
                string query = $"Delete Course WHERE CourseID={cID} ";  //BU BAYA ÖNEMLİ ELLE DELETE YAPIYORUZ
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

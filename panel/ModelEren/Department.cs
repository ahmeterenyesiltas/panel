using System;
using System.Collections.Generic;
using System.Data;                           //BUNLARI EKLEMEYİ UNUTMA DATA VE DATA.SQLCLİENT
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel.Models
{
    class Department
    {

        int DepartmentID; //PK

        string name;

        public Department()     //DEFAULT BİR CONSTRUCTOR GEREKTİ *Department dprt = new Department();* işlemi için örneğin
        {

        }

        public Department(int DepartmentId, string name)
        {
            this.DepartmentID = DepartmentId;
            this.name = name;
        }

        public DataTable GetAllDepartment()        //bu direkt employee den aldığım fonksiyonun aynısı altta sadece tek değişiklik var
        {

            SqlConnection connection = null;
            try
            {


                string conString = "Server=94.73.144.8;Database=u8846052_DBRMS01;User Id=u8846052_RMS01;Password=TYgv18I1HFbi19X;";
                connection = new SqlConnection(conString);
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    string query = "select * from Department";     //Burda direkt yazdırdık tüm Departmentları tek farkı from Department yaptık
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

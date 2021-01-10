using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel
{
    public static class dbMain
    {



        //select
        public static DataTable ExecuteQuery(string query)
        {

            SqlConnection connection = null;

            try
            {
                string conString = "Server=94.73.144.8;Database=u8846052_DBRMS01;User Id=u8846052_RMS01;Password=TYgv18I1HFbi19X;";
                //Server=94.73.144.8;Database=u8846052_DBRMS01;User Id=u8846052_RMS01;Password=TYgv18I1HFbi19X;

                connection = new SqlConnection(conString);

                connection.Open();

                if (connection.State == System.Data.ConnectionState.Open)
                {

                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    return dt;

                }

                return null;

            }

            catch (Exception)
            {

                throw new Exception("Error in Viewing!");
            }

            finally
            {
                connection.Close();
            }
        }

        //insert or update or delete

        public static int ExecuteNonQuery(string query)
        {

            SqlConnection connection = null;

            try
            {
                string conString = "Server=94.73.144.8;Database=u8846052_DBRMS01;User Id=u8846052_RMS01;Password=TYgv18I1HFbi19X;";

                connection = new SqlConnection(conString);

                connection.Open();

                if (connection.State == System.Data.ConnectionState.Open)
                {

                    SqlCommand command = new SqlCommand(query, connection);
                    
                    return command.ExecuteNonQuery();

                }

                else
                {
                    throw new Exception("Error!");
                }

            }

            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }

            finally
            {
                connection.Close();
            }
        }



    }
}

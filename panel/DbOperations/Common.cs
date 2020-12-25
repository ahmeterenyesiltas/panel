﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel.DbOperations
{
    public class Common
    {

        /// <summary>
        /// Sql Bağlantı Stringi
        /// </summary>
        SqlConnection SqlConnection = new SqlConnection("Server=94.73.144.8;Database=u8846052_DBRMS01;User Id=u8846052_RMS01;Password=TYgv18I1HFbi19X;");

        /// <summary>
        /// Hata oluştuğu zaman, DB'ye kayıt atan metod.
        /// </summary>
        public void AddLogError(string MethodName, string Header,string Content)
        { 
        
        }

        /// <summary>
        /// Müşterileri listeleyen metod.
        /// </summary>
        /// <returns>DataTable nesnesi döndürür</returns>
        public DataTable MusterileriGoruntule()
        {
            try
            {
                //Bağlantı Kapalı ise Açılır
                if (SqlConnection.State == ConnectionState.Closed) SqlConnection.Open();
                string SqlBase = "SELECT * FROM MUSTERILER";
                SqlDataAdapter SqlDa = new SqlDataAdapter(SqlBase, SqlConnection);
                DataTable dt = new DataTable();
                SqlDa.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    SqlDa.Dispose();
                    return dt;
                }
                else
                {
                    SqlDa.Dispose();
                    return new DataTable();
                }
            }
            catch (Exception exc)
            {
                AddLogError("MusterileriGoruntule", "Müşterileri Görüntüleme Hatası", "Hata Detayı : " + exc.Message);
                throw ;
            }
            finally 
            {
                //Bağlantı Açık ise Kapanır
                if (SqlConnection.State == ConnectionState.Open) SqlConnection.Close();
            }
        }




    }
}

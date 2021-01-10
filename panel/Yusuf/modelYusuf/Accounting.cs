using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel
{
    class Accounting
    {

        int entryID;

        string entryName;

        string entryMType;

        string entryType;

        int entryAmount;    

        public int EntryID { get => entryID; set => entryID = value; }
        public string EntryName
        {
            get => EntryName;

            set

            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Entry Name cannot be EMPTY!");
                }

                EntryName = value;

            }

        }
        public string EntryMType
        {
            get => EntryMType;

            set

            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Entry Main Type cannot be EMPTY!");
                }

                EntryMType = value;

            }

        }
        public string EntryType
        {
            get => EntryType;

            set

            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Entry Type cannot be EMPTY!");
                }

                EntryType = value;

            }

        }
        public int EntryAmount
        {
            get => EntryAmount;

            set

            {

                if (value < 0)
                {
                    throw new Exception("Entry Amount cannot be NEGATIVE!");
                }

                EntryAmount = value;

            }
        }



        public DataTable GetAllAccount()
        {
            try
            {

                string query = $"select * from Accounting";

                return dbMain.ExecuteQuery(query);

            }

            catch (Exception)
            {

                throw new Exception("Error in Viewing All Accounts!");
            }
        }

        private static bool AccountExists(int EntryID)
        {
            try
            {

                string query = $"select * from Accounting where EntryID = '{EntryID}'";

                return dbMain.ExecuteQuery(query).Rows.Count >= 1;

            }

            catch (Exception)
            {

                throw new Exception("Error!"); //Tekrar dönülecek!
            }
        }

        public int AddAccount(Accounting A1)
        {
            try
            {
                if (AccountExists(A1.EntryID))
                {
                    throw new Exception("Entry already EXISTS!");
                }

                string query = $"insert into Accounting(EntryName, EntryMType, EntryType, EntryAmount)" +
                    $" values ('{A1.EntryName}', '{A1.EntryMType}', '{A1.EntryType}', '{A1.EntryAmount}')";

                return dbMain.ExecuteNonQuery(query);

            }

            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }
        }

        public int UpdateAccount(Accounting A1)
        {
            try
            {

                string query = $"update Car set EntryName = {A1.EntryName}, EntryMType = '{A1.EntryMType}'," +
                    $"EntryType = '{A1.EntryType}', EntryAmount = '{A1.EntryAmount}' where CarID = {A1.EntryID}";

                return dbMain.ExecuteNonQuery(query);

            }

            catch (Exception)
            {

                throw new Exception("Error in Uptade The Account!");
            }
        }

        public int DeleteCar(int EntryID)
        {
            try
            {

                string query = $"Delete Account where CarID = {EntryID}";

                return dbMain.ExecuteNonQuery(query);

            }

            catch (Exception)
            {

                throw new Exception("Error in Delete The Account!");
            }
        }
    }
}

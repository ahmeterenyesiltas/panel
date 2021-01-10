using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel
{
    class Announcement
    {



        int announcementID;

        string announcementName;

        string announcementText;

        public int AnnouncementID { get => announcementID; set => announcementID = value; }

        public string AnnouncementName
        {
            get => announcementName;

            set

            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Announcement Name cannot be EMPTY!");
                }

                announcementName = value;

            }

        }

        public string AnnouncementText
        {
            get => announcementText;

            set

            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Announcement Text cannot be EMPTY!");
                }

                announcementText = value;

            }

        }

        public DataTable GetAllAnnouncement()
        {
            try
            {

                string query = $"select * from Announcement";

                return dbMain.ExecuteQuery(query);

            }

            catch (Exception)
            {

                throw new Exception("Error in Viewing All Announcements!");
            }
        }

        private static bool AnnouncementExists(string AnnouncementName)
        {
            try
            {

                string query = $"select * from Announcement where AnnouncementName = '{AnnouncementName}'";

                return dbMain.ExecuteQuery(query).Rows.Count >= 1;

            }

            catch (Exception)
            {

                throw new Exception("Error!"); //Tekrar dönülecek!
            }
        }

        public int AddAnnouncement(Announcement A1)
        {
            try
            {
                if (AnnouncementExists(A1.AnnouncementName))
                {
                    throw new Exception("Announcement already EXISTS!");
                }

                string query = $"insert into Announcement(AnnouncementName, AnnouncementText) " +
                    $"values ('{A1.AnnouncementName}', '{A1.AnnouncementText}')";

                return dbMain.ExecuteNonQuery(query);

            }

            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }
        }

        public int UpdateAnnouncement(Announcement A1)
        {
            try
            {

                string query = $"update Announcement set AnnouncementName = '{A1.AnnouncementName}'," +
                    $" AnnouncementText = '{A1.AnnouncementText}' where AnnouncementID = {A1.AnnouncementID}";

                return dbMain.ExecuteNonQuery(query);

            }

            catch (Exception)
            {

                throw new Exception("Error in Uptade The Announcement!");
            }
        }

        public int DeleteAnnouncement(int AnnouncementID)
        {
            try
            {

                string query = $"Delete Announcement where AnnouncementID = {AnnouncementID}";

                return dbMain.ExecuteNonQuery(query);

            }

            catch (Exception)
            {

                throw new Exception("Error in Delete The Announcement!");
            }
        }



    }
}

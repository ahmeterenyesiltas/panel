using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel
{
    class Campaign
    {



        int campaignID;

        string campaignName;

        int discountRate;

        DateTime startDate;
        DateTime finishDate;



        public int CampaignID { get => campaignID; set => campaignID = value; }

        public string CampaignName
        {
            get => campaignName;

            set

            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Campaign Name cannot be EMPTY!");
                }

                campaignName = value;

            }

        }

        public int DiscountRate
        {
            get => discountRate;

            set

            {

                if (value < 0)
                {
                    throw new Exception("Campaign Discount cannot be NEGATIVE!");
                }

                discountRate = value;

            }
        }

        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime FinishDate { get => finishDate; set => finishDate = value; }

        public DataTable GetAllCampaign()
        {
            try
            {

                string query = $"select * from Campaign";

                return dbMain.ExecuteQuery(query);

            }

            catch (Exception)
            {

                throw new Exception("Error in Viewing All Campaigns!");
            }
        }

        private static bool CampaignExists(string CampaignName)
        {
            try
            {

                string query = $"select * from Campaign where CampaignName = '{CampaignName}'";

                return dbMain.ExecuteQuery(query).Rows.Count >= 1;

            }

            catch (Exception)
            {

                throw new Exception("Error!"); //Tekrar dönülecek!
            }
        }

        public int AddCampaign(Campaign C1)
        {
            try
            {
                if (CampaignExists(C1.CampaignName))
                {
                    throw new Exception("Campaign already EXISTS!");
                }

                string sqlStartDate = C1.StartDate.ToString("yyyy-MM-dd HH:mm:ss");
                string sqlFinishDate = C1.FinishDate.ToString("yyyy-MM-dd HH:mm:ss");

                string query = $"insert into Campaign(CampaignName, DiscountRate, StartDate, FinishDate)" +
                    $" values ('{C1.CampaignName}', {C1.DiscountRate}, '{sqlStartDate}', '{sqlFinishDate}')";

                return dbMain.ExecuteNonQuery(query);

            }

            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }
        }

        public int UpdateCampaign(Campaign C1)
        {
            try
            {

                string query = $"update Campaign set CampaignName = '{C1.CampaignName}', DiscountRate = {C1.DiscountRate} where CampaignID = {C1.CampaignID}";

                return dbMain.ExecuteNonQuery(query);

            }

            catch (Exception)
            {

                throw new Exception("Error in Uptade The Campaign!");
            }
        }

        public int DeleteCampaign(int CampaignID)
        {
            try
            {

                string query = $"Delete Campaign where CampaignID = {CampaignID}";

                return dbMain.ExecuteNonQuery(query);

            }

            catch (Exception)
            {

                throw new Exception("Error in Delete The Campaign!");
            }
        }



    }
}

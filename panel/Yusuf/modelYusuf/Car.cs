using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel
{
    class Car
    {

        int carID;
        int parkingNo;

        string numberPlate;

        float hourRate;

        DateTime startTime;
        DateTime finishTime;

        public int CarID { get => carID; set => carID = value; }

        public int ParkingNo
        {
            get => parkingNo;

            set

            {

                if (value < 0)
                {
                    throw new Exception("Parking No cannot be NEGATIVE!");
                }

                parkingNo = value;

            }
        }

        public string NumberPlate
        {
            get => numberPlate;

            set

            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Number Plate cannot be EMPTY!");
                }

                numberPlate = value;

            }

        }

        public float HourRate
        {
            get => hourRate;

            set

            {

                if (value < 0)
                {
                    throw new Exception("Parking No cannot be NEGATIVE!");
                }

                hourRate = value;

            }
        }

        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime FinishTime { get => finishTime; set => finishTime = value; }

        public DataTable GetAllCar()
        {
            try
            {

                string query = $"select * from Car";

                return dbMain.ExecuteQuery(query);

            }

            catch (Exception)
            {

                throw new Exception("Error in Viewing All Cars!");
            }
        }

        private static bool CarExists(string NumberPlate)
        {
            try
            {

                string query = $"select * from Car where NumberPlate = '{NumberPlate}'";

                return dbMain.ExecuteQuery(query).Rows.Count >= 1;

            }

            catch (Exception)
            {

                throw new Exception("Error!"); //Tekrar dönülecek!
            }
        }

        public int AddCar(Car C1)
        {
            try
            {
                if (CarExists(C1.NumberPlate))
                {
                    throw new Exception("Car already EXISTS!");
                }

                string sqlStartTime = C1.StartTime.ToString("yyyy-MM-dd  HH:mm:ss");
                string sqlFinishTime = C1.FinishTime.ToString("yyyy-MM-dd  HH:mm:ss");

                string query = $"insert into Car(ParkingNo, NumberPlate, HourRate, StartTime, FinishTime)" +
                    $" values ({C1.ParkingNo}, '{C1.NumberPlate}', {C1.HourRate}, '{sqlStartTime}', '{sqlFinishTime}')";

                return dbMain.ExecuteNonQuery(query);

            }

            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }
        }

        public int UpdateCar(Car C1)
        {
            try
            {

                string sqlStartTime = C1.StartTime.ToString("yyyy-MM-dd  HH:mm:ss");
                string sqlFinishTime = C1.FinishTime.ToString("yyyy-MM-dd  HH:mm:ss");

                string query = $"update Car set ParkingNo = {C1.ParkingNo}, NumberPlate = '{C1.NumberPlate}'," +
                    $"HourRate = {C1.HourRate}, StartTime = '{sqlStartTime}', FinishTime = '{sqlFinishTime}'  where CarID = {C1.CarID}";

                return dbMain.ExecuteNonQuery(query);

            }

            catch (Exception)
            {

                throw new Exception("Error in Uptade The Car!");
            }
        }

        public int DeleteCar(int CampaignID)
        {
            try
            {

                string query = $"Delete Car where CarID = {CarID}";

                return dbMain.ExecuteNonQuery(query);

            }

            catch (Exception)
            {

                throw new Exception("Error in Delete The Car!");
            }
        }

    }
}

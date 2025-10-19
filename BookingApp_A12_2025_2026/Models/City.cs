using System.Data.OleDb;

namespace BookingApp_A12_2025_2026.Models
{
    public class City
    {
        //رقم تسلسلي تلقائي
        public int City_Id { get; set; }
        //اسم المدينة
        public string City_Name { get; set; }
        //مثلا القدس: lat: 31.7683, lng: 35.2137
        public string City_Location { get; set; }
        //عنوان صورة للمدينة
        public string City_Photo { get; set; }
        //عنوان فيديو يوتيوب..يكفي قيمة v
        public string City_Video { get; set; }
        //هل المدينة امنة
        public bool City_IsSafe { get; set; }
        //شرح حول المدينة
        public string City_Description { get; set; }

        public static int GetTotalCities()
        {
            string sql = "select اسم_الدالة_التجميعية(* او اسم العمود) from اسم_الجدول";
            //ارتبط بقاعدة البيانات واحضر العدد الكلي للمدن
            Connector cn = new Connector(Configs.DataBaseLocation);
            int total= cn.RunScalar("SELECT COUNT(*) from Cities");
            return total;

            
        }


        public static List<City> GetAllCitiesFromDB()
        {
            List<City> cities = new List<City>();
            Connector cn=new Connector(Configs.DataBaseLocation);
            string sql = "select * from Cities";
            OleDbDataReader result=cn.RunSelect(sql);
            if (result == null)
                return null;
            while(result.Read())
            {
                City c1 = new City
                {
                    City_Id = int.Parse(result["City_Id"].ToString())
                    ,City_Name = result["City_Name"].ToString()
                    ,City_IsSafe= bool.Parse(result["City_IsSafe"].ToString())
                    ,City_Description= result["City_Description"].ToString()
                    ,City_Location= result["City_Location"].ToString()
                    ,City_Photo= result["City_Photo"].ToString()
                    ,City_Video = result["City_Video"].ToString()
                };
                cities.Add(c1);
            }
            cn.CloseConnection();
            return cities;
        }

        public static List<City> GetAllCities()
        {
            List<City> cities = new List<City>();
            //read from database
            Connector cn = new Connector(Configs.DataBaseLocation);
            string sql = "select * from Cities";
            OleDbDataReader result = cn.RunSelect(sql); /// matrix כאילו مصفوفة ثنائية
            if (result == null)
            {
                //City.MyError = cn.GetError();
                return null;
            }
            while (result.Read())
            {
                City c1 = new City
                {
                    City_Id = int.Parse(result["city_Id"].ToString())
                    ,
                    City_Name = result["City_Name"].ToString()
                    ,
                    City_Photo = result["City_Photo"].ToString()
                    ,
                    City_Video = result["City_Video"].ToString()
                    ,
                    City_Description = result["City_Description"].ToString()
                    ,
                    City_Location = result["City_Location"].ToString()
                    ,
                    City_IsSafe = bool.Parse(result["City_IsSafe"].ToString())
                 };

                cities.Add(c1);

            }
            cn.CloseConnection(); ///Must Close
            return cities;
        }

        public static int DeleteCityById(int City_Id)
        {
            string sql = "delete from Cities where City_Id="+City_Id;
            Connector cn=new Connector(Configs.DataBaseLocation);
            int x = cn.RunUpdateInsertDelete(sql);
            return x;

        }



        public static City GetCityById(int City_Id)
        {
            City ct = null;
           string sql= "select * from Cities where City_Id=" + City_Id;
            Connector cn= new Connector(Configs.DataBaseLocation);
            OleDbDataReader result= cn.RunSelect(sql);
            if (result == null)
            {
                //City.MyError = cn.GetError();
                return null;
            }
            while (result.Read())
            {
                ct = new City
                {
                    City_Id = int.Parse(result["city_Id"].ToString())
                    ,
                    City_Name = result["City_Name"].ToString()
                    ,
                    City_Photo = result["City_Photo"].ToString()
                    ,
                    City_Video = result["City_Video"].ToString()
                    ,
                    City_Description = result["City_Description"].ToString()
                    ,
                    City_Location = result["City_Location"].ToString()
                    ,
                    City_IsSafe = bool.Parse(result["City_IsSafe"].ToString())
                };
            }

            return ct;
        }

    }


}

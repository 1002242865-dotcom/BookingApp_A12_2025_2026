using BookingApp_A12_2025_2026.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookingApp_A12_2025_2026.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TestHotelMethods()
        {
            string str = "skill1, skill2,skill3";
            var skills = str.Split(',').Select(s => s.Trim()).ToList();
            //1 Test GetAllHotelsFromDB
            //List<Hotel> holtels = Hotel.GetAllHotelsFromDB();

            //////2 test GetHotelsByCityId
            //Hotel h1 = new Hotel
            //{
            //    City_Id = 1,
            //    Hotel_Name = "A12 Test Hotel",
            //    Hotel_Stars = 4,
            //    Hotel_Photo = "test_photo.jpg",
            //    Hotel_Video = "test_video.mp4",
            //    Hotel_Description = "This is a test hotel.",
            //    Hotel_Lat = 25.276987,
            //    Hotel_Lng = 55.296249,
            //    Hotel_Phone = "+1234567890",
            //    Hotel_Username = "testuser",
            //    Hotel_Password = "testpass",
            //    Hotel_Status = 1
            //};
            //int newHotelId = Hotel.AddNewHotel(h1);

            //3 test DeleteHotelById
            //int x = Hotel.DeleteHotelById(15);

            //4+5 test GetHotelById & UpdateHotel
            //Hotel h2 = Hotel.GetHotelById(7);
            //h2.Hotel_Name += " Updated Hotel Name";
            //h2.Hotel_Description += DateTime.Now.ToLongTimeString();
            //int y = Hotel.UpdateHotel(h2);

            //6 test GetAllHotelByCityId
            // List<Hotel> hotelsInCity = Hotel.GetHotelsByCityId(2);

            //7 test search by name and stars
            //List<Hotel> searchedHotels = Hotel.SearchByHotelNameAndStars("abr", 5);

            return View();
        }   
    }
}

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
            List<Hotel> holtels = Hotel.GetAllHotelsFromDB();

            //Hotel h1=new Hotel
            //{
            //    City_Id = 1,
            //    Hotel_Name = "Test Hotel",
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

            int x = Hotel.DeleteHotelById(2);

            return View();
        }   
    }
}

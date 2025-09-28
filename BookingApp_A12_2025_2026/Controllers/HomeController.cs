using System.Diagnostics;
using BookingApp_A12_2025_2026.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookingApp_A12_2025_2026.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            ////
            var gemini = new GeminiService();
            List<Student> students = Student.GetDemoStudents();
            var listText = string.Join("\n- ", students);
            var prompt = $"هذه قائمة طلاب:\n- {listText}\n\nهل يمكنك ترتيبهم أبجدياً حسب الاسم وعرضهم في جدول؟";
           //prompt = "write short story in arabic for 4th class";
            //prompt = "just the final outpot int x=10; int y=9; c.wl(x*y);";
            //prompt = "just the final number: كم كالوري في ساندويش فلافل";
            //prompt = "just the final number: كم كالوري في صحن كبير من مقلوبة فلسطينية";
            //prompt = "show just the final number of calories: كم كالوري في باجيت متوسط مع 250 غرام شوراما";
            //prompt = "no details' just show th final amount of calories: شربت كاس نسكافيه مكون من 200 ملم حليب وملعقتين نس وملعقة عسل صغيرة";



            var result = await gemini.AskAsync(prompt);

            ViewBag.Prompt = prompt;
            ViewBag.Response = result;
            ////

            Student st1 = new Student
            {
                Id = 100,
                Name = "Omar",
                Sora="Photos/st11.png"
            };

            ViewBag.st1 = st1;

              return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Index1()
        {
            return View();
        }

        public IActionResult ShowStudents()
        {

            List<Student> students = Student.GetDemoStudents();
            ViewBag.students = students;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

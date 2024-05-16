using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            //ViewBag.selamlama = saat > 12 ? "iyi günler" : "Günaydın";
            //ViewBag.userName = "Yusuf Ali";

            ViewData["Selamlama"]= saat > 12 ? "iyi günler" : "Günaydın";
            int  UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
            //ViewData["UserName"] = "Yusuf Ali";


            var MeetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location="İstanbul abc kongre merkezi",
                Date=new DateTime(2024,01,20,20,0,0),
                NumberOfPeople = UserCount
            };


            return View(MeetingInfo);
        }
    }
}

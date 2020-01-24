using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneAplication.Models;


namespace PhoneAplication.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult Index()
        {
            var PhoneList = new List<phone>
            {
                new phone {PhoneName= "iphone pro", Manufaturer = "Apple", MSRP = "xyz", DateReleased = new DateTime(2020,02,06), ScreenSize = 4} ,
                new phone {PhoneName= "Xperia 10 plus", Manufaturer = "Sony", MSRP = "xyz", DateReleased = new DateTime(2020,02,06), ScreenSize =6},
                new phone {PhoneName= "Mogli420", Manufaturer = "Mogli", MSRP = "xyz", DateReleased = new DateTime(2020,10,16), ScreenSize =4},
                new phone {PhoneName= "S10", Manufaturer = "Samsung", MSRP = "xyz", DateReleased = new DateTime(2020,04,26), ScreenSize = 7 },

            };
            return View(PhoneList);
        }
    }
}
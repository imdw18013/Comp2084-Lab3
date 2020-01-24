using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneAplication.Models
{
    public class phone
    {
        public phone()
        {
            PhoneName = "";
            Manufaturer = "";
            DateReleased = new DateTime();
        }
        public int PhoneId { get; set; }
        public string PhoneName { get; set; }
        public string Manufaturer { get; set; }
        public string MSRP { get; set; }
        public int ScreenSize { get; set; }
        public DateTime DateReleased { get; set; }
    }

}
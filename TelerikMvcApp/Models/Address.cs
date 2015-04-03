using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelerikMvcApp.Models
{
    public class Address
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        // Used for State
        public string Region { get; set; }
        public string ZipCode { get; set; }
    }
}
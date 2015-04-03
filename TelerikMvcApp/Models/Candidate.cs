using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelerikMvcApp.Models
{
    public class Candidate : PersonBase
    {
        private string _firstName;
        private string _lastName;
        private string _email;

        public string FirstName { get; set; }

        public string LastName { get; set; }  
        public string FullNameReverse
        {
            get { return LastName.Trim() + ", " + FirstName; }
        }
        public string FullName
        {
            get { return FirstName.Trim() +" " + LastName.Trim(); }
        }

        public string Email { get; set; }
        

        
        public Address Address { get; set; }
        
        public string Phone { get; set; }

        ICollection<Qualification> Qualifications { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelerikMvcApp.Models
{
    public class Candidate : EntityBase
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }  
        public string Email { get; set; }
        public string Phone { get; set; }

        public Address Address { get; set; }

        
        public DateTime ?DateEnteredSystem { get; set; }

        public virtual ICollection<Qualification> Qualifications { get; set; }

        public Candidate()
        {
            Qualifications = new List<Qualification>();
        }
    }
}
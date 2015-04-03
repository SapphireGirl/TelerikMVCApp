using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TelerikMvcApp.Models;

namespace TelerikMvcApp.ViewModels
{
    public class CandidateViewModel
    {
        
        public int Id { get; set; }

        [Display(Name = "First Name: ")]
        [Required(ErrorMessage = "Please Enter a First Name")]
       // [MaxLength(15, ErrorMessage = "First Name must be less than 15 characters")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name: ")]
        [Required(ErrorMessage = "Please Enter a Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email address: ")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "Phone: ")]
        [Required(ErrorMessage = "The phone number is required")]
        public string Phone { get; set; }

        public Address Address { get; set; }

        

        public Qualification Qualification { get; set; }

        public IList<string> TypeOfQualifications { get; set; }

        public CandidateViewModel()
        {
            TypeOfQualifications = new List<string>();    
            TypeOfQualifications.Add("College Degree");
            TypeOfQualifications.Add("Profession Certification");
            TypeOfQualifications.Add("Work Experience");
            
          
        }
    }
}
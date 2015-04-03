using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelerikMvcApp.Models
{
    public class Qualification
    {
        public TypeOfQualifications Type { get; set; }
        public string Name { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateEnded { get; set; }

        public DateTime DateCompleted { get; set; }
        public bool isCompleted { get; set; }

    }

    
    public enum TypeOfQualifications : int 
    { 
        CollegeDegree = 0, 
        ProfessionCertification = 1,
        WorkExperience = 2,
    }
}

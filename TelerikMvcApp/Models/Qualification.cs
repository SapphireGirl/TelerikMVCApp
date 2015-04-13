using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace TelerikMvcApp.Models
{
    public class Qualification : EntityBase
    {
        // Required
        public string Description { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateEnded { get; set; }
       // public DateTime DateCompleted { get; set; }
        public bool isCompleted { get; set; }

        [ForeignKey("Candidate")]
        public int CandidateId { get; set; }

        
        public virtual Candidate Candidate { get; set; }

        // Dealing with Enums in EF


        //private string qualificationDescription;
        //protected internal string QualificationDescription
        //{
        //    get { return qualificationDescription; }
        //    set
        //    {
        //        qualificationDescription = value;
        //        qtype = (TypeOfQualifications)Enum.Parse(typeof(TypeOfQualifications), value);
        //    }
        //}
        //[NotMapped]
        //private TypeOfQualifications qtype;
       
        //public TypeOfQualifications QType
        //{
        //    get { return qtype; }
        //    set
        //    {
        //        qtype = value;
        //        qualificationDescription = value.ToString();
        //    }
        //}

    }

     [Flags]
    public enum TypeOfQualifications : int 
    { 
        CollegeDegree = 0, 
        ProfessionCertification = 1,
        WorkExperience = 2,
    }
}

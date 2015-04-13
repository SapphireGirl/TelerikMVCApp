using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TelerikMvcApp.Models;

namespace TelerikMvcApp.DataAccess.Seeds
{
    public class InitializeDBWithSeedData : DropCreateDatabaseAlways<CardnoContext>
    {

        public InitializeDBWithSeedData()
        {
            var thisisatest = 0;
     
        }
        protected override void Seed(CardnoContext context)
        {
            base.Seed(context);

            // Candidates
            context.Candidates.Add(new Candidate
            {

                
                FirstName = "Justine",
                LastName = "Alires",
                Phone = "555-1234",
                Email = "hello@cardno.com",
                Address = new Address
                {
                    StreetAddress = "1234 Happy Valley Road",
                    City = "Katy",
                    Region = "California",
                    ZipCode = "11111"
                },
                Qualifications = new List<Qualification>
                {
                    new Qualification
                    {
                        Description = "University Of California, Bachelor Degree",
                        DateStarted = new DateTime(1991, 08, 15),
                        DateEnded = new DateTime(1995, 03, 15),
                        isCompleted = true,
                        //CandidateId = 1,
                        //QType = TypeOfQualifications.CollegeDegree
                    },
                    new Qualification
                    {
                        Description = "Pluralsight Certification: C#",
                        DateStarted = new DateTime(2013, 08, 15),
                        DateEnded = new DateTime(2013, 03, 15),
                        isCompleted = true,
                        //CandidateId = 1,
                        //QType = TypeOfQualifications.CollegeDegree
                    },
                    new Qualification
                    {
                        Description = "PluralSight Certification: JavaScript",
                        DateStarted = new DateTime(2014, 12, 23),
                        DateEnded = new DateTime(2015, 03, 15),
                        isCompleted = false,
                        //CandidateId = 1,
                        //QType = TypeOfQualifications.ProfessionCertification
                    }
                     

                }
            });
          
            context.Candidates.Add(new Candidate()
            {

                
                    FirstName = "Kaye",
                    LastName = "Alires",
                    Phone = "555-1235",
                    Email = "kaye@hotmail.com",
                    Address = new Address
                    {
                        StreetAddress = "1234 Sky Line Road",
                        City = "Albuquerque",
                        Region = "New Mexico",
                        ZipCode = "87111"
                    },
                    Qualifications = new List<Qualification>
                    {
                        new Qualification
                        {
                            Description = "University Of New Mexico, Bachelor Degree",
                            DateStarted = new DateTime(1995, 08, 15),
                            DateEnded = new DateTime(2000, 03, 15),
                            isCompleted = true,
                            //CandidateId = 1,
                            //QType = TypeOfQualifications.CollegeDegree
                        }
                     

                    }
            });

            context.Candidates.Add(new Candidate()
            {

                
                    FirstName = "Bill",
                    LastName = "Gates",
                    Phone = "713-555-1237",
                    Email = "spongebob@hotmail.com",
                    Address = new Address
                    {
                        StreetAddress = "1234 Happy Valley Road",
                        City = "Boston",
                        Region = "massachusetts",
                        ZipCode = "02108"
                    },
                    Qualifications = new List<Qualification>
                    {
                    new Qualification
                    {
                        Description = "Harvard University",
                        DateStarted = new DateTime(1982, 08, 15),
                        DateEnded = new DateTime(1983, 03, 15),
                        isCompleted = false,
                        //CandidateId = 1,
                        //QType = TypeOfQualifications.CollegeDegree
                    }
                     

                    }
            });

            context.Candidates.Add(new Candidate()
            {

                
                FirstName = "John",
                LastName = "Sonmez",
                Phone = "713-555-1234",
                Email = "john@simpleprogrammer.com",
                Address = new Address
                {
                    StreetAddress = "1909 Ala Wai Road",
                    City = "Honolulu",
                    Region = "Hawaii",
                    ZipCode = "96701"
                },
                Qualifications = new List<Qualification>
                {
                    new Qualification
                    {
                        Description = "University Of Hawaii, Bachelor Degree",
                        DateStarted = new DateTime(1991, 08, 15),
                        DateEnded = new DateTime(1995, 03, 15),
                        isCompleted = true,
                        //CandidateId = 1,
                        //QType = TypeOfQualifications.CollegeDegree
                    }
                     

                }
            });

            context.Candidates.Add(new Candidate()
            {

               
                FirstName = "Julie",
                LastName = "Lerman",
                Phone = "555-8888",
                Email = "julie@datafarm.com",
                Address = new Address
                {
                    StreetAddress = "78 Grant St",
                    City = "Burlington",
                    Region = "Vermont",
                    ZipCode = "44444"
                },
                Qualifications = new List<Qualification>
                {
                    new Qualification
                    {
                        Description = "University Of California, Bachelor Degree",
                        DateStarted = new DateTime(1991, 08, 15),
                        DateEnded = new DateTime(1995, 03, 15),
                        isCompleted = true,
                        //CandidateId = 1,
                        //QType = TypeOfQualifications.CollegeDegree
                    },
                    new Qualification
                    {
                        Description = "Database Architect: DataFarm.com",
                        DateStarted = new DateTime(1991, 08, 15),
                        DateEnded = new DateTime(1995, 03, 15),
                        
                        isCompleted = true,
                        //CandidateId = 1,
                        //QType = TypeOfQualifications.WorkExperience
                    }
                     

                }
            });

            context.SaveChanges();

           

            
        }
    }
}
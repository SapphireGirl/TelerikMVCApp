using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kendo.Mvc.UI.Fluent;
using TelerikMvcApp.Models;
using TelerikMvcApp.Services;
using TelerikMvcApp.ViewModels;

namespace TelerikMvcApp.Providers
{
    public class CandidateProvider
    {
        private readonly CandidateService _candidateService;

        // ERROR codes are used for logging and other business logic
        private const int SUCCESS = 1;
        private const int FAILURE = 2;

        public CandidateProvider()
        {
            _candidateService = new CandidateService();
            
        }
        public CandidateViewModel GetCandidateViewModel()
        {
            return new CandidateViewModel
            {
                Id = 1,
                FirstName = "Justine",
                LastName = "Alires",
                Email = "justinealires@outlook.com",
                Phone = "555-1212",
                Address = new Address
                {
                    StreetAddress = "24915 Crystal Stone Ln",
                    City = "Katy",
                    Region = "Texas",
                    ZipCode = "77494"
                },

                Qualification = 
                    new Qualification
                    {
                      //  QType = TypeOfQualifications.CollegeDegree,
                        Description = "Bachelor Degree in Mathematics",
                        DateStarted = new DateTime(1991, 8, 15),
                        DateEnded = new DateTime(1995, 3, 24),
                        isCompleted = true
                    }
                

                };
        }

        public IQueryable<Candidate> getQlist()
        {

            var cList = new List<Candidate>
            {
                new Candidate
                {
                    Id = 1,
                    FirstName = "Justine",
                    LastName = "Alires",
                    Phone = "555-1234",
                    Email = "hello@cardno.com",
                    Address = new Address
                    {
                        StreetAddress = "1234 Happy Valley Road",
                        City = "Katy",
                        Region = "California"
                    }
                },
                new Candidate
                {
                    Id = 2,
                    FirstName = "Kaye",
                    LastName = "Alires",
                    Phone = "555-1235",
                    Email = "kaye@hotmail.com",
                    Address = new Address
                    {
                        StreetAddress = "1234 Happy Valley Road",
                        City = "PleasantHill",
                        Region = "California"
                    }
                },
                new Candidate
                {
                    Id = 3,
                    FirstName = "SpongeBob",
                    LastName = "SquarePants",
                    Phone = "555-1236",
                    Email = "spongebob@hotmail.com",
                    Address = new Address
                    {
                        StreetAddress = "1234 Happy Valley Road",
                        City = "UnderTheSea",
                        Region = "California"
                    }
                }

            };
            return cList.AsQueryable();
        }


        // TODO: Implement Logging/Exception Handling and Error Codes
        public int SaveCandidate(CandidateViewModel vm)
        {
            
            return SUCCESS;
        }
    }
}

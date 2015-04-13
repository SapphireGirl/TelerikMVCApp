using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor.Text;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.Ajax.Utilities;
using TelerikMvcApp.DataAccess;
using TelerikMvcApp.Models;
using TelerikMvcApp.Providers;
using TelerikMvcApp.ViewModels;

namespace TelerikMvcApp.Controllers
{
    public class HomeController : Controller
    {
        // TODO: Add Unity Container
        public CandidateProvider _candidateProvider { get; set; }
        public CardnoContext _cardnoContext { get; set; }

        public HomeController()
        {
            _candidateProvider = new CandidateProvider();
           
        }

        public ActionResult Index()
        {

            var vm = _candidateProvider.GetCandidateViewModel();
            // Note:  Database will not automatically seed.
            // Need to get the context and use it before it will actually seed.
            // Can Seed the db by going to the Package Manager and use the Update-Database command.
            // I think this is after the enable migrations = true is set in Configuration.cs and
            // run the Enable-Migrations in Package manager too.
            TestDB();
            // Calling Context to run the seed
           // SeedData();
            return View(vm);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(CandidateViewModel vm)
        {

            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public virtual JsonResult GetTypesOfQualifications()
        {
            var TypeOfQualifcations = new List<object>();

            // TODO: Store In DB: Then we can add more qualifications without recompiling/publishing
            
            TypeOfQualifcations.Add(
                                     new
                                        {
                                            Text = "College Degree",
                                            Value = 1
                                        });
            TypeOfQualifcations.Add(
                                    new
                                       {
                                           Text = "Profession Certification",
                                           Value = 2
                                       }); 
            
            TypeOfQualifcations.Add(
                                     new
                                     {
                                         Text = "Work Experience",
                                         Value = 3
                                     });



            return Json(TypeOfQualifcations, JsonRequestBehavior.AllowGet);
        }
        
#region Candidate Update and Save

        
        public ActionResult AjaxCandidateSave(CandidateViewModel vm)
        {
            var redirectUrl = new UrlHelper(Request.RequestContext).Action("Index", "Home", new { });
            if (!ModelState.IsValid)
            {
                var modelErrors = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage);
                // TODO: Add logging here/ Maybe a kendo notification on screen.
                var returnJson =  new JsonResult
                {
                    
                    Data = Json(new
                    {
                        success = false,
                        data = modelErrors,
                        Url = redirectUrl
                    })
                };

                return returnJson;

            }

            // TODO: Check result once DB is setup
            var result = 0;
            try
            {
                result = _candidateProvider.SaveCandidate(vm);

                return RedirectToAction("Index", "Home");

            }
            catch (Exception ex)
            {
                return Json(new { ok = false, message = ex.Message, data = result, Url = redirectUrl });
            }
            
         

        }
        public ActionResult CandidatesRead([DataSourceRequest]DataSourceRequest request)
        {
            return Json(_candidateProvider.getQlist().ToDataSourceResult(request));
        }

        public ActionResult UpdateCandidateGrid([DataSourceRequest] DataSourceRequest request, CandidateViewModel vm)
        {
            var list = _candidateProvider.getQlist();
            var newList = list.ToList();
            newList.Add(new Candidate
            {
                FirstName = vm.FirstName,
                LastName = vm.LastName,
                Address = new Address()
                {
                    City = vm.Address.City,
                    Region = vm.Address.Region,
                    StreetAddress = vm.Address.StreetAddress,
                    ZipCode = vm.Address.ZipCode
                },
                Email = vm.Email,
                Id = 4,
                Phone = vm.Phone
            });

            return Json(newList.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }
#endregion

        public void TestDB()
        {
            // Add a record

            using (_cardnoContext = new CardnoContext())
            {
                //try
                //{
                //    // Candidates
                //    _cardnoContext.Candidates.Add(new Candidate
                //    {

                        
                //        FirstName = "Janine",
                //        LastName = "Alires",
                //        Phone = "555-1234",
                //        Email = "Janie@gmail.com",
                //        Address = new Address
                //        {
                //            StreetAddress = "1234 Happy Valley Road",
                //            City = "Pleasant Hill",
                //            Region = "California",
                //            ZipCode = "11111"
                //        },
                //        Qualifications = new List<Qualification>
                //        {
                //            new Qualification
                //            {
                //                Description = "University Of California, Bachelor Degree",
                //                DateStarted = new DateTime(1991, 08, 15),
                //                DateEnded = new DateTime(1995, 03, 15),
                                
                //                isCompleted = true,
                                
                //               // QType = TypeOfQualifications.CollegeDegree
                //            },
                //            new Qualification
                //            {
                //                Description = "Pluralsight Certification: C#",
                //                DateStarted = new DateTime(2013, 08, 15),
                //                DateEnded = new DateTime(2013, 03, 15),
                //                isCompleted = true,
                                
                //               // QType = TypeOfQualifications.CollegeDegree
                //            },
                //            new Qualification
                //            {
                //                Description = "PluralSight Certification: JavaScript",
                //                DateStarted = new DateTime(2014, 12, 23),
                //                DateEnded = new DateTime(2015, 03, 15),
                //                isCompleted = false,
                                
                //               // QType = TypeOfQualifications.ProfessionCertification
                //            }


                //        }
                //    });

                    _cardnoContext.SaveChanges();
                //}
                //catch (Exception ex)
                //{
                //    var message = ex.Message;
                //    Debug.WriteLine(ex.Message);
                //}
            }
        }

        public void SeedData()
        {
            try
            {


                _cardnoContext = new CardnoContext();
                _cardnoContext.SaveChanges();

            }
            catch (Exception ex)
            {
                var message = ex.Message;
                Debug.WriteLine(message);
            }
        }

    }
}
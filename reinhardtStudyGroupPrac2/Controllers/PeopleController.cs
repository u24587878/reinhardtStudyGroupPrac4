using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace reinhardtStudyGroupPrac2.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            List<Models.PersonModel> people = new List<Models.PersonModel>();
            
            people.Add(new Models.PersonModel
            {
                StudentNumber = "u24587878",
                FirstName = "Reinhardt",
                LastName = "Coetzee",
                EmailAddress = "u24587878@gmail.com",
                MyLink = "~/HTML/HtmlPage1.html" 
            });

            people.Add(new Models.PersonModel
            {
                StudentNumber = "u22499475",
                FirstName = "Reece",
                LastName = "Wenhold",
                EmailAddress = "u22499475@gmail.com",
                MyLink = "~/HTML/HtmlPage2.html"
            });

            people.Add(new Models.PersonModel
            {
                StudentNumber = "u24711919",
                FirstName = "Regardt",
                LastName = "van Heerden",
                EmailAddress = "u24711919@gmail.com",
                MyLink = "~/HTML/HtmlPage3.html"
            });

            people.Add(new Models.PersonModel
            {
                StudentNumber = "u23658772",
                FirstName = "Xander",
                LastName = "Visagie",
                EmailAddress = "u23658772@gmail.com",
                MyLink = "~/HTML/HtmlPage4.html"
            });

            people.Add(new Models.PersonModel
            {
                StudentNumber = "u24664929",
                FirstName = "Arno",
                LastName = "Smalberger",
                EmailAddress = "u24664929@gmail.com",
                MyLink = "~/HTML/HtmlPage5.html"
            });

            return View(people);
        }
    }
}
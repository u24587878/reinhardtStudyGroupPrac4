using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace reinhardtStudyGroupPrac2.Models
{
    public class PersonModel
    {

        [Display(Name = "STUDENT NUMBER")]
        public string StudentNumber { get; set; }

        [Display(Name = "NAME")]
        public string FirstName { get; set; }

        [Display(Name = "SURNAME")]
        public string LastName { get; set; }

        [Display(Name = "EMAIL ADDRESS")]
        public string EmailAddress { get; set; }

        [Display(Name = "LINK TO PERSONAL PAGE")]
        public string MyLink { get; set; }
    }
}
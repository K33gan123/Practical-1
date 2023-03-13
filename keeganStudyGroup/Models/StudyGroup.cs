using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace keeganStudyGroup.Models
{
    public class StudyGroup
    {
        [Display(Name = "studentNumber")]
        public string StudentNumber { get; set; }
        [Display(Name = "name")]
        public string name { get; set; }
        [Display(Name = "surname")]
        public string surname { get; set; }
        [Display(Name = "emailAddress")]
        public string emailAddress { get; set; }
    }
}
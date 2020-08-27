using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBC.Models
{
    public class CoursesTest
    {
        [HiddenInput]
        public int id { get; set; }

        [Required(ErrorMessage = "Введите название курса")]
        [Display(Name = "Название курса")]
        public string NameCourses { get; set; }

        public List<Test> Test { get; set; }
    }
}
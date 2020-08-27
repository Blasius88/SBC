using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBC.Models
{
    public class Test
    {
        [Key]
        [HiddenInput]
        public int idTest { get; set; }

        [Required(ErrorMessage = "Введите тему теста")]
        [Display(Name = "Тема теста")]
        public string NameThema { get; set; }

        [HiddenInput]
        [Required]
        public CoursesTest CoursesTest { get; set; }

        public List<Question> Questions { get; set; }
    }
}
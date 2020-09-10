using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBC.Models
{
    public class LernenItem
    {
        [Key]
        [HiddenInput]
        public int idLernen { get; set; }

        [Required(ErrorMessage = "Введите название урока")]
        [Display(Name = "назание урока")]
        public string nameLernen { get; set; }
        
        public int coursesItemId { get; set; }
        [HiddenInput]
        [Required]
        public CoursesItem Courses { get; set; }

    }
}
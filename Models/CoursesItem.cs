using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBC.Models
{
    public class CoursesItem
    {

        [HiddenInput]
        public int id { get; set; }

        [Required(ErrorMessage = "Введите название курса")]
        [Display(Name = "Название курса")]
        public string NameCourses { get; set; }

        [Required(ErrorMessage = "Введите описание курса")]
        [Display(Name = "Описание курса")]
        public string Description { get; set; } // описание курса 

        [ScaffoldColumn(false)]
        public byte[] Image { get; set; } // изображение 

        [ScaffoldColumn(false)]
        public string MineType { get; set; } //тип данных изображения 

        public List<TestItem> Test { get; set; }

        public List<LernenItem> lernens { get; set; }
    }
}
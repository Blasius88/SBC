using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public ICollection<TestItem> test { get; set; }

        public ICollection<LernenItem> lernens { get; set; }

        public CoursesItem()
        {
            lernens = new List<LernenItem>();
            test = new List<TestItem>();
        }
    }
}
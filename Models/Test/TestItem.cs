using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SBC.Models
{
    public class TestItem
    {
        [Key]
        [HiddenInput]
        public int idTest { get; set; }

        [Required(ErrorMessage = "Введите тему теста")]
        [Display(Name = "Тема теста")]
        public string NameThema { get; set; }

        [HiddenInput]
        [Required]
        public CoursesItem Courses { get; set; }

        public List<QuestionItem> Questions { get; set; }
    }
}
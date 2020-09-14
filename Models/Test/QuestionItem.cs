using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SBC.Models
{
    public class QuestionItem
    {
        [Key]
        [HiddenInput]
        public int idQuestion { get; set; }

        [Required(ErrorMessage = "Введите вопрос")]
        [Display(Name = "Вопрос")]
        public string question { get; set; }

        [Required(ErrorMessage = "Введите вариант ответа")]
        [Display(Name = "Вариант ответа")]
        public string possibleAnswerOne { get; set; }

        [Required(ErrorMessage = "Введите вариант ответа")]
        [Display(Name = "Вариант ответа")]
        public string possibleAnswerTwo { get; set; }

        [Required(ErrorMessage = "Введите вариант ответа")]
        [Display(Name = "Вариант ответа")]
        public string possibleAnswerThree { get; set; }

        [Required(ErrorMessage = "Введите вариант ответа")]
        [Display(Name = "Вариант ответа")]
        public string possibleAnswerFour { get; set; }

        [Required(ErrorMessage = "Введите вариант ответа")]
        [Display(Name = "Вариант ответа")]
        public string possibleAnswerFive { get; set; }

        [Required(ErrorMessage = "Введите правильный ответ")]
        [Display(Name = "Правильный ответ")]
        public string Answer { get; set; }

        public bool imageBool { get; set; } // проверка на добавление картинки 

        [ScaffoldColumn(false)]
        public byte[] image { get; set; }

        [ScaffoldColumn(false)]
        public string mimeType { get; set; } // Mime - тип данных изображения

        [HiddenInput]
        [Required]
        public TestItem Test { get; set; }

    }
}
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SBC.Models
{
    public class QuestionItem
    {
        [Key]
        [HiddenInput]
        public int idQuestion { get; set; }

        public string Answer { get; set; }

        [Required]
        public int Test { get; set; }

         [Required]
        public int NumberQustion { get; set; }

    }
}
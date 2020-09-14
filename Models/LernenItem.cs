using System.ComponentModel.DataAnnotations;
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

        [Required]
        [HiddenInput]
        public int coursesItemId { get; set; }
    }
}
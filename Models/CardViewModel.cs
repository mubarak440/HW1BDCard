using System.ComponentModel.DataAnnotations;

namespace BirthdayCardGenerator.Models
{
    public class CardViewModel
    {
        [Required(ErrorMessage = "Please enter From")]
        public string From { get; set; }

        [Required(ErrorMessage = "Please enter To")]
        public string To { get; set; }

        [Required(ErrorMessage = "Please enter your Message")]
        public string Message { get; set; }
    }
}

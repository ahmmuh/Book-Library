using System.ComponentModel.DataAnnotations;

namespace Book_Library.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Du måste skriva titlen på boken")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Du måste skriva ISBN på boken")]
        public string ISBN { get; set; }
        [Required(ErrorMessage = "Du måste skriva author name")]
        public string Author { get; set; }

    }
}

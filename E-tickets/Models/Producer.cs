using E_tickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace E_tickets.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        public string PictureProfileURL { get; set; }

        [Display(Name = "Name")]

        public string FullName { get; set; }

        [Display(Name = "Biography")]


        public string Bio { get; set; }

        // Relationships

        public List<Movie> Movies { get; set; }
    }
}

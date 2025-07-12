using E_tickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace E_tickets.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        //after inherting from  entitybase we can not implement it 


        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage =" Profile Picture is required")]
        public string PictureProfileURL { get; set; }


        [Display(Name = "Name")]
        [Required(ErrorMessage = " Full Name is required")]
        [StringLength(50 , MinimumLength = 3 , ErrorMessage = "Full Name between 3 and 50")]

        public string  FullName { get; set; }


        [Display(Name = "Biography")]
        [Required(ErrorMessage = " Bio is required")]

        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}

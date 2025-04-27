using System.ComponentModel.DataAnnotations;

namespace E_tickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string PictureProfileURL { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }

        // Relationships

        public List<Movie> Movies { get; set; }
    }
}

using E_tickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_tickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }


        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string ImageURL { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }

        // Relationships

        //Actor M-M
        public List<Actor_Movie> Actors_Movies { get; set; }// no need for join if we want to do operations (in mapping this column doesn't exist)

        // Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]

        public Cinema Cinema { get; set; }

        // Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]

        public Producer Producer { get; set; }




    }
}


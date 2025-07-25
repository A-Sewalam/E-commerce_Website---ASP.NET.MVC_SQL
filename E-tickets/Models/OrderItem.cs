﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace E_tickets.Models
{
    public class OrderItem
    {

        [Key]
        public int Id { get; set; }

        public int Amount { get; set; }
        public double Price { get; set; }

        //Relationships

        public int MovieId { get; set; }

        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }

        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }
    }
}

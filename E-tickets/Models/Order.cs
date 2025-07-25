﻿using System.ComponentModel.DataAnnotations;

namespace E_tickets.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }
        public string UserId { get; set; }

        // Relationships  
        public List<OrderItem> OrderItems { get; set; }


    }
}

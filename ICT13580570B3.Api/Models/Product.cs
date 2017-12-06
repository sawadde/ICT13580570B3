﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ICT13580570B3.Api.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get;  set; }
        public string Description { get; set;}
        public decimal UnitPrice { get; set;}
        public string ImagePath { get; set;}
    }
}

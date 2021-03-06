﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cinema.Models
{
    [Table("Movies")]
    public class Movie
    {
        [Required]
        [StringLength(50)]
        [MinLength(5)]
        [Key]
        public string Name { get; set; }
        public double Rating { get; set; }
        public Ticket Ticket { get; set; }
    }
}
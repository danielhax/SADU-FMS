﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sadu.Models
{
    public class Submission
    {
        public Submission()
        {
            date_submitted = null;
            approved = false;
        }
        public int Id { get; set; }
        [Required]
        public String title { get; set; }
        public String details { get; set; }
        [Required]
        public String date_created { get; set; }
        public String date_deadline { get; set; }
        public String date_submitted { get; set; }
        public bool approved { get; set; }
        public virtual Organization Organization { get; set; }
        
    }
}
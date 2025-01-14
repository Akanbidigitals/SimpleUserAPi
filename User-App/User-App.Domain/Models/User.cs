﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_App.Domain.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; }= string.Empty;
    }
}

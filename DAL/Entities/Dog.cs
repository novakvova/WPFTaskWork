﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("tblDogs")]
    public class Dog
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(maximumLength: 255)]
        public string Name { get; set; }
        [Required, StringLength(maximumLength:255)]
        public string Breed { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EF_EX4_Task1.Model
{
    public class Address
    {
        [Key][ForeignKey("User")]
        public int Id { get; set; }


        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public User User { get; set; }
    }
}

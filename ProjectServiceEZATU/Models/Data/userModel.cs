﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ProjectServiceEZATU.Models.Data
{
    public class userModel
    {
        public string userid { get; set; }
        //public string Name { get; set; }
        //public string Email { get; set; }
        public string password { get; set; }
        //public string Role { get; set; }
    }
}

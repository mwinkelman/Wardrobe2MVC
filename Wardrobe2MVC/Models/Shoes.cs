﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Wardrobe2MVC.Models
{
    public class Shoes
    {
        [Key]
        public int ShoeID { get; set; }
        public string Nickname { get; set; }
        public string PhotoURL { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Season { get; set; }
        public string Occasion { get; set; }

    }
}
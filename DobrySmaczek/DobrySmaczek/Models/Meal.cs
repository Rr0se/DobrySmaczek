﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Models
{
    public class Meal
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Components { get; set; }
        public double  Price { get; set; }
   
    }
}

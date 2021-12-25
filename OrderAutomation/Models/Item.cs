﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }        

        public decimal Price { get; set; }   

        public string Description { get; set; } 

        public decimal Weight { get; set; }

        public int Quantity { get; set; }

    }
}

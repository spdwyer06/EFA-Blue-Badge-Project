﻿using POS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.OrderModels
{
    public class OrderCreate
    {
        public int UserId { get; set; }
        public int CustomerId { get; set; }
        public bool Delivery { get; set; }
        public double Price { get; set; }
        public DateTime OrderTime { get; set; }
        public ICollection<Pizza> PizzaCollection { get; set; }

    }
}
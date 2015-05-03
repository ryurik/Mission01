﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fittings
{
    public class BaseItem :IBaseItem
    {
        public string Name { get; set; }
        public TypeOfSuppliers Suppliers { get; set; }
        public DateTime IncomeDate { get; set; }
        public double Price { get; set; }

        public int Amount { get; set; }
    }
}

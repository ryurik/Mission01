using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fittings
{
    public class AtomParts : IAtomItem
    {
        public bool NonGabarite { get; set; }
        public double Weight { get; set; }
        public TypeOfStories TypeOfStories { get; set; }
        public Dimension Dimension { get; set; }
        public string Name { get; set; }
        public TypeOfSuppliers Suppliers { get; set; }
        public DateTime IncomeDate { get; set; }
        public double Price { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fittings
{
    public interface IBaseItem
    {
        string Name { get; }
        TypeOfSuppliers Suppliers { get; }
        DateTime IncomeDate { get; }
        Double Price { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fittings
{
    public class ItemsComparerByIncomeDate : IComparer<IBaseItem>
    {
        public int Compare(IBaseItem x, IBaseItem y)
        {
            if (x == null || y == null) return (y == null && x == null) ? 0 : (x != null) ? 1 : -1;
            return (x.IncomeDate > y.IncomeDate) ? 1 : (x.IncomeDate == y.IncomeDate) ? 0 : -1;
        }
    }
}

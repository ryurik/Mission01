using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fittings
{
    public interface IHeavyItem : IStaticItem
    {
        bool CanStoreOnShelfs { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fittings
{
    public interface IStaticItem : IBaseItem
    {
        double Weight { get; }
        TypeOfStories TypeOfStories { get; }
        Dimension Dimension { get; }


    }
}

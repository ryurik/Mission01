using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fittings
{
    public struct Dimension
    {
        public double Length ;
        public double Width ;
        public double Height ;
        public bool CanTurnOver; // Кантовать

        public double GetVolume()
        {
            return Length * Width * Height;
        }

        public double GetMinSquare()
        {
            double a = (Length <= Width) && (Length <= Height) ? Length : (Width <= Length) && (Width <= Height) ? Width : Height; // min
            double c = (Length >= Width) && (Length >= Height) ? Length : (Width >= Length) && (Width >= Height) ? Width : Height; // max
            double b = (a < Width) && (Width < c) ? Width : (a < Length) && (Length < c) ? Length : Height; // average
            return a*b;
        }

        public int Comparer(Dimension item1, Dimension item2)
        {
            SortDimensions(ref item1);
            SortDimensions(ref item2);
            return item1.GetMinSquare() < item2.GetMinSquare() ? -1 : item1.GetMinSquare() == item2.GetMinSquare() ? 0 : 1 ;

        }

        private static void SortDimensions(ref Dimension inItem)
        {
            if (inItem.CanTurnOver) {
                double a = (inItem.Length <= inItem.Width) && (inItem.Length <= inItem.Height) ? inItem.Length : (inItem.Width <= inItem.Length) && (inItem.Width <= inItem.Height) ? inItem.Width : inItem.Height; // min
                double c = (inItem.Length >= inItem.Width) && (inItem.Length >= inItem.Height) ? inItem.Length : (inItem.Width >= inItem.Length) && (inItem.Width >= inItem.Height) ? inItem.Width : inItem.Height; // max
                double b = (a < inItem.Width) && (inItem.Width < c) ? inItem.Width : (a < inItem.Length) && (inItem.Length < c) ? inItem.Length : inItem.Height; // average
                inItem.Length = c;
                inItem.Width = b;
                inItem.Height = a;
            }
        }

    }
}

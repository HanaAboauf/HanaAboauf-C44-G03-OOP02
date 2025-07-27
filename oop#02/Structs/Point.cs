using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_02.Structs
{
    internal struct Point
    {
        #region Properties

        public double X { set; get; }

        public double Y { set; get; }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public static double calculateDistance(Point a, Point b)
        {
           double dx=a.X-b.X;
           double dy=a.Y-b.Y;

            return Math.Sqrt(dx * dx + dy * dy);

        }
        #endregion
    }
}

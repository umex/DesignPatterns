using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.PointExample
{
    public class PointExampleMain
    {
        public static void Main()
        {
            var p1 = new Point(2, 3, Point.CoordinateSystem.Cartesian);
            var origin = Point.Origin;

            var p2 = Point.Factory.NewCartesianPoint(1, 2);
        }
    }
}

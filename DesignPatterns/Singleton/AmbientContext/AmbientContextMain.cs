﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton.AmbientContext
{
    public class AmbientContextMain
    {
        public static void Main(string[] args)
        {
            var house = new Building();

            // ground floor
            //var e = 0;
            house.Walls.Add(new Wall(new Point(0, 0), new Point(5000, 0)/*, e*/));
            house.Walls.Add(new Wall(new Point(0, 0), new Point(0, 4000)/*, e*/));

            // first floor
            //e = 3500;
            using (new BuildingContext(3500))
            {
                house.Walls.Add(new Wall(new Point(0, 0), new Point(5000, 0) /*, e*/));
                house.Walls.Add(new Wall(new Point(0, 0), new Point(0, 4000) /*, e*/));
            }

            // back to ground again
            // e = 0;
            house.Walls.Add(new Wall(new Point(5000, 0), new Point(5000, 4000)/*, e*/));

            Console.WriteLine(house);
        }
    }
}

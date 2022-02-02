using AmbientContext.Classes;
using System;

namespace AmbientContext
{
    public class AmbientContext
    {
        static void Main(string[] args)
        {
            Building house = new Building();

            using (new BuildingContext(3000))
            {
                // ground 3000
                house.Walls.Add(new Wall(new Point(0, 0), new Point(5000, 0)));
                house.Walls.Add(new Wall(new Point(0, 0), new Point(0, 4000)));

                using (new BuildingContext(3500))
                {
                    // first 3500
                    house.Walls.Add(new Wall(new Point(0, 0), new Point(6000, 0)));
                    house.Walls.Add(new Wall(new Point(0, 0), new Point(0, 4000)));
                }

                // ground 3000
                house.Walls.Add(new Wall(new Point(5000, 0), new Point(5000, 4000)));
            }

            Console.WriteLine(house);
        }
    }
}

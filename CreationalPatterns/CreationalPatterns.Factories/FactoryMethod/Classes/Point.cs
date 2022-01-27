using System;

namespace Factory.Classes
{
    public class Point
    {
        private double x, y;

        // constructor must be private!
        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static Point Origin = new Point(0, 0);

        public static class Factory
        {
            // factory method
            public static Point NewCartesianPoint(double x, double y)
            {
                return new Point(x, y);
            }

            // factory method
            public static Point NewPolarPoint(double rho, double theta)
            {
                return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
            }
        }

        public override string ToString()
        {
            return $"{nameof(x)}: {x}\n{nameof(y)}: {y}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Planet
    {
        public string planetName;
        public (string, (double, double)) planetEarth = ( "Earth",( 0, 0) );
        public (double, double) planetCoordinate;
        public (string, (double, double)) planetAlpha;
        public double distance;
        Random random = new Random();

        public Planet()
        {
            PlanetAplha();
            PlanetNameGenerator();
            PlanetCoordinateGenerator();
        }

        public void PlanetAplha()
        {
            double randomAngle = random.Next(0, 359);

            double x = planetEarth.Item2.Item1 + (Math.Cos(randomAngle) * 4.3);
            double y = planetEarth.Item2.Item2 + (Math.Sin(randomAngle) * 4.3);
            planetAlpha = ("Alpha Proxima", (x, y));
        }

        public void PlanetNameGenerator()
        {
            List<string> firstName = new List<string> {"a", "b", "c", "d", "e"};
            List<string> lastName = new List<string> {"z", "y", "x", "w", "v"};

            planetName = firstName[random.Next(0, 4)] + " " + lastName[random.Next(0, 4)];
        }
        public void PlanetCoordinateGenerator()
        {
            double x = random.Next(0, 10) + random.NextDouble();
            double y = random.Next(0, 10) + random.NextDouble();
            double x10 = x * 10;
            double y10 = y * 10;
            planetCoordinate = (x10, y10);
            
        }
    }   
}

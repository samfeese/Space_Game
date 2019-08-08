using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Planet
    {
        public string planetName;

        public (double, double) planetCoordinate;

        public double distance;
        Random random = new Random();

        public Planet()
        {
            PlanetNameGenerator();
            PlanetCoordinateGenerator();
        }
        public Planet(string name, (double, double) coordinate)
        {
            planetName = name;
            planetCoordinate = coordinate;

        }

        public void PlanetNameGenerator()
        {
            List<string> firstName = new List<string> { "Alpha", "Garintus", "Wollnir", "Vectus", "Elevator" };
            List<string> lastName = new List<string> { "Primus", "Vinturi", "Charenti", "Pollin", "Music" };

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

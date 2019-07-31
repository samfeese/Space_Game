using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Universe
    {
        public (string, (double, double)) planetA;
        public (string, (double, double)) planetB;
        public (string, (double, double)) planetC;
        
        public void PlanetPlacement()
        {
            Planet planet3 = new Planet();
            Planet planet4 = new Planet();
            Planet planet5 = new Planet();

            planetA = (planet3.planetName, planet3.planetCoordinate);

            planetB = (planet4.planetName, planet4.planetCoordinate);

            planetC = (planet5.planetName, planet5.planetCoordinate);

            Console.WriteLine($"The first generated planet is {planetA.Item1} and is at coordinates {planetA.Item2}");

            double howFar = planet3.Distance((planetA.Item2), (planetB.Item2));

            Console.WriteLine($"{howFar}");

        }
    }
}

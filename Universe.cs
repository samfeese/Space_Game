using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Universe
    {

        public double distance;
        public double fuelBetweenPlanets;
        Planet planet3 = new Planet();
        Planet planet4 = new Planet();
        Planet planet5 = new Planet();

        public (string, (double, double)) earth;
        public (string, (double, double)) alphaProxima;
        public (string, (double, double)) planetA;
        public (string, (double, double)) planetB;
        public (string, (double, double)) planetC;

        public Universe()
        {
            PlanetPlacement();
        }

        
        public void PlanetPlacement()
        {
            earth = planet3.planetEarth;
            alphaProxima = planet3.planetAlpha;
            planetA = (planet3.planetName, planet3.planetCoordinate);
            planetB = (planet4.planetName, planet4.planetCoordinate);
            planetC = (planet5.planetName, planet5.planetCoordinate);
           // currentPlanet = (planet3.planetEarth);
        }

        
        

        public void Distance((double, double) x, (double, double) y)
        {
            double deltaX = y.Item1 - x.Item1;
            double deltaY = y.Item2 - x.Item2;

            distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
        }

        public void FuelBetweenPlanet(double fuelConsumption, double distance)
        {
            fuelBetweenPlanets = distance * fuelConsumption;
        }

    }
}

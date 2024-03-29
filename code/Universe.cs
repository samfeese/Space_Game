﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Universe
    {
        public Planet planet3;
        public Planet planet4;
        public Planet planet5;
        public Planet earth;
        public Planet alphaProxima;

        Random random = new Random();

        public Universe()
        {
            planet3 = new Planet();
            planet4 = new Planet();
            planet5 = new Planet();
            earth = new Planet("Earth", (0, 0));
            alphaProxima = new Planet("Alpha Proxima", PlanetAplha());
        }

        private (double, double) PlanetAplha()
        {
            double randomAngle = random.Next(0, 359);

            double x = (Math.Cos(randomAngle) * 4.3);
            double y = (Math.Sin(randomAngle) * 4.3);
            return (x, y);
        }



        public double Distance((double, double) x, (double, double) y)
        {
            double deltaX = y.Item1 - x.Item1;
            double deltaY = y.Item2 - x.Item2;

            return Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
        }

        public double FuelBetweenPlanet(double fuelConsumption, double distance)
        {
            return distance * fuelConsumption;
        }

    }
}

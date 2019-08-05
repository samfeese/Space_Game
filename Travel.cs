using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Travel
    {
        public double travelTime;
        public double fuelCost;
        public double travelDistance;
        public (string, (double, double)) currentPlanet;
        public (string, (double, double)) goPlanet;
        
        Universe galaxy = new Universe();

        public Travel(double distance, double velocity, double fuelConsumption)
        {
            TravelTime(distance, velocity);
            Fuel(distance, fuelConsumption);
        }

        public void TravelTime(double distance, double velocity)
        {
            travelTime = distance / velocity;
        }

        public void Fuel(double distance, double fuelConsumption)
        {
            fuelCost = distance * fuelConsumption;
        }
        public void PlanetChoice(ConsoleKeyInfo choice)
        {

            switch (choice.Key)
            {
                case ConsoleKey.D1:
                    goPlanet = galaxy.earth;
                    MovePlanet();
                    break;
                case ConsoleKey.D2:
                    goPlanet = (galaxy.alphaProxima);
                    MovePlanet();
                    break;
                case ConsoleKey.D3:
                    goPlanet = galaxy.planetA;
                    MovePlanet();
                    break;
                case ConsoleKey.D4:
                    goPlanet = galaxy.planetB;
                    MovePlanet();
                    break;
                case ConsoleKey.D5:
                    goPlanet = galaxy.planetC;
                    MovePlanet();
                    break;
                default:
                    goPlanet = ("You are lost in Galaxy forever", (0, 0));
                    //MovePlanet();
                    break;
            }

        }
        public void MovePlanet()
        {
            galaxy.Distance(currentPlanet.Item2, goPlanet.Item2);
            travelDistance = galaxy.distance;
        }
        public void MoveConfirm(ConsoleKeyInfo input)
        {

            if (input.Key == ConsoleKey.Enter)
            {
                currentPlanet = goPlanet;
            }
        }

        
    }
}

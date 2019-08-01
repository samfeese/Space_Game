using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Universe
    {

        public Ship ship = new Ship();

        Planet planet3 = new Planet();
        Planet planet4 = new Planet();
        Planet planet5 = new Planet();

        (string, (double, double)) planetA;
        (string, (double, double)) planetB;
        (string, (double, double)) planetC;


        (string, (double, double)) currentPlanet;
        (string, (double, double)) goPlanet;

        public void PlanetPlacement()
        {
            planetA = (planet3.planetName, planet3.planetCoordinate);
            planetB = (planet4.planetName, planet4.planetCoordinate);
            planetC = (planet5.planetName, planet5.planetCoordinate);
            currentPlanet = (planet3.planetEarth);

            // Console.WriteLine($"The first generated planet is {planetA.Item1} and is at coordinates {planetA.Item2}");

           // double howFar = planet3.Distance((planetA.Item2), (planetB.Item2));

            //Console.WriteLine($"{howFar}");

        }

        public void PlanetChoice()
        {
            Console.WriteLine("What Planet?");
            Console.WriteLine("1: Earth");
            Console.WriteLine("2: Alpha Proxima");
            Console.WriteLine($"3: {planetA.Item1}");
            Console.WriteLine($"4: {planetB.Item1}");
            Console.WriteLine($"5: {planetC.Item1}");

            var choice = Console.ReadKey();

            switch (choice.Key)
            {
                case ConsoleKey.D1:
                    goPlanet = planet3.planetEarth;
                    MovePlanet();
                    break;
                case ConsoleKey.D2:
                    goPlanet = (planet3.planetAlpha);
                    MovePlanet();
                    break;
                case ConsoleKey.D3:
                    goPlanet = planetA;
                    MovePlanet();
                    break;
                case ConsoleKey.D4:
                    goPlanet = planetB;
                    MovePlanet();
                    break;
                case ConsoleKey.D5:
                    goPlanet = planetC;
                    MovePlanet();
                    break;
                default:
                    goPlanet = ("You are lost in Galaxy forever", (0, 0));
                    MovePlanet();
                    break;
            }

        }
        public double MovePlanet()
        {
            var distance = planet3.Distance(currentPlanet.Item2, goPlanet.Item2);
            Console.WriteLine($"The distance between {currentPlanet.Item1} and {goPlanet.Item1} is {distance} Light years");
            Console.WriteLine("\nWhat Warp Factor would you like to use?");

            int temp = int.Parse(Console.ReadLine());
            ship.Speed(temp);
            ship.TravelTime(distance);
            ship.Fuel(distance);
            var travelAge = ship.travelTime;
            var travelFuel = ship.fuelCost;

            Console.WriteLine($"The age in years you will spend traveleing is {travelAge} and it will use {travelFuel}u of fuel.");
            MoveConfirm();
            return distance;

        }
        public void MoveConfirm()
        {
            var enter = ConsoleKey.Enter;
            var esc = ConsoleKey.Escape;
            ConsoleKeyInfo input;
            do
            {


                Console.WriteLine("Press <Enter> to confirm and <Esc> to return to planet selection");

                input = Console.ReadKey();

                if (input.Key == enter)
                {

                    currentPlanet = goPlanet;
                }
                else if (input.Key == esc)
                {

                    PlanetChoice();

                }
            } while (input.Key != enter);



        }


    }
}

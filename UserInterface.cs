using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class UserInterface
    {
        public string name;
        public int currentAge;
        public decimal currentMoney;
        //Planet coordinates = new Planet();
        Planet planet3 = new Planet();
        Planet planet4 = new Planet();
        Planet planet5 = new Planet();

        Inventory handOver = new Inventory();
        public void UIstart()
        {


            Console.WriteLine("Please enter you character name: ");

            name = Console.ReadLine();
            
            Console.WriteLine("Hey, pick your stage in life :");
            Console.WriteLine("\n1. Beginning");
            Console.WriteLine("2. Intermediate");
            Console.WriteLine("3. Advanced");
            Console.WriteLine("\nSelect number cooresponding to class");
            int userCharClass = int.Parse(Console.ReadLine());


            //(currentAge, currentMoney) = (c1.SetCharacterClass(userCharClass));

           
            Character c1 = new Character(name, userCharClass);

        }
        public void PlanetPlacement()
        {


            (string, (double, double)) planetA = (planet3.planetName, planet3.planetCoordinate);

            (string, (double, double)) planetB = (planet4.planetName, planet4.planetCoordinate);

            (string, (double, double)) planetC = (planet5.planetName, planet5.planetCoordinate);

            //Console.WriteLine($"The first generated planet is {planetA.Item1} and is at coordinates {planetA.Item2}");
            //Console.WriteLine($"The first generated planet is {planetB.Item1} and is at coordinates {planetB.Item2}");
            //Console.WriteLine($"The first generated planet is {planetC.Item1} and is at coordinates {planetC.Item2}");
            //Console.ReadLine();


        }

        public (double, double) PlanetChoice()
        {
            bool input = true;
            
            
                Console.WriteLine("What Planet?");
                Console.WriteLine("1: Earth");
                Console.WriteLine("2: Alpha Proxima");
                Console.WriteLine($"3: {planet3.planetName}");
                Console.WriteLine("4: Planet 4");
                Console.WriteLine("5: Planet 5");


                var choice = Console.ReadKey();

                (double, double) goPlanet;
                switch (choice.Key)
                {
                    case ConsoleKey.D1:
                        goPlanet = planet3.PlanetEarth();
                        return goPlanet;

                    case ConsoleKey.D2:
                        goPlanet = planet3.planetAlpha;
                        return goPlanet;
                    case ConsoleKey.D3:
                        goPlanet = planet3.planetCoordinate;
                        return goPlanet;
                    case ConsoleKey.D4:
                        goPlanet = planet4.planetCoordinate;
                        return goPlanet;
                    case ConsoleKey.D5:
                        goPlanet = planet5.planetCoordinate;
                        return goPlanet;
                    default:
                        goPlanet = (0, 0);
                        return goPlanet;
                }
            
            


        }
        public void MovePlanet()
        {
            bool input = true;
            do
            {
                var currentPlanet = planet3.PlanetEarth();
                var distance = BetweenPlanets(currentPlanet, PlanetChoice());

                Console.WriteLine($"The distance between planets is {distance}");
            } while (input);




        }



        public void ChangeInventory(int valueOfItem)
        {

            handOver.ItemA(valueOfItem, handOver.skooma);
            Console.WriteLine($"{handOver.skooma.Item2}");

        }

        public double BetweenPlanets((double, double) currentPlanet, (double, double) goPlanet)
        {

           
            var x = currentPlanet;
            var y = goPlanet;
            var distance = planet3.Distance(x, y);
            return distance;
            

        }










    }
    }

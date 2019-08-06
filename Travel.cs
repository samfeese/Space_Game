using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Travel
    {


        Ship ship;
        Universe galaxy;
        //PlanetPhase planetPhase = new PlanetPhase();
       

        public double travelTime;
        public double fuelCost;
        public double travelDistance;

        Planet currentPlanet;
        Planet goPlanet;
        public int  moneyGained;

        ConsoleKeyInfo planetChoice;
        ConsoleKeyInfo confirmation;
        int warpFactor;
        private int v;

        public Travel()
        {
            galaxy = new Universe();
            ship = new Ship();
            currentPlanet = galaxy.earth;
           // TravelMenu();


        }

       public void setShip(int age)
        {
            ship.ShipType(age);
            ship.FuelConsumption();

        }
        public void TravelMenu()
        {
            Console.WriteLine("Which Planet do you want to go to? ");
            Console.WriteLine("----------------------------------------");
            DisplayPlanets();

            planetChoice = Console.ReadKey();
            PlanetChoice(planetChoice);

            Console.WriteLine("Press <Enter> to confirm or <Escape> to cancel:");
            confirmation = Console.ReadKey();

            if (confirmation.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("What warp factor would you like to use? :");
                warpFactor = int.Parse(Console.ReadLine());
                ship.Speed(warpFactor);
                MovePlanet();// Calculates the speed, time so user can decide if they want to proceed
                Console.WriteLine();
                Console.WriteLine($"At the speed of {ship.velocity} , it will take you " +
                                  $"{TravelTime(galaxy.Distance(currentPlanet.planetCoordinate, goPlanet.planetCoordinate), ship.velocity)}" +
                                  $" to reach your destination and it will cost you {fuelCost} in fuel");

                Console.WriteLine("Do you want to proceed? Y/N");
                var confirm = Console.ReadKey();

                if (confirm.Key == ConsoleKey.N)
                {
                    travelDistance = 0;
                    travelTime = 0;
                    TravelMenu();
                }
                else
                {
                    currentPlanet = goPlanet;

                }


            }
            else
            {
                TravelMenu();
            }

        }

        void DisplayPlanets()
        {
            Console.WriteLine($"1.{galaxy.earth.planetName} ");
            Console.WriteLine($"2.{galaxy.alphaProxima.planetName} ");
            Console.WriteLine($"3.{galaxy.planet3.planetName} ");
            Console.WriteLine($"4.{galaxy.planet4.planetName} ");
            Console.WriteLine($"5.{galaxy.planet5.planetName} ");
        }
               
        
       
        public double TravelTime(double distance, double velocity)
        {
            travelTime = distance / velocity;
            return travelTime;
        }

        //public double Fuel(double distance, double fuelConsumption)
        //{
        //    fuelCost = distance * fuelConsumption;
        //    return fuelCost;
        //}
        public void PlanetChoice(ConsoleKeyInfo choice)
        {

            switch (choice.Key)
            {
                case ConsoleKey.D1:
                    goPlanet = galaxy.earth;
                   // MovePlanet();
                    break;
                case ConsoleKey.D2:
                    goPlanet = (galaxy.alphaProxima);
                  //  MovePlanet();
                    break;
                case ConsoleKey.D3:
                    goPlanet = galaxy.planet3;
                   // MovePlanet();
                    break;
                case ConsoleKey.D4:
                    goPlanet = galaxy.planet4;
                   // MovePlanet();
                    break;
                case ConsoleKey.D5:
                    goPlanet = galaxy.planet5;
                   // MovePlanet();
                    break;
                default:
                    Console.WriteLine( "You are lost in Galaxy forever");
                    break;

            }

        }
        public  void MovePlanet()
        {
            travelDistance = galaxy.Distance(currentPlanet.planetCoordinate, goPlanet.planetCoordinate);
            TravelTime(travelDistance, ship.velocity);
           
            fuelCost = galaxy.FuelBetweenPlanet(ship.fuelConsumption, travelDistance);
        }
       

        public void RandomEvent()
        {
            Random spaceEvent = new Random();

            int action = spaceEvent.Next(1, 10);

            int thing = action % 2;
            if (thing == 1)
            {
                NormalTravel();
            }
            else if (thing == 0 && action != 10)
            {
                //space pirates
            }
            else if (action == 10)
            {
                //free money
                //normal travel


            }
            
        }
        public void NormalTravel()
        {
            Console.WriteLine("You made your journey with no major incident and thank the Space Gods for smooth sailing.");
            //UpKeep();
            
        }

        public void SpacePirates()
        {
            Console.WriteLine("Along your journey, you come across a floating shit that appears to be abandonded.");
            Console.WriteLine("\n What would you like to do? F1: Investigate  F2: Ignore and move on");
            var input = Console.ReadKey();
            Random rng = new Random();
            var randomNum = rng.Next(0, 10);

            if (input.Key == ConsoleKey.F1 && randomNum%2 != 0)
            {
                Console.WriteLine("As you move in for a closer look, a large, black ship appears from behind the derilict spacecraft");
                bool win = MiniGame();
                if (win)
                {
                    Console.WriteLine("Congratulations you Won! you salvaged their ship and come home with more money!");
                    moneyGained = 1000;
                }
                else
                {
                    Console.WriteLine("The Pirates bested you but left you alive, they took money to compensate though.");
                    moneyGained = -1000;
                }
            }
            else if ((input.Key == ConsoleKey.F2 && randomNum % 2 != 0))
            {
                Console.WriteLine("As you move away to not take any chances, a large, black ship appears from behind the derilict spacecraft");
                bool win = MiniGame();
                if (win)
                {
                    Console.WriteLine("Congratulations you Won! you salvaged their ship and come home with more money!");
                    moneyGained = 1000;
                    
                }
                else
                {
                    Console.WriteLine("The Pirates bested you but left you alive, they took money to compensate though.");
                    moneyGained = -1000;
                }
                Console.WriteLine();

            }
            else
            {
                
                Console.WriteLine("Your decision was favorable and you found some money along the way!");
                moneyGained = 1000;
                //UpKeep();
            }

        }
        public bool MiniGame()
        {
            Random rng = new Random();

            var player = rng.Next(0, 100);
            Console.WriteLine($"You roll the number {player} ! ");

            var pirates = rng.Next(0, 100);
            Console.WriteLine($"The Pirates roll the number {pirates} !");

            bool win;
             if (player > pirates)
            {
                win = true;
                Console.WriteLine("You Win!");
                return win;
            }
            else
            {
                win = false;
                Console.WriteLine("You Lose!");
                return win;
            }
            

        }

    }
}
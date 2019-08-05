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
        public int  moneyGained;

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

<<<<<<< HEAD
        
=======
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
            UpKeep();
            
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
                UpKeep();
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
>>>>>>> f8aa61285384c2e5c7cd728cfe8788e2f0f45870
    }
}
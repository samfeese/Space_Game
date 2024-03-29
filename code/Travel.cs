﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Space_Game
{
    class Travel
    {


        Ship ship;
        Universe galaxy;

        public double travelTime;
        public double fuelCost;
        public static double travelDistance;

        public Planet currentPlanet;
        Planet goPlanet;
        public int moneyGained;

        ConsoleKeyInfo planetChoice;
        ConsoleKeyInfo confirmation;
        int warpFactor;

        public Travel()
        {
            galaxy = new Universe();
            ship = new Ship();
            currentPlanet = galaxy.earth;
        }

        public void setShip(int age)
        {
            ship.ShipType(age);
            ship.FuelConsumption();

        }
        public void TravelMenu()
        {
            Console.Clear();
            Console.WriteLine("Which Planet do you want to go to? ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Press F1 to go back to MAIN MENU");
            DisplayPlanets();

            Console.WriteLine();
            planetChoice = Console.ReadKey();
            Console.WriteLine();

            if (planetChoice.Key != ConsoleKey.F1)
            {
                PlanetChoice(planetChoice);


                Console.WriteLine("Press <Enter> to confirm or <Escape> to cancel:");
                confirmation = Console.ReadKey();
                Console.WriteLine();
                if (confirmation.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("What warp factor would you like to use? :");
                    try
                    {
                        warpFactor = int.Parse(Console.ReadLine());
                        ship.Speed(warpFactor);
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Invalid Input");
                        TravelMenu();
                    }
                    MovePlanet();
                    Console.WriteLine();
                    Console.WriteLine($"At the speed of {ship.velocity.ToString("F2")} , it will take you " +
                                      $"{travelTime.ToString("F2")} Light Years " +
                                      $" to reach your destination and it will cost you {fuelCost.ToString("F2")} in fuel");

                    if (fuelCost > Character.currentfuelLevel)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You do not have enough fuel to travel that far that fast.");
                        Console.WriteLine("\nTry to go to a different planet, or buy more fuel");
                        TravelMenu();

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Do you want to proceed? Y/N");
                        var confirm = Console.ReadKey();
                        Console.WriteLine();
                        Console.WriteLine();

                        if (confirm.Key == ConsoleKey.N)
                        {

                            TravelMenu();
                        }
                        else
                        {

                            RandomEvent();
                            currentPlanet = goPlanet;

                        }
                    }
                }
                else
                {

                    TravelMenu();
                }
            }
            else
            {
                Console.Clear();
            }

        }

        void DisplayPlanets()
        {
            Console.WriteLine($"1.{galaxy.earth.planetName} -- {galaxy.Distance(currentPlanet.planetCoordinate, galaxy.earth.planetCoordinate).ToString("F2")} Light Years away");
            Console.WriteLine($"2.{galaxy.alphaProxima.planetName} -- {galaxy.Distance(currentPlanet.planetCoordinate, galaxy.alphaProxima.planetCoordinate).ToString("F2")} Light Years away");
            Console.WriteLine($"3.{galaxy.planet3.planetName} -- {galaxy.Distance(currentPlanet.planetCoordinate, galaxy.planet3.planetCoordinate).ToString("F2")} Light Years away");
            Console.WriteLine($"4.{galaxy.planet4.planetName} -- {galaxy.Distance(currentPlanet.planetCoordinate, galaxy.planet4.planetCoordinate).ToString("F2")} Light Years away");
            Console.WriteLine($"5.{galaxy.planet5.planetName} -- {galaxy.Distance(currentPlanet.planetCoordinate, galaxy.planet5.planetCoordinate).ToString("F2")} Light Years away");
        }


        public double TravelTime(double distance, double velocity)
        {
            travelTime = Math.Ceiling(distance / velocity);
            return travelTime;
        }


        public void PlanetChoice(ConsoleKeyInfo choice)
        {
            UserInterface ui = new UserInterface();
            switch (choice.Key)
            {
                case ConsoleKey.D1:
                    goPlanet = galaxy.earth;
                    break;

                case ConsoleKey.D2:
                    goPlanet = (galaxy.alphaProxima);
                    break;

                case ConsoleKey.D3:
                    goPlanet = galaxy.planet3;
                    break;

                case ConsoleKey.D4:
                    goPlanet = galaxy.planet4;
                    break;

                case ConsoleKey.D5:
                    goPlanet = galaxy.planet5;
                    break;

                default:
                    Console.WriteLine("You are lost in Galaxy forever");
                    Console.WriteLine("Press <Enter> To go back to Travel Menu");
                    Console.ReadKey();
                    Console.Clear();
                    TravelMenu();
                    break;

            }

        }
        public void MovePlanet()
        {
            travelDistance = galaxy.Distance(currentPlanet.planetCoordinate, goPlanet.planetCoordinate);
            TravelTime(travelDistance, ship.velocity);
            var fuel = ship.fuelConsumption * warpFactor;
            fuelCost = galaxy.FuelBetweenPlanet(fuel, travelDistance);

        }


        public void RandomEvent()
        {
            Random spaceEvent = new Random();

            int action = spaceEvent.Next(1, 10);

            int thing = action % 2;
            if (thing == 1)
            {
                ShipArt.ShipArtHorz();
                NormalTravel();
                ShipArt.EarthArt();
                Thread.Sleep(2000);
            }
            else if (thing == 0 && action != 10)
            {
                ShipArt.ShipArtHorz();
                SpacePirates();
                Console.WriteLine("\nPress <enter> to continue");
                Console.ReadLine();
                ShipArt.ShipArtHorz();
                ShipArt.EarthArt();
                Thread.Sleep(2000);

            }

        }
        public void NormalTravel()
        {
            Console.WriteLine("You made your journey with no major incident and thank the Space Gods for smooth sailing.");


        }

        public void SpacePirates()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Along your journey, you come across a floating ship that appears to be abandonded.");
            Console.WriteLine("\n What would you like to do? F1: Investigate  F2: Ignore and move on");
            var input = Console.ReadKey();
            Random rng = new Random();
            var randomNum = rng.Next(0, 10);


            if (input.Key == ConsoleKey.F1 && randomNum % 2 != 0)
            {
                Console.WriteLine("As you move in for a closer look, a large, black ship appears from behind the derilict spacecraft");
                bool win = MiniGame();
                if (win)
                {
                    Console.WriteLine("Congratulations you Won! you salvaged their ship and come home with more money!");
                    decimal bill = 1000;
                    Character.Profit(bill);
                }
                else
                {
                    Console.WriteLine("The Pirates bested you but left you alive, they took money to compensate though.");
                    decimal bill = Character.currentMoney / 2;
                    Character.Profit(bill);
                }
            }
            else if ((input.Key == ConsoleKey.F2 && randomNum % 2 != 0))
            {
                Console.WriteLine("As you move away to not take any chances, a large, black ship appears from behind the derilict spacecraft");
                bool win = MiniGame();
                if (win)
                {
                    Console.WriteLine("Congratulations you Won! you salvaged their ship and come home with more money!");
                    decimal bill = 1000;
                    Character.Profit(bill);
                }
                else
                {
                    Console.WriteLine("The Pirates bested you but left you alive, they took money to compensate though.");
                    decimal bill = Character.currentMoney / 2;
                    Character.Profit(bill);
                }
                Console.WriteLine();

            }
            else
            {

                Console.WriteLine("Your decision was favorable and you found some money along the way!");
                decimal bill = 1000;
                Character.Profit(bill);
            }
            Console.ForegroundColor = ConsoleColor.White;

        }
        public bool MiniGame()
        {
            Random rng = new Random();

            var player = rng.Next(0, 100);

            Console.WriteLine($"You roll the number {player} ! ");

            Console.WriteLine();

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
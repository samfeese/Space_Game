﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class UserInterface
    {
        public string characterName;
        public int currentAge;
        public decimal currentMoney;
        public double fuelCostOfTravel;
        public double timeTraveling;

        ConsoleKeyInfo planetChoice;
        ConsoleKeyInfo confirmation;
        int warpFactor;

        Character character1;




        Universe galaxy1 = new Universe();

        Travel move;



        Inventory handOver = new Inventory();

        PlanetPhase planetPhase = new PlanetPhase();

        ShipArt animation = new ShipArt();

        public void UIstart()
        {
            galaxy1.PlanetPlacement();
            Console.WriteLine("Please enter you character name: ");
            characterName = Console.ReadLine();

            Console.WriteLine("Hey, pick your stage in life :");
            Console.WriteLine("\n1. Beginning - You start at 18 yrs old, and have $100.");
            Console.WriteLine("2. Intermediate - You start at 22 yrs old, and have $200.");
            Console.WriteLine("3. Advanced - You start at 26 yrs old, and have $300.");
            Console.WriteLine("\nSelect number cooresponding to class");
            int userCharClass = int.Parse(Console.ReadLine());

            character1 = new Character(characterName, userCharClass);
            
            //galaxy1.ship.ShipType(character1.startAge);

            //Console.WriteLine($"Hey {character1.userName}");
            //character1.SetShip();
            


        }


        public void PlanetOptions()
        {
            Console.WriteLine("press <Enter> to Shop or <Esc> to go to another planet");
            var input = Console.ReadKey();

            if (input.Key != ConsoleKey.Escape)
            {
                planetPhase.PlanetMenu();
                //handOver.ItemChange(planetPhase.addToInventory, planetPhase.itemChanged);
                //handOver.InventoryArt();
            }
            //galaxy1.PlanetChoice();
            Explore();
        }

        public void TravelMenu()
        {
            Console.WriteLine("Which Planet do you want to go to? ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"1.{galaxy1.earth.Item1} ");
            Console.WriteLine($"2.{galaxy1.alphaProxima.Item1} ");
            Console.WriteLine($"3.{galaxy1.planetA.Item1} ");
            Console.WriteLine($"4.{galaxy1.planetB.Item1} ");
            Console.WriteLine($"5.{galaxy1.planetC.Item1} ");

            planetChoice = Console.ReadKey();

            Console.WriteLine("Press <Enter> to confirm or <Escape> to cancel:");

            confirmation = Console.ReadKey();

            if (confirmation.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("What warp factor would you like to use? :");
                warpFactor = int.Parse(Console.ReadLine());
            }
            else
            {
                TravelMenu();
            }

        }

     
        public void Explore()
        {

            move = new Travel(galaxy1.distance, character1.velocity, galaxy1.fuelBetweenPlanets);
            fuelCostOfTravel = move.fuelCost;
            timeTraveling = move.travelTime;
            move.PlanetChoice(planetChoice);

            Console.WriteLine($"The distance between {move.currentPlanet.Item1} and {move.goPlanet.Item1} is {move.travelDistance} Light years");


            //do
            //{


            //    galaxy1.ship.Speed(warpFactor);

            //    galaxy1.ship.TravelTime(galaxy1.MovePlanet());

            //    Console.WriteLine(galaxy1.ship.velocity);

            //    Console.WriteLine($"\nAt Warp {warpFactor} it will take you {galaxy1.ship.travelTime} Years");
            //} while (input.Key != ConsoleKey.Escape);



            animation.ShipArtHorz();




        }


        //public void ChangeInventory(int valueOfItem)
        //{
        //    handOver.ItemA(valueOfItem, handOver.skooma);
        //    Console.WriteLine($"{handOver.skooma.Item2}");
        //}


    }
}

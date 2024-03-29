﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Space_Game
{
    class UserInterface
    {
         string characterName;
         int userCharClass;
        Random random = new Random();
        bool gameOver = false;

        Character character1;
        public Travel move;
        PlanetPhase trade;
        ShipArt animation = new ShipArt();

        public void UIstart()
        {
            bool valid;

            Console.WriteLine("Please enter your character name: ");
            characterName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(characterName)) 
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid character name: ");
                characterName = Console.ReadLine();
            }

            
            do
            {
                Console.Clear();
                Console.WriteLine($"Hey {characterName.ToUpper()}!!! pick your stage in life :");
                Console.WriteLine("\n1. Beginning - You start at 18 yrs old, and have $100.");
                Console.WriteLine("2. Intermediate - You start at 22 yrs old, and have $200.");
                Console.WriteLine("3. Advanced - You start at 26 yrs old, and have $300.");
                Console.WriteLine("\nSelect number cooresponding to class");
                valid = int.TryParse(Console.ReadLine(), out userCharClass);
              
            } while ((userCharClass < 0) || (userCharClass > 3) || (!valid));
           

            Dialog.StartGameDialog();
            Console.WriteLine("Press <Enter> to continue");
            Console.ReadLine();

            character1 = new Character(characterName, userCharClass);
            
            move = new Travel();

            trade = new PlanetPhase();

            move.setShip(character1.currentAge);

            trade.SetDictionary();
            trade.goods.ItemChange(50, 's');


            Console.Clear();
           
            do
            {
                Console.WriteLine($"Current Planet: {move.currentPlanet.planetName}");

                MainMenu();
                if ((character1.currentAge > 60) || (Character.currentMoney < 1 && trade.assets < 10))
                {
                    Console.WriteLine("YOU DIED OF OLD AGE and/or YOU DIED BECAUSE YOU LOST ALL OF YOUR MONEY, TRY AGAIN NEXT TIME!");

                    gameOver = true;
                }
                if ((Character.currentDebt < 0))
                {
                    Console.WriteLine("YOU WIN GOOD JOB PAY OFF YOUR SCUMMY FATHER'S DEBT. I HEAR HE IS STILL AROUND SOMEWHERE THOUGH, AND JUST FAKED HIS DEATH TO MAKE YOU PAY!");

                    gameOver = true;
                }

            } while (!gameOver);

            
        }

        public void MainMenu()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A. To Move To another planet.  || B. To start trading on this Planet.  || C. To see your current stats. || D. Pay off part of Debt || F1. To end the game.");
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine();
            var selection = Console.ReadKey();
            Console.WriteLine();

            switch (selection.Key)
            {
                case ConsoleKey.A:
                    Console.Clear();
                    move.TravelMenu();
                    character1.Aging(Convert.ToInt32(move.travelTime));
                    character1.FuelAfterTravel(move.fuelCost);
                    break;
                case ConsoleKey.B:
                    Console.Clear();
                    trade.PlanetMenu();
                    trade.InventoryUpKeep();
                    character1.FuelAterPurchase(trade.fuelBuy);
                    break;
                case ConsoleKey.C:
                    Console.Clear();
                    character1.PlayerStats();
                    trade.DisplayMyInventory();
                    Console.WriteLine();
                    Console.Write("Press <Enter> to go back to the MAIN MENU:");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case ConsoleKey.D:
                    Console.Clear();
                    PayOffDebt();
                    Console.Write("Press <Enter> to go back to the MAIN MENU:");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case ConsoleKey.F1:
                    gameOver = true;
                    break;
                default:
                    Console.Clear();
                    MainMenu();
                    break;

            }
            Console.WriteLine();


        }

       public void PayOffDebt()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your current fortune is {Character.currentMoney.ToString("C2")}");
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine($"\nYour current Debt is {Character.currentDebt.ToString("C2")}");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nDo you want to pay off part of your debt with 50% of your fortune? :  Y  or  N");
            var input = Console.ReadKey();
            if (input.Key == ConsoleKey.Y)
            {
                var wallet = Character.currentMoney / 2;
                var debt = Character.currentDebt;

                debt -= Convert.ToDouble(wallet);

                Character.currentMoney = wallet;

                Character.currentDebt = debt;
                Console.WriteLine();
                Console.WriteLine($"Your new Debt value is {Character.currentDebt}");
              
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Make sure to pay off your debt or the Mafia might get mad....");
            
            }
        }

        
        public void InventoryShow()
        {
            trade.DisplayMyInventory();
        }
     
        

     
        


       


    }
}

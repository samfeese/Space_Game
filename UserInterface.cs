using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Space_Game
{
    class UserInterface
    {
        public string characterName;
        
        Random random = new Random();
        bool gameOver = false;

        Character character1;
       // Universe galaxy1;
        Travel move;
        PlanetPhase trade;
        ShipArt animation = new ShipArt();

        //private static void StarWars()
        //{
        //    Console.Beep(300, 500);
        //    Thread.Sleep(50);
        //    Console.Beep(300, 500);
        //    Thread.Sleep(50);
        //    Console.Beep(300, 500);
        //    Thread.Sleep(50);
        //    Console.Beep(250, 500);
        //    Thread.Sleep(50);
        //    Console.Beep(350, 250);
        //    Console.Beep(300, 500);
        //    Thread.Sleep(50);
        //    Console.Beep(250, 500);
        //    Thread.Sleep(50);
        //    Console.Beep(350, 250);
        //    Console.Beep(300, 500);
        //    Thread.Sleep(50);
        //}


        public void UIstart()
        {
            StarWars();

            Console.WriteLine("Please enter you character name: ");
            characterName = Console.ReadLine();

            Console.WriteLine("Hey, pick your stage in life :");
            Console.WriteLine("\n1. Beginning - You start at 18 yrs old, and have $100.");
            Console.WriteLine("2. Intermediate - You start at 22 yrs old, and have $200.");
            Console.WriteLine("3. Advanced - You start at 26 yrs old, and have $300.");
            Console.WriteLine("\nSelect number cooresponding to class");
            int userCharClass = int.Parse(Console.ReadLine());

            character1 = new Character(characterName, userCharClass);
            
            move = new Travel();
            trade = new PlanetPhase();
            move.setShip(character1.currentAge);
            trade.SetDictionary();
            //Dialog.StartGameDialog();


            trade.goods.ItemChange(50, 's');


            Console.Clear();
           
            do
            {
                MainMenu();
                if ((character1.currentAge > 60) || (Character.currentMoney < 1 && trade.assets < 10))
                {
                    gameOver = true;
                }


            } while (!gameOver);

            
        }

        public void MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A. To Move To another planet  ||B. To start trading on this Planet  ||C. To see your current stats ||F1. To end the game");
            Console.ForegroundColor = ConsoleColor.White;



            var selection = Console.ReadKey();
            Console.WriteLine();

            switch (selection.Key)
            {
                case ConsoleKey.A:
                    Console.Clear();
                    move.TravelMenu();
                    character1.Aging(Convert.ToInt32(Math.Round(move.travelTime)));
                    character1.FuelAfterTravel(move.fuelCost);
                    break;
                case ConsoleKey.B:
                    Console.Clear();
                    trade.PlanetMenu();
                    //Character.Profit(trade.bill);
                    trade.InventoryUpKeep();

                    break;
                case ConsoleKey.C:
                    Console.Clear();
                    character1.PlayerStats();
                    trade.DisplayMyInventory();
                    break;
                case ConsoleKey.F1:
                    gameOver = true;
                    break;
                default:
                    MainMenu();
                    break;

            }
           


        }

       

        
        public void InventoryShow()
        {
            trade.DisplayMyInventory();
        }
     
        

     
        


       


    }
}

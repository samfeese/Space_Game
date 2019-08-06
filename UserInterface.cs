using System;
using System.Collections.Generic;
using System.Text;

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

       
       
        public void UIstart()
        {
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

            //Dialog.StartGameDialog();


            trade.goods.ItemChange(50, 's');


            Console.Clear();
           
            do
            {
                MainMenu();
                if ((character1.currentAge > 60) || (character1.currentMoney < 1 && trade.assets < 10))
                {
                    gameOver = true;
                }


            } while (!gameOver);

            
        }

        public void MainMenu()
        {

            Console.WriteLine("A. To Move To another planet  ||B. To start trading on this Planet   || C. To see your current stats || F1. To end the game");
            var selection = Console.ReadKey();

            switch (selection.Key)
            {
                case ConsoleKey.A:
                    Console.Clear();
                    move.TravelMenu();
                    break;
                case ConsoleKey.B:
                    Console.Clear();
                    trade.PlanetMenu();
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
            upKeep();


        }

        public void upKeep()
        {
            int ageChange = Convert.ToInt32(Math.Round(move.travelTime));
            character1.Expenses(trade.bill);
            character1.Profit(trade.profit);
            character1.Aging(ageChange);
            character1.currentfuelLevel -= move.fuelCost; 
        }

        
        public void InventoryShow()
        {
            trade.DisplayMyInventory();
        }
     
        

     
        


       


    }
}

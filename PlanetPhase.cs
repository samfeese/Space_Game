using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class PlanetPhase
    {
        public int addToInventory;
     
        public string itemChanged;

        public void PlanetMenu(List<int> currentPlanet)
        {
            Console.Clear();
            Console.WriteLine("Would you like to Buy or Sell?");
            Console.WriteLine("\nPress <Esc> when done shopping");
            Console.WriteLine("\n1: Buy");
            Console.WriteLine("2. Sell");

            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.D1:
                    ShopBuy(currentPlanet);
                        break;
                case ConsoleKey.D2:
                    ShopSell(currentPlanet);
                    break;
                case ConsoleKey.Escape:
                    break;
            }

        }


        public void ShopBuy(List<int> currentPlanet)
        {
            

            Console.WriteLine("Welcome to my shop");

            Console.WriteLine("\nSelect and item to sell: ");
            Console.WriteLine();
            Console.WriteLine($"1: Skooma - {currentPlanet[0]}");
            Console.WriteLine($"2: Skooma - {currentPlanet[1]}");
            Console.WriteLine($"3: Skooma - {currentPlanet[2]}");
            Console.WriteLine($"4: Skooma - {currentPlanet[3]}");
            Console.WriteLine($"5: Skooma - {currentPlanet[4]}");

            var input = Console.ReadKey();
            string itemName;
            int quanity;
            switch (input.Key)
            {
                case ConsoleKey.D1:
                    itemName = "Skooma";
                    Console.WriteLine("How many?");
                    quanity = int.Parse(Console.ReadLine());
                    break;

                case ConsoleKey.D2:
                    itemName = "Lulu";
                    Console.WriteLine("How many?");
                    quanity = int.Parse(Console.ReadLine());
                    break;

                case ConsoleKey.D3:
                    itemName = "Skooma";
                    Console.WriteLine("How many?");
                    quanity = int.Parse(Console.ReadLine());
                    break;

                case ConsoleKey.D4:
                    itemName = "Skooma";
                    Console.WriteLine("How many?");
                    quanity = int.Parse(Console.ReadLine());
                    break;

                case ConsoleKey.D5:
                    itemName = "Skooma";
                    Console.WriteLine("How many?");
                    quanity = int.Parse(Console.ReadLine());
                    break;
                default:
                   itemName = "Skooma";
                   quanity = 0;
                    break;



            }
            ItemsTraded(itemName, quanity);

        }

        public void ShopSell(List<int> currentPlanet)
        {
            

            Console.WriteLine("Welcome to my shop");

            Console.WriteLine("\nSelect and item to sell: ");
            Console.WriteLine();
            Console.WriteLine($"1: Skooma - {currentPlanet[0]}");
            Console.WriteLine($"2: Skooma - {currentPlanet[1]}");
            Console.WriteLine($"3: Skooma - {currentPlanet[2]}");
            Console.WriteLine($"4: Skooma - {currentPlanet[3]}");
            Console.WriteLine($"5: Skooma - {currentPlanet[4]}");

            var input = Console.ReadKey();
            string itemName;
            int quanity;
            switch (input.Key)
            {
                case ConsoleKey.D1:
                    itemName = "Skooma";
                    Console.WriteLine("How many?");
                    quanity = -1 * int.Parse(Console.ReadLine());
                    break;

                case ConsoleKey.D2:
                    itemName = "Skooma";
                    Console.WriteLine("How many?");
                    quanity = -1 * int.Parse(Console.ReadLine());
                    break;

                case ConsoleKey.D3:
                    itemName = "Skooma";
                    Console.WriteLine("How many?");
                    quanity = -1 * int.Parse(Console.ReadLine());
                    break;

                case ConsoleKey.D4:
                    itemName = "Skooma";
                    Console.WriteLine("How many?");
                    quanity = -1 * int.Parse(Console.ReadLine());
                    break;

                case ConsoleKey.D5:
                    itemName = "Skooma";
                    Console.WriteLine("How many?");
                    quanity = -1 * int.Parse(Console.ReadLine());
                    break;
                default:
                    itemName = "Skooma";
                    quanity = 0;
                    break;



            }
            ItemsTraded(itemName, quanity);

        }
        public void ItemsTraded(string itemName, int quanity)
        {

            if (quanity <= 0)
            {
                itemChanged = itemName;
                addToInventory =  quanity;

            }
            if (quanity > 0)
            {
                itemChanged = itemName;
                addToInventory = quanity;
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class PlanetPhase
    {
        Inventory goods = new Inventory();

        public Dictionary<char, string> myGoods;
        public Dictionary<char, int> myLoad;

        public int addToInventory;
        public decimal bill;
        public decimal profit;
        public string itemChanged;

<<<<<<< HEAD
        decimal itemPrice = 10;

        public void Shop()
=======
        public void PlanetMenu(List<int> currentPlanet)
>>>>>>> f8aa61285384c2e5c7cd728cfe8788e2f0f45870
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


<<<<<<< HEAD
        public void DisplayGoods()
        {
            Console.WriteLine($"1: {goods.goodsName['s']} - ${itemPrice}");
            Console.WriteLine($"2: {goods.goodsName['l']} - ${itemPrice}");
            Console.WriteLine($"3: {goods.goodsName['b']} - ${itemPrice}");
            Console.WriteLine($"4: {goods.goodsName['t']} - ${itemPrice}");
            Console.WriteLine($"5: {goods.goodsName['d']} - ${itemPrice}");
        }
=======
        public void ShopBuy(List<int> currentPlanet)
        {
            
>>>>>>> f8aa61285384c2e5c7cd728cfe8788e2f0f45870

        public void ShopBuy()
        {
            Console.WriteLine("Welcome to my shop");
<<<<<<< HEAD
            Console.WriteLine("\nSelect and item to buy: ");
            Console.WriteLine();
            DisplayGoods();
=======

            Console.WriteLine("\nSelect and item to sell: ");
            Console.WriteLine();
            Console.WriteLine($"1: Skooma - {currentPlanet[0]}");
            Console.WriteLine($"2: Skooma - {currentPlanet[1]}");
            Console.WriteLine($"3: Skooma - {currentPlanet[2]}");
            Console.WriteLine($"4: Skooma - {currentPlanet[3]}");
            Console.WriteLine($"5: Skooma - {currentPlanet[4]}");

>>>>>>> f8aa61285384c2e5c7cd728cfe8788e2f0f45870
            var input = Console.ReadKey();
            Console.WriteLine("How many?");
            var quanity = int.Parse(Console.ReadLine());
           
            switch (input.Key)
            {
                case ConsoleKey.D1:
                    goods.ItemChange(quanity, 's');
                    bill += quanity * itemPrice;
                    break;

                case ConsoleKey.D2:
                    goods.ItemChange(quanity, 'l');
                    bill += quanity * itemPrice;
                    break;
                 
                case ConsoleKey.D3:
                    goods.ItemChange(quanity, 'b');
                    bill += quanity * itemPrice;
                    break;

                case ConsoleKey.D4:
                    goods.ItemChange(quanity, 't');
                    bill += quanity * itemPrice;
                    break;
                case ConsoleKey.D5:
                    goods.ItemChange(quanity, 'd');
                    bill += quanity * itemPrice;
                    break;
                default:
                  
                    break;
            }
          
            Console.WriteLine("Do you wanna buy more items? Y/N");
            var choice = Console.ReadKey();
            
            if (choice.Key == ConsoleKey.Y)
            {
                ShopBuy();
            }
           
        }

        public void ShopSell(List<int> currentPlanet)
        {
<<<<<<< HEAD
=======
            
>>>>>>> f8aa61285384c2e5c7cd728cfe8788e2f0f45870

            Console.WriteLine("Welcome to my shop");

            Console.WriteLine("\nSelect and item to sell: ");
            Console.WriteLine();
<<<<<<< HEAD
=======
            Console.WriteLine($"1: Skooma - {currentPlanet[0]}");
            Console.WriteLine($"2: Skooma - {currentPlanet[1]}");
            Console.WriteLine($"3: Skooma - {currentPlanet[2]}");
            Console.WriteLine($"4: Skooma - {currentPlanet[3]}");
            Console.WriteLine($"5: Skooma - {currentPlanet[4]}");
>>>>>>> f8aa61285384c2e5c7cd728cfe8788e2f0f45870

            DisplayGoods();
            var input = Console.ReadKey();

            Console.WriteLine("How many?");
            var quanity = int.Parse(Console.ReadLine());

            switch (input.Key)
            {
                case ConsoleKey.D1:
                    goods.ItemChange((quanity * (-1)), 's');
                    profit += quanity * itemPrice;
                    break;

                case ConsoleKey.D2:
                    goods.ItemChange((quanity * (-1)), 'l');
                    profit += quanity * itemPrice;
                    break;

                case ConsoleKey.D3:
                    goods.ItemChange((quanity * (-1)), 'b');
                    profit += quanity * itemPrice;
                    break;

                case ConsoleKey.D4:
                    goods.ItemChange((quanity * (-1)), 't');
                    profit += quanity * itemPrice;
                    break;
                case ConsoleKey.D5:
                    goods.ItemChange((quanity * (-1)), 'd');
                    profit += quanity * itemPrice;
                    break;
                default:

                    break;
            }

            Console.WriteLine("Do you wanna sell more items? Y/N");
            var choice = Console.ReadKey();

            if (choice.Key == ConsoleKey.Y)
            {
                ShopSell();
            }
            
        }

        public void InventoryUpKeep()
        {
            myGoods = goods.goodsName;
            myLoad = goods.goodsQuantity;
        }
        //public void ItemsTraded(string itemName, int quanity)
        //{

        //    if (quanity <= 0)
        //    {
        //        itemChanged = itemName;
        //        addToInventory =  quanity;

        //    }
        //    if (quanity > 0)
        //    {
        //        itemChanged = itemName;
        //        addToInventory = quanity;
        //    }

        //}

    }
}

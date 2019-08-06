using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class PlanetPhase
    {
        public Inventory goods;

        public Dictionary<char, string> myGoods;
        public Dictionary<char, int> myLoad;

        public int addToInventory;
        public decimal bill;
        public decimal profit;

        public decimal assets;
        public string itemChanged;

        decimal itemPrice = 10;

        public PlanetPhase()
        {
            goods = new Inventory();
            //PlanetMenu();
            InventoryUpKeep();
        }
      

        public void PlanetMenu()

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
                    ShopBuy();
                        break;
                case ConsoleKey.D2:
                    ShopSell();
                    break;
                case ConsoleKey.Escape:
                    break;
            }

        }


        public void DisplayGoods()
        {
            Console.WriteLine($"1: {goods.goodsName['s']} - ${itemPrice}");
            Console.WriteLine($"2: {goods.goodsName['l']} - ${itemPrice}");
            Console.WriteLine($"3: {goods.goodsName['b']} - ${itemPrice}");
            Console.WriteLine($"4: {goods.goodsName['t']} - ${itemPrice}");
            Console.WriteLine($"5: {goods.goodsName['d']} - ${itemPrice}");
            Console.WriteLine($"6: {goods.goodsName['f']} - ${itemPrice}");
        }

          

        public void ShopBuy()
        {
            Console.WriteLine("Welcome to my shop");

            Console.WriteLine("\nSelect and item to buy: ");
            Console.WriteLine();
            DisplayGoods();

            var input = Console.ReadKey();
            Console.WriteLine("How many?");
            var quanity = int.Parse(Console.ReadLine());
            profit = 0;
            switch (input.Key)
            {
                case ConsoleKey.D1:
                    goods.ItemChange(quanity, 's');
                    break;

                case ConsoleKey.D2:
                    goods.ItemChange(quanity, 'l');
                    break;
                 
                case ConsoleKey.D3:
                    goods.ItemChange(quanity, 'b');
                    break;

                case ConsoleKey.D4:
                    goods.ItemChange(quanity, 't');
                    break;
                case ConsoleKey.D5:
                    goods.ItemChange(quanity, 'd');
                    break;
                default:
                  
                    break;
            }
            profit = (-1) * (quanity * itemPrice);

            Console.WriteLine("Do you wanna buy more items? Y/N");
            var choice = Console.ReadKey();
            
            if (choice.Key == ConsoleKey.Y)
            {
                ShopBuy();
            }
           
        }

        public void ShopSell()
        {

            Console.WriteLine("Welcome to my shop");

            Console.WriteLine("\nSelect and item to sell: ");
            Console.WriteLine();

            DisplayGoods();
            var input = Console.ReadKey();

            Console.WriteLine("How many?");
            var quanity = int.Parse(Console.ReadLine());
            profit = 0;
            switch (input.Key)
            {
                case ConsoleKey.D1:
                    goods.ItemChange((quanity * (-1)), 's');
                    break;

                case ConsoleKey.D2:
                    goods.ItemChange((quanity * (-1)), 'l');
                    break;

                case ConsoleKey.D3:
                    goods.ItemChange((quanity * (-1)), 'b');
                    break;

                case ConsoleKey.D4:
                    goods.ItemChange((quanity * (-1)), 't');
                    break;
                case ConsoleKey.D5:
                    goods.ItemChange((quanity * (-1)), 'd');
                    break;
                default:

                    break;
            }
            profit =(quanity * itemPrice);

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
            //DisplayMyInventory();
        }

        public void DisplayMyInventory()
        {
            Console.WriteLine("You currently have the following in your inventory");
            Console.WriteLine($"1: {myGoods['s']} - {myLoad['s']}");
            Console.WriteLine($"2: {myGoods['l']} - {myLoad['l']}");
            Console.WriteLine($"3: {myGoods['b']} - {myLoad['b']}");
            Console.WriteLine($"4: {myGoods['t']} - {myLoad['t']}");
            Console.WriteLine($"5: {myGoods['d']} - {myLoad['d']}");

            assets += myLoad['s'] * itemPrice;
            assets += myLoad['l'] * itemPrice;
            assets += myLoad['b'] * itemPrice;
            assets += myLoad['t'] * itemPrice;
            assets += myLoad['d'] * itemPrice;

            Console.WriteLine($"The value of my inventory is ${assets}");

        }

    }
}

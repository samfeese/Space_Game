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
           
            

            Console.WriteLine($"1: {goods.goodsName['s']} - ${RandomMod()}");
            Console.WriteLine($"2: {goods.goodsName['l']} - ${RandomMod()}");
            Console.WriteLine($"3: {goods.goodsName['b']} - ${RandomMod()}");
            Console.WriteLine($"4: {goods.goodsName['t']} - ${RandomMod()}");
            Console.WriteLine($"5: {goods.goodsName['d']} - ${RandomMod()}");
            Console.WriteLine($"6: {goods.goodsName['f']} - ${RandomMod()}");
        }
        public decimal RandomMod()
        {
            Random rand = new Random();
            itemPrice = 10;
            decimal mod = Convert.ToDecimal(rand.Next(0, 1) + rand.NextDouble());
            itemPrice *= mod;
            return itemPrice;
           
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

        public void ShopSell()
        {

            Console.WriteLine("Welcome to my shop");

            Console.WriteLine("\nSelect and item to sell: ");
            Console.WriteLine();

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

            var a= myLoad['s'] * itemPrice;
            var b= myLoad['l'] * itemPrice;
            var c= myLoad['b'] * itemPrice;
            var d= myLoad['t'] * itemPrice;
            var e= myLoad['d'] * itemPrice;

            assets = (a + b + c + d + e);

            Console.WriteLine($"The value of my inventory is ${assets}");

            //foreach (var item in myLoad)
            //{
            //    assets += myLoad * itemPrice;
            //}

        }
       
    }
}

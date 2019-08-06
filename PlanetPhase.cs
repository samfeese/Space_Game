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
        public Dictionary<char, decimal> priceValues = new Dictionary<char, decimal>();

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
            Console.WriteLine();

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


        public void SetDictionary()
        {
            priceValues.Add('s', 10);
            priceValues.Add('l', 10);
            priceValues.Add('b', 10);
            priceValues.Add('t', 10);
            priceValues.Add('d', 10);
            priceValues.Add('f', 10);
        } 
        public void DisplayGoods()
        {


           

            decimal addList;
            addList = itemPrice * RandomMod();
            Console.WriteLine($"1: {goods.goodsName['s']} - ${addList}");
            priceValues['s'] = addList;

            addList = itemPrice * RandomMod();
            Console.WriteLine($"2: {goods.goodsName['l']} - ${addList}");
            priceValues['l'] = addList;

            addList = itemPrice * RandomMod();
            Console.WriteLine($"3: {goods.goodsName['b']} - ${addList}");
            priceValues['b'] = addList;

            addList = itemPrice * RandomMod();
            Console.WriteLine($"4: {goods.goodsName['t']} - ${addList}");
            priceValues['t'] = addList;

            addList = itemPrice * RandomMod();
            Console.WriteLine($"5: {goods.goodsName['d']} - ${addList}");
            priceValues['d'] = addList;

            addList = itemPrice * RandomMod();
            Console.WriteLine($"6: {goods.goodsName['f']} - ${addList}");
            priceValues['f'] = addList;
            
            
        }
        private decimal RandomMod()
        {
            Random rand = new Random();
            
            decimal mod = Convert.ToDecimal(rand.Next(0, 1) + rand.NextDouble());
            return mod;
           
        }
          

        public void ShopBuy()
        {
            Console.WriteLine("Welcome to my shop");

            Console.WriteLine("\nSelect and item to buy: ");
            Console.WriteLine();

           
            DisplayGoods();

            Console.WriteLine();
            Console.WriteLine($"Your current fortune is {Character.currentMoney}");
            var input = Console.ReadKey();

            Console.WriteLine();

            Console.WriteLine("How many?");
            
            var quanity = int.Parse(Console.ReadLine());


         

            bill = 0;

            
          
            char temp;

            switch (input.Key)
            {
                case ConsoleKey.D1:
                    temp = 's';
                    if (Character.currentMoney < (quanity * priceValues[temp]))
                    {
                        Console.WriteLine("You do not have enough money you dummy, take math again.");
                        break;
                    }
                    goods.ItemChange(quanity, 's');
                   
                    bill = (-1) * (quanity * priceValues[temp]);
                    break;
                  

                case ConsoleKey.D2:
                    goods.ItemChange(quanity, 'l');
                    temp = 'l';
                    bill = (-1) * (quanity * priceValues[temp]);
                    break;
                 
                case ConsoleKey.D3:
                    goods.ItemChange(quanity, 'b');
                    temp = 'b';
                    bill = (-1) * (quanity * priceValues[temp]);
                    break;

                case ConsoleKey.D4:
                    goods.ItemChange(quanity, 't');
                    temp = 't';
                    bill = (-1) * (quanity * priceValues[temp]);
                    break;
                case ConsoleKey.D5:
                    goods.ItemChange(quanity, 'd');
                    temp = 'd';
                    bill = (-1) * (quanity * priceValues[temp]);
                    break;
                default:
                  
                    break;
            }
            Console.WriteLine($"Your total is {bill}");
            Character.Profit(bill);

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
            Console.WriteLine();
            Console.WriteLine("How many?");
            var quanity = int.Parse(Console.ReadLine());
            bill = 0;
            char temp;
            switch (input.Key)
            {
                case ConsoleKey.D1:
                    goods.ItemChange((quanity * (-1)), 's');
                    temp = 's';
                    bill = (quanity * priceValues[temp]);
                    break;

                case ConsoleKey.D2:
                    goods.ItemChange((quanity * (-1)), 'l');
                    temp = 'l';
                    bill = (quanity * priceValues[temp]);
                    break;

                case ConsoleKey.D3:
                    goods.ItemChange((quanity * (-1)), 'b');
                    temp = 'b';
                    bill = (quanity * priceValues[temp]);
                    break;

                case ConsoleKey.D4:
                    goods.ItemChange((quanity * (-1)), 't');
                    temp = 't';
                    bill = (quanity * priceValues[temp]);
                    break;
                case ConsoleKey.D5:
                    goods.ItemChange((quanity * (-1)), 'd');
                    temp = 'd';
                    bill = (quanity * priceValues[temp]);
                    break;
                default:

                    break;
            }
            Console.WriteLine($"Your total is {bill}");
            Character.Profit(bill);

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

            var a= myLoad['s'] * priceValues['s'];
            var b= myLoad['l'] * priceValues['l'];
            var c= myLoad['b'] * priceValues['b'];
            var d= myLoad['t'] * priceValues['t'];
            var e= myLoad['d'] * priceValues['d'];

            assets = (a + b + c + d + e);

            Console.WriteLine($"The value of my inventory is ${assets}");

        }
       
    }
}

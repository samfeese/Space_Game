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
        public double fuelBuy;
        int quantity;

        public decimal assets;
        public string itemChanged;

        public Dictionary<char, decimal> priceValues = new Dictionary<char, decimal>();

        decimal itemPrice = 10;

        public PlanetPhase()
        {
            goods = new Inventory();

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
                    Console.Clear();
                    break;
                default:
                    PlanetMenu();
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
        public void DisplayGoodsBuy()
        {

            decimal addList;
            addList = itemPrice * RandomMod();
            Console.WriteLine($"1: {goods.goodsName['s']} - {addList.ToString("C2")}");
            priceValues['s'] = addList;

            addList = itemPrice * RandomMod();
            Console.WriteLine($"2: {goods.goodsName['l']} - {addList.ToString("C2")}");
            priceValues['l'] = addList;

            addList = itemPrice * RandomMod();
            Console.WriteLine($"3: {goods.goodsName['b']} - {addList.ToString("C2")}");
            priceValues['b'] = addList;

            addList = itemPrice * RandomMod();
            Console.WriteLine($"4: {goods.goodsName['t']} - {addList.ToString("C2")}");
            priceValues['t'] = addList;

            addList = itemPrice * RandomMod();
            Console.WriteLine($"5: {goods.goodsName['d']} - {addList.ToString("C2")}");
            priceValues['d'] = addList;

            addList = 10 * itemPrice * RandomMod();
            Console.WriteLine($"6: {goods.goodsName['f']} - {addList.ToString("C2")}");
            priceValues['f'] = addList;


        }
        public void DisplayGoodsSell()
        {


            decimal distanceMod = Convert.ToDecimal(Travel.travelDistance / 25);
            decimal addList;

            addList = distanceMod * itemPrice * RandomMod();
            Console.WriteLine($"1: {goods.goodsName['s']} - {addList.ToString("C2")}");
            priceValues['s'] = addList;

            addList = distanceMod * itemPrice * RandomMod();
            Console.WriteLine($"2: {goods.goodsName['l']} - {addList.ToString("C2")}");
            priceValues['l'] = addList;

            addList = distanceMod * itemPrice * RandomMod();
            Console.WriteLine($"3: {goods.goodsName['b']} - {addList.ToString("C2")}");
            priceValues['b'] = addList;

            addList = distanceMod * itemPrice * RandomMod();
            Console.WriteLine($"4: {goods.goodsName['t']} - {addList.ToString("C2")}");
            priceValues['t'] = addList;


            addList = distanceMod * itemPrice * RandomMod();
            Console.WriteLine($"5: {goods.goodsName['d']} - {addList.ToString("C2")}");
            priceValues['d'] = addList;



        }

        private decimal RandomMod()
        {
            Random rand = new Random();

            decimal mod = Convert.ToDecimal(rand.Next(0, 1) + rand.NextDouble());
            return mod;

        }


        public void ShopBuy()
        {
            Console.Clear();


            Console.WriteLine("Welcome to my shop");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Press F1 to go back to MAIN MENU");

            Console.WriteLine("\nSelect and item to buy: ");
            Console.WriteLine();


            DisplayGoodsBuy();

            Console.WriteLine();
            Console.WriteLine($"Your current fortune is {Character.currentMoney.ToString("C2")}");
            var input = Console.ReadKey();


            Console.WriteLine();

           


            bill = 0;
            fuelBuy = 0;
            quantity = 0;

            switch (input.Key)
            {
                case ConsoleKey.D1:
                    Buy('s');
                    break;

                case ConsoleKey.D2:
                    Buy('l');
                    break;

                case ConsoleKey.D3:
                    Buy('b');
                    break;

                case ConsoleKey.D4:
                    Buy('t');
                    break;

                case ConsoleKey.D5:
                    Buy('d');
                    break;

                case ConsoleKey.D6:
                    Buy('f');
                    fuelBuy = quantity;
                    break;

                case ConsoleKey.F1:
                    break;

                default:
                    Console.Clear();
                    ShopBuy();
                    break;
            }


            Console.Clear();
        }


        private void Buy( char temp)
        {
         

            Console.WriteLine("How many?");

            var valid = int.TryParse(Console.ReadLine(), out quantity);

            while (!valid)
            {

                Console.WriteLine("\bInvalid Input\n");
                Console.Write("Please try again.......");
                valid = int.TryParse(Console.ReadLine(), out quantity);
            }
            if (Character.currentMoney < (quantity * priceValues[temp]))
            {
                Console.WriteLine("You do not have enough money you dummy, take math again.");

            }
            else
            {
                goods.ItemChange(quantity, temp);

                bill = (-1) * (quantity * priceValues[temp]);

                Console.WriteLine($"Your total is {bill.ToString("C2")}");

                Character.Profit(bill);

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
            Console.Clear();

          

            Console.WriteLine("Welcome to my shop");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Press F1 to go back to MAIN MENU");
            Console.WriteLine("\nSelect and item to sell: ");
            Console.WriteLine();

            DisplayMyInventory();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Pick the item you want to sell :");

            DisplayGoodsSell();

            var input = Console.ReadKey();
            Console.WriteLine();

            bill = 0;
            quantity = 0;

            switch (input.Key)
            {
                case ConsoleKey.D1:
                    Sell('s');
                    break;

                case ConsoleKey.D2:
                    Sell('l');
                    break;

                case ConsoleKey.D3:
                    Sell('b');
                    break;

                case ConsoleKey.D4:
                    Sell('t');
                    break;

                case ConsoleKey.D5:
                    Sell('d');
                    break;

                case ConsoleKey.F1:
                    break;

                default:
                    Console.Clear();
                    ShopSell();

                    break;
            }

            Console.Clear();

        }

        void Sell(char temp)
        {

            Console.WriteLine("How many?");
            var valid = int.TryParse(Console.ReadLine(), out quantity);

            while (!valid)
            {

                Console.WriteLine("\bInvalid Input\n");
                Console.Write("Please enter quantity again.......");
                valid = int.TryParse(Console.ReadLine(), out quantity);
            }

            if (goods.goodsQuantity[temp] < quantity)
            {
                Console.WriteLine("You dont have enought to sell try again.");
            }

            else
            {
                goods.ItemChange((quantity * (-1)), 's');

                bill = (quantity * priceValues[temp]);

                Console.WriteLine($"Your total is {bill.ToString("C2")}");
                Character.Profit(bill);

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

        public void DisplayMyInventory()
        {
            Console.WriteLine("You currently have the following in your inventory");
            Console.WriteLine($"1: {myGoods['s']} - {myLoad['s']}");
            Console.WriteLine($"2: {myGoods['l']} - {myLoad['l']}");
            Console.WriteLine($"3: {myGoods['b']} - {myLoad['b']}");
            Console.WriteLine($"4: {myGoods['t']} - {myLoad['t']}");
            Console.WriteLine($"5: {myGoods['d']} - {myLoad['d']}");

            var a = myLoad['s'] * priceValues['s'];
            var b = myLoad['l'] * priceValues['l'];
            var c = myLoad['b'] * priceValues['b'];
            var d = myLoad['t'] * priceValues['t'];
            var e = myLoad['d'] * priceValues['d'];

            assets = (a + b + c + d + e);


        }

    }
}

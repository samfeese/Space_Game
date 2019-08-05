using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    

    class Inventory
    {

        public static Dictionary<char, string> goodsName = new Dictionary<char, string>();
        public static Dictionary<char,  int> goodsQuantity = new Dictionary<char, int>();

        public Inventory()
        {
            SetGoodsNames();
            setQuantity();
        }

       public void SetGoodsNames()
        {
            goodsName.Add('s', "Skooma");
            goodsName.Add('l', "Lulu");
            goodsName.Add('b', "Brams");
            goodsName.Add('t', "Targens");
            goodsName.Add('d', "Dryer Lint");
            goodsName.Add('f', "Fuel");
        }

        public void setQuantity()
        {
            goodsQuantity.Add('s', 0);
            goodsQuantity.Add('l', 0);
            goodsQuantity.Add('b', 0);
            goodsQuantity.Add('t', 0);
            goodsQuantity.Add('d', 0);
            goodsQuantity.Add('f', 0);
        }

        public void AddNewItem(char key, string itemName) => goodsName.Add(key, itemName);
        public void ItemChange(int howMany, char what) => goodsQuantity[what] += howMany;
        public static void InventoryArt()
        {
            
            Console.WriteLine("________________________________________");
            Console.WriteLine("|                                      |");
            Console.Write("|");


            if (goodsQuantity['s'] < 10)
            {
                Console.Write("---");
                Console.Write($"{goodsName['s']}: {goodsQuantity['s']}");
                Console.Write("-------");
            }
            else if (goodsQuantity['s'] >= 10 && goodsQuantity['s'] < 100)
            {
                Console.Write("---");
                Console.Write($"Skooma: {goodsQuantity['s']}");
                Console.Write("------");
            }

            if (goodsQuantity['l'] < 10)
            {
                Console.Write("---");
                Console.Write($"Lulu: {goodsQuantity['l']}");
                Console.Write("---------");
            }
            else if (goodsQuantity['l'] >= 10 && goodsQuantity['l'] < 100)
            {
                Console.Write("---");
                Console.Write($"Lulu: {goodsQuantity['l']}");
                Console.Write("-------");
            }


            Console.WriteLine("|");
            Console.WriteLine("|                                      |");
            Console.Write("|");
            if (goodsQuantity['b'] < 10)
            {
                Console.Write("---");
                Console.Write($"Brams: {goodsQuantity['b']}");
                Console.Write("-------");
            }
            else if (goodsQuantity['b'] >= 10 && goodsQuantity['b'] < 100)
            {
                Console.Write("---");
                Console.Write($"Brams: {goodsQuantity['b']}");
                Console.Write("------");
            }

            if (goodsQuantity['t'] < 10)
            {
                Console.Write("---");
                Console.Write($"Targens: {goodsQuantity['t']}");
                Console.Write("---------");
            }
            else if (goodsQuantity['t'] >= 10 && goodsQuantity['t'] < 100)
            {
                Console.Write("---");
                Console.Write($"Targens: {goodsQuantity['t']}");
                Console.Write("-------");
            }
            Console.WriteLine("|");
            Console.WriteLine("|                                      |");
            Console.Write("|");
            if (goodsQuantity['d'] < 10)
            {
                Console.Write("---");
                Console.Write($"Dryer Lint: {goodsQuantity['d']}");
                Console.Write("-------");
            }
            else if (goodsQuantity['d'] >= 10 && goodsQuantity['d'] < 100)
            {
                Console.Write("---");
                Console.Write($"Dryer Lint: {goodsQuantity['d']}");
                Console.Write("------");
            }

            if (goodsQuantity['f'] < 10)
            {
                Console.Write("---");
                Console.Write($"Fuel: {goodsQuantity['f']}");
                Console.Write("---------");
            }
            else if (goodsQuantity['f'] >= 10 && goodsQuantity['f'] < 100)
            {
                Console.Write("---");
                Console.Write($"Fuel: {goodsQuantity['f']}");
                Console.Write("-------");
            }

            Console.WriteLine("|");
            Console.WriteLine("|                                      |");

            Console.WriteLine("|______________________________________|");


        }




    }

   
}

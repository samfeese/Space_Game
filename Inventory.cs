using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{


    class Inventory
    {

        public Dictionary<char, string> goodsName = new Dictionary<char, string>();
        public Dictionary<char, int> goodsQuantity = new Dictionary<char, int>();



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


        public  void InventoryArt()
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
            if (goodsQuantity['s'] < 10)
            {
                Console.Write("---");
                Console.Write($"Skooma: {goodsQuantity['s']}");
                Console.Write("-------");
            }
            //else if (goodsQuantity["Skooma"] >= 10 && goodsQuantity["Skooma"] < 100)
            //{
            //    Console.Write("---");
            //    Console.Write($"Skooma: {goodsQuantity["Skooma"]}");
            //    Console.Write("------");
            //}

            //if (goodsQuantity["Lulu"] < 10)
            //{
            //    Console.Write("---");
            //    Console.Write($"Lulu: {goodsQuantity["Lulu"]}");
            //    Console.Write("---------");
            //}
            //else if (goodsQuantity["Lulu"] >= 10 && goodsQuantity["Lulu"] < 100)
            //{
            //    Console.Write("---");
            //    Console.Write($"Lulu: {goodsQuantity["Lulu"]}");
            //    Console.Write("-------");
            //}
            //Console.WriteLine("|");
            //Console.WriteLine("|                                      |");
            //Console.Write("|");
            //if (goodsQuantity["Skooma"] < 10)
            //{
            //    Console.Write("---");
            //    Console.Write($"Skooma: {goodsQuantity["Skooma"]}");
            //    Console.Write("-------");
            //}
            //else if (goodsQuantity["Skooma"] >= 10 && goodsQuantity["Skooma"] < 100)
            //{
            //    Console.Write("---");
            //    Console.Write($"Skooma: {goodsQuantity["Skooma"]}");
            //    Console.Write("------");
            //}

            //if (goodsQuantity["Lulu"] < 10)
            //{
            //    Console.Write("---");
            //    Console.Write($"Lulu: {goodsQuantity["Lulu"]}");
            //    Console.Write("---------");
            //}
            //else if (goodsQuantity["Lulu"] >= 10 && goodsQuantity["Lulu"] < 100)
            //{
            //    Console.Write("---");
            //    Console.Write($"Lulu: {goodsQuantity["Lulu"]}");
            //    Console.Write("-------");

            //    Console.WriteLine("|");
            //Console.WriteLine("|                                      |");
            //Console.Write("|");
            //if (inventory["Brams"] < 10)
            //{
            //    Console.Write("---");
            //    Console.Write($"Brams: {inventory["Brams"]}");
            //    Console.Write("-------");
            //}
            //else if (inventory["Brams"] >= 10 && inventory["Brams"] < 100)
            //{
            //    Console.Write("---");
            //    Console.Write($"Brams: {inventory["Brams"]}");
            //    Console.Write("------");
            //}

            //if (inventory["Targens"] < 10)
            //{
            //    Console.Write("---");
            //    Console.Write($"Targens: {inventory["Targens"]}");
            //    Console.Write("---------");
            //}
            //else if (inventory["Targens"] >= 10 && inventory["Targens"] < 100)
            //{
            //    Console.Write("---");
            //    Console.Write($"Targens: {inventory["Targens"]}");
            //    Console.Write("-------");
            //}
            //Console.WriteLine("|");
            //Console.WriteLine("|                                      |");
            //Console.Write("|");
            //if (inventory["Dryer Lint"] < 10)
            //{
            //    Console.Write("---");
            //    Console.Write($"Dryer Lint: {inventory["Dryer Lint"]}");
            //    Console.Write("-------");
            //}
            //else if (inventory["Dryer Lint"] >= 10 && inventory["Dryer Lint"] < 100)
            //{
            //    Console.Write("---");
            //    Console.Write($"Dryer Lint: {inventory["Dryer Lint"]}");
            //    Console.Write("------");
            //}

            //if (inventory["Fuel"] < 10)
            //{
            //    Console.Write("---");
            //    Console.Write($"LuluFuel {inventory["Fuel"]}");
            //    Console.Write("---------");
            //}
            //else if (inventory["Fuel"] >= 10 && inventory["Fuel"] < 100)
            //{
            //    Console.Write("---");
            //    Console.Write($"Fuel: {inventory["Fuel"]}");
            //    Console.Write("-------");
            //}

            //    Console.WriteLine("|");
            //    Console.WriteLine("|                                      |");

            //    Console.WriteLine("|______________________________________|");

        }
    }
        
    
}
       

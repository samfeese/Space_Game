using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    

    class Inventory
    {
<<<<<<< HEAD

        public Dictionary<char, string> goodsName = new Dictionary<char, string>();
        public Dictionary<char,  int> goodsQuantity = new Dictionary<char, int>();
=======
        public static Dictionary<string, int> inventory = new Dictionary<string, int>();
        
>>>>>>> 287fb2f5461eb03d4f05f70cf241d44d0d83e4de

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
<<<<<<< HEAD

        public void setQuantity()
=======
        public static void ItemChange(int change, string thing)
>>>>>>> 287fb2f5461eb03d4f05f70cf241d44d0d83e4de
        {
            goodsQuantity.Add('s', 0);
            goodsQuantity.Add('l', 0);
            goodsQuantity.Add('b', 0);
            goodsQuantity.Add('t', 0);
            goodsQuantity.Add('d', 0);
            goodsQuantity.Add('f', 0);
        }
<<<<<<< HEAD

        public void AddNewItem(char key, string itemName) => goodsName.Add(key, itemName);
        public void ItemChange(int howMany, char what) => goodsQuantity[what] += howMany;
        public void InventoryArt()
=======
        public static void InventoryArt()
>>>>>>> 287fb2f5461eb03d4f05f70cf241d44d0d83e4de
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
        //    else if (goodsQuantity["Skooma"] >= 10 && goodsQuantity["Skooma"] < 100)
        //    {
        //        Console.Write("---");
        //        Console.Write($"Skooma: {goodsQuantity["Skooma"]}");
        //        Console.Write("------");
        //    }

        //    if (goodsQuantity["Lulu"] < 10)
        //    {
        //        Console.Write("---");
        //        Console.Write($"Lulu: {goodsQuantity["Lulu"]}");
        //        Console.Write("---------");
        //    }
        //    else if (goodsQuantity["Lulu"] >= 10 && goodsQuantity["Lulu"] < 100)
        //    {
        //        Console.Write("---");
        //        Console.Write($"Lulu: {goodsQuantity["Lulu"]}");
        //        Console.Write("-------");
        //    }

           
<<<<<<< HEAD
        //    Console.WriteLine("|");
        //    Console.WriteLine("|                                      |");
        //    Console.Write("|");
        //    if (goodsQuantity["Skooma"] < 10)
        //    {
        //        Console.Write("---");
        //        Console.Write($"Skooma: {goodsQuantity["Skooma"]}");
        //        Console.Write("-------");
        //    }
        //    else if (goodsQuantity["Skooma"] >= 10 && goodsQuantity["Skooma"] < 100)
        //    {
        //        Console.Write("---");
        //        Console.Write($"Skooma: {goodsQuantity["Skooma"]}");
        //        Console.Write("------");
        //    }

        //    if (goodsQuantity["Lulu"] < 10)
        //    {
        //        Console.Write("---");
        //        Console.Write($"Lulu: {goodsQuantity["Lulu"]}");
        //        Console.Write("---------");
        //    }
        //    else if (goodsQuantity["Lulu"] >= 10 && goodsQuantity["Lulu"] < 100)
        //    {
        //        Console.Write("---");
        //        Console.Write($"Lulu: {goodsQuantity["Lulu"]}");
        //        Console.Write("-------");
        //    }
        //    Console.WriteLine("|");
        //    Console.WriteLine("|                                      |");
        //    Console.Write("|");
        //    if (goodsQuantity["Skooma"] < 10)
        //    {
        //        Console.Write("---");
        //        Console.Write($"Skooma: {goodsQuantity["Skooma"]}");
        //        Console.Write("-------");
        //    }
        //    else if (goodsQuantity["Skooma"] >= 10 && goodsQuantity["Skooma"] < 100)
        //    {
        //        Console.Write("---");
        //        Console.Write($"Skooma: {goodsQuantity["Skooma"]}");
        //        Console.Write("------");
        //    }

        //    if (goodsQuantity["Lulu"] < 10)
        //    {
        //        Console.Write("---");
        //        Console.Write($"Lulu: {goodsQuantity["Lulu"]}");
        //        Console.Write("---------");
        //    }
        //    else if (goodsQuantity["Lulu"] >= 10 && goodsQuantity["Lulu"] < 100)
        //    {
        //        Console.Write("---");
        //        Console.Write($"Lulu: {goodsQuantity["Lulu"]}");
        //        Console.Write("-------");
        //    }
=======
            Console.WriteLine("|");
            Console.WriteLine("|                                      |");
            Console.Write("|");
            if (inventory["Brams"] < 10)
            {
                Console.Write("---");
                Console.Write($"Brams: {inventory["Brams"]}");
                Console.Write("-------");
            }
            else if (inventory["Brams"] >= 10 && inventory["Brams"] < 100)
            {
                Console.Write("---");
                Console.Write($"Brams: {inventory["Brams"]}");
                Console.Write("------");
            }

            if (inventory["Targens"] < 10)
            {
                Console.Write("---");
                Console.Write($"Targens: {inventory["Targens"]}");
                Console.Write("---------");
            }
            else if (inventory["Targens"] >= 10 && inventory["Targens"] < 100)
            {
                Console.Write("---");
                Console.Write($"Targens: {inventory["Targens"]}");
                Console.Write("-------");
            }
            Console.WriteLine("|");
            Console.WriteLine("|                                      |");
            Console.Write("|");
            if (inventory["Dryer Lint"] < 10)
            {
                Console.Write("---");
                Console.Write($"Dryer Lint: {inventory["Dryer Lint"]}");
                Console.Write("-------");
            }
            else if (inventory["Dryer Lint"] >= 10 && inventory["Dryer Lint"] < 100)
            {
                Console.Write("---");
                Console.Write($"Dryer Lint: {inventory["Dryer Lint"]}");
                Console.Write("------");
            }

            if (inventory["Fuel"] < 10)
            {
                Console.Write("---");
                Console.Write($"LuluFuel {inventory["Fuel"]}");
                Console.Write("---------");
            }
            else if (inventory["Fuel"] >= 10 && inventory["Fuel"] < 100)
            {
                Console.Write("---");
                Console.Write($"Fuel: {inventory["Fuel"]}");
                Console.Write("-------");
            }
>>>>>>> 287fb2f5461eb03d4f05f70cf241d44d0d83e4de

        //    Console.WriteLine("|");
        //    Console.WriteLine("|                                      |");
           
        //    Console.WriteLine("|______________________________________|");
            

        }
       



    }

   
}

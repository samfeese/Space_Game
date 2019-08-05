using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    

    class Inventory
    {

        public Dictionary<char, string> goodsName = new Dictionary<char, string>();
        public Dictionary<char,  int> goodsQuantity = new Dictionary<char, int>();

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
        public void InventoryArt()
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

        //    Console.WriteLine("|");
        //    Console.WriteLine("|                                      |");
           
        //    Console.WriteLine("|______________________________________|");
            

        }
       



    }

   
}

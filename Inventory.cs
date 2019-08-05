using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    

    class Inventory
    {
        public static Dictionary<string, int> inventory = new Dictionary<string, int>();
        

        public Inventory()
        {           
            inventory.Add("Skooma", 0);
            inventory.Add("Lulu", 0);
            inventory.Add("Brams", 0);
            inventory.Add("Targens", 0);
            inventory.Add("Dryer Lint", 0);

        }
        public static void ItemChange(int change, string thing)
        {
             inventory[thing] += change;
                      
        }
        public static void InventoryArt()
        {
            Console.WriteLine("________________________________________");
            Console.WriteLine("|                                      |");
            Console.Write("|");
           
                
            if (inventory["Skooma"] < 10)
            {
                Console.Write("---");
                Console.Write($"Skooma: {inventory["Skooma"]}");
                Console.Write("-------");
            }
            else if (inventory["Skooma"] >= 10 && inventory["Skooma"] < 100)
            {
                Console.Write("---");
                Console.Write($"Skooma: {inventory["Skooma"]}");
                Console.Write("------");
            }

            if (inventory["Lulu"] < 10)
            {
                Console.Write("---");
                Console.Write($"Lulu: {inventory["Lulu"]}");
                Console.Write("---------");
            }
            else if (inventory["Lulu"] >= 10 && inventory["Lulu"] < 100)
            {
                Console.Write("---");
                Console.Write($"Lulu: {inventory["Lulu"]}");
                Console.Write("-------");
            }

           
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

            Console.WriteLine("|");
            Console.WriteLine("|                                      |");
           
            Console.WriteLine("|______________________________________|");
            

        }
       



    }
}

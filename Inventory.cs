using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    

    class Inventory
    {
        public Dictionary<string, int> inventory = new Dictionary<string, int>();
        

        public Inventory()
        {           
            inventory.Add("Skooma", 0);
            inventory.Add("Lulu", 0);
            inventory.Add("Brams", 0);
            inventory.Add("Targens", 0);
            inventory.Add("Dryer Lint", 0);

        }
        public void ItemChange(int change, string thing)
        {
             inventory[thing] += change;
                      
        }
        public void InventoryArt()
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
           
            Console.WriteLine("|______________________________________|");
            

        }
       



    }
}

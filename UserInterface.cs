using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class UserInterface
    {
        public string characterName;
        public int currentAge;
        public decimal currentMoney;

        Character character1;
        Universe galaxy1 = new Universe();

        Inventory handOver = new Inventory();

        public void UIstart()
        {
            Console.WriteLine("Please enter you character name: ");
            characterName = Console.ReadLine();

            Console.WriteLine("Hey, pick your stage in life :");
            Console.WriteLine("\n1. Beginning");
            Console.WriteLine("2. Intermediate");
            Console.WriteLine("3. Advanced");
            Console.WriteLine("\nSelect number cooresponding to class");
            int userCharClass = int.Parse(Console.ReadLine());

            character1 = new Character(characterName, userCharClass);

            Console.WriteLine($"Hey {character1.userName}");
           
        }

        public void Explore()
        {

            Console.WriteLine("press Esc to stop and enter to go to another planet");
            var input = Console.ReadKey();

            galaxy1.PlanetPlacement();
            do
            {
                galaxy1.PlanetChoice();
                galaxy1.MovePlanet();
            } while (input.Key != ConsoleKey.Escape);
        }
       
       
        public void ChangeInventory(int valueOfItem)
        {
            handOver.ItemA(valueOfItem, handOver.skooma);
            Console.WriteLine($"{handOver.skooma.Item2}");
        }


    }
}

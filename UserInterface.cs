using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class UserInterface
    {
        public string name;
        public int currentAge;
        public decimal currentMoney;

        
        public void UIstart()
        {


            Console.WriteLine("Please enter you character name: ");

            name = Console.ReadLine();
            
            Console.WriteLine("Hey, pick your stage in life :");
            Console.WriteLine("\n1. Beginning");
            Console.WriteLine("2. Intermediate");
            Console.WriteLine("3. Advanced");
            Console.WriteLine("\nSelect number cooresponding to class");
            int userCharClass = int.Parse(Console.ReadLine());


            //(currentAge, currentMoney) = (c1.SetCharacterClass(userCharClass));

           
            Character c1 = new Character(name, userCharClass);

        }
        public void PlanetPlacement()
        {
            Planet planet3 = new Planet();
            Planet planet4 = new Planet();
            Planet planet5 = new Planet();

            (string, (double, double)) planetA = (planet3.planetName, planet3.planetCoordinate);

            (string, (double, double)) planetB = (planet4.planetName, planet4.planetCoordinate);

            (string, (double, double)) planetC = (planet5.planetName, planet5.planetCoordinate);

            Console.WriteLine($"The first generated planet is {planetA.Item1} and is at coordinates {planetA.Item2}");

            double howFar = planet3.Distance((planetA.Item2), (planetB.Item2));

            Console.WriteLine($"{howFar}");




        }











    }
    }

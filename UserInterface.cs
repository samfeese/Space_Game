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
        //public (string, int, decimal) SetInfo()
        //{
        //    string userName = name;


        //    return (userName, currentAge, currentMoney);

        //}











    }
}

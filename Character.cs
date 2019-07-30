using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Character
    {
        public Character( int age, decimal money)
        {
            SetName();
            //SetCharacterClass(age);
            SetStartMoney(age);
        }

        public string SetName()
        {
            Console.WriteLine("Please enter you character name: ");
            var name = Console.ReadLine();

            return name;
        }
        public decimal SetStartMoney(int age)
        {
            decimal startMoney = 0;
            if (age == 18)
            {
                startMoney = 100;
                //SetCharacterClass("Beginer");
            }
            else if (age == 22)
            {
                startMoney = 200;
               // SetCharacterClass("Itermediate");
            }
            else if (age == 26)
            {
                startMoney = 300;
                //SetCharacterClass("Advanced");
            }

            return startMoney;
        }


        //public string SetCharacterClass(string n)
        //{

        //    var characterClass = n;

        //    return characterClass;
        //}

        
    }
}

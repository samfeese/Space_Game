using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Character
    {
       public string userName;
       public int startAge;
       public decimal startMoney;
        public Character(string name, int userCharClass)
        {
            SetName(name);
            SetCharacterClass(userCharClass);
        }
        
        public void SetName(string name)
        {
            userName = name;
           
        }
        

        public void SetCharacterClass(int userCharClass)
        {
          
            switch (userCharClass)
            {
                case 1:
                    startAge = 18;
                    startMoney = 100;
                    break;
                case 2:
                    startAge = 22;
                    startMoney = 200;
                    break;
                case 3:
                    startAge = 26;
                    startMoney = 300;
                    break;
                    
            }
        }
        

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Character
    {
        Ship ship = new Ship();

       public string userName;
       public int startAge;
       public decimal startMoney;
       public double fuelFactor;
        public double currentfuelLevel; 
       public double capacity;
        public double velocity;
        public Character(string name, int userCharClass)
        {
            SetName(name);
            SetCharacterClass(userCharClass);
            ShipSpecs();
           
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
                    currentfuelLevel = 1000;
                    break;
                case 2:
                    startAge = 22;
                    startMoney = 200;
                    currentfuelLevel = 2000;
                    break;
                case 3:
                    startAge = 26;
                    startMoney = 300;
                    currentfuelLevel = 3000;
                    break;
                    
            }
        }

        public void ShipSpecs()
        {
            ship.ShipType(startAge);
            fuelFactor = ship.fuelModify;
            capacity = ship.loadCapacity;
            velocity = ship.velocity;
        }
        
        public void FuelAfterTravel(double expandedFuel)
        {
            currentfuelLevel -= expandedFuel;
        }

    }
}

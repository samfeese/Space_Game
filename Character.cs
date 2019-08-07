using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Character
    {
        Ship ship = new Ship();

       public string userName;
       public int currentAge;
       public static decimal currentMoney;
       public double fuelFactor;
        public static double currentfuelLevel; 
       public double capacity;
        public double velocity;
        public static double currentDebt = 5000000;

        public Character(string name, int userCharClass )
        {
            SetName(name);
            SetCharacterClass(userCharClass);

        }

        public void SetName(string name) => userName = name;


        public void SetCharacterClass(int userCharClass)
        {
          
            switch (userCharClass)
            {
                case 1:
                    currentAge = 18;
                    currentMoney = 100;
                    currentfuelLevel = 1000;
                    break;
                case 2:
                    currentAge = 22;
                    currentMoney = 200;
                    currentfuelLevel = 2000;
                    break;
                case 3:
                    currentAge = 26;
                    currentMoney = 300;
                    currentfuelLevel = 3000;
                    break;
                    
            }
        }

        public void ShipSpecs(double warpFactor)
        {
            ship.ShipType(currentAge);
            fuelFactor = ship.fuelModify;
           
            velocity = ship.velocity;
        }

        public void FuelAfterTravel(double expandedFuel) => currentfuelLevel -= expandedFuel;

        public void FuelAterPurchase(double fuelQuantity) => currentfuelLevel += fuelQuantity;

        public static void Profit(decimal bill) => currentMoney += bill;

        public void Expenses(decimal bill) => currentMoney -= bill;

        public void Aging(int traveltime) => currentAge += traveltime;

        public void PlayerStats()
        {
            Console.WriteLine($"You are {currentAge} years old ");
            Console.WriteLine($"You currently have a fortune of ${currentMoney}");
            Console.WriteLine($"Your fuel level is {currentfuelLevel}");
        }
    }
}

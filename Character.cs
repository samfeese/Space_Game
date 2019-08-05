﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Character
    {
        Ship ship = new Ship();

       public string userName;
       public int currentAge;
       public decimal currentMoney;
       public double fuelFactor;
        public double currentfuelLevel; 
       public double capacity;
        public double velocity;
        

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
            ship.Speed(warpFactor, ship.speedModify);
            fuelFactor = ship.fuelModify;
            capacity = ship.loadCapacity;
            velocity = ship.velocity;
        }

        public void FuelAfterTravel(double expandedFuel) => currentfuelLevel -= expandedFuel;

        public void Profit(decimal profit) => currentMoney += profit;

        public void Expenses(decimal bill) => currentMoney -= bill;

        public void Aging(int traveltime) => currentAge += traveltime;

        public void WinOrLose()
        {
           if (currentAge > 60)
            {
                Console.WriteLine("YOU REACHED 60 AND DID NOT PAY YOUR DEBTS");
                Environment.Exit(0);
            }
           else if (currentMoney < 0)
            {
                Console.WriteLine("YOU ARE OUT OF MONEY");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("You survived another turn");
            }
    }
}

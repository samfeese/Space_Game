using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Ship
    {
      
        public double velocity;
        public double loadCapacity;
        public double fuelCost;


        double speedModify;
        double loadModify;
        double fuelConsomption;
       
        public void ShipType(int age)
        {
           
            switch (age)
            {
                case 18:
                    speedModify = 1.1;
                    loadModify = 1.1;
                    fuelConsomption = 1;
                    break;
                case 22:
                    speedModify = 1.5;
                    loadModify = 1.5;
                    fuelConsomption = 0.75;
                    break;
                case 26:
                    speedModify = 1.9;
                    loadModify = 1.9;
                    fuelConsomption = 0.5;
                    break;
            }
        }

        public void Speed(int warpFactor)
        {
            double baseVelocity = Math.Pow(warpFactor, (10 / 3)) + Math.Pow((10 - warpFactor), (-11 / 3));
            velocity = speedModify * baseVelocity;
        }
        public void Capacity()
        {
            const double baseLoad = 100;
            loadCapacity = loadModify * baseLoad;
        }

        public void Fuel (double distance)
        {
            fuelCost = distance * fuelConsomption;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Ship
    {
      
        public double velocity;
        public double loadCapacity;
        public double fuelConsumption;
        
        public double speedModify;
        public double loadModify;
        public double fuelModify;
       
        public void ShipType(int age)
        {
           
            switch (age)
            {
                case 18:
                    speedModify = 1.1;
                    loadModify = 1.1;
                    fuelModify = 1;
                    break;
                case 22:
                    speedModify = 1.5;
                    loadModify = 1.5;
                    fuelModify = 0.75;
                    break;
                case 26:
                    speedModify = 1.9;
                    loadModify = 1.9;
                    fuelModify = 0.5;
                    break;
            }
        }

        public void Speed(double warpFactor)
        {
            double baseVelocity = Math.Pow(warpFactor, (10 / 3)) + Math.Pow((10 - warpFactor), (-11 / 3));
            velocity = baseVelocity;// * speedModify;
        }

        public void FuelConsumption()
        {
            var baseFuel = 5;
            fuelConsumption = baseFuel * fuelModify;

        }
        public void Capacity()
        {
            const double baseLoad = 100;
            loadCapacity = baseLoad * loadModify;
        }


        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Ship
    {
        public double ShipType(int age)
        {
            double speedModify = 0;
            switch (age)
            {
                case 18:
                    speedModify = 1.1;
                    break;
                case 22:
                    speedModify = 1.5;
                    break;
                case 26:
                    speedModify = 1.9;
                    break;


            }
            return speedModify;
        }




        public double Speed(double speedModify)
        {
            int w;

            double velocity;
            double warpFactor;
            warpFactor = speedModify * 

        }

        Capacity()





    }
}

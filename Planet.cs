using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Planet
    {
        public (double, double) PlanetEarth()
        {
           double x = 0;
           double y = 0;
            return (x, y);
        }

        public (double, double) PlanetAplha()
        {
            Random alphaAngle = new Random();
            double randomAngle = alphaAngle.Next(0, 359);

            double x = PlanetEarth().Item1 + (Math.Cos(randomAngle) * 4.3);
            double y = PlanetEarth().Item1 + (Math.Sin(randomAngle) * 4.3);
            return (x, y);
        }



    }
}

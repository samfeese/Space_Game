using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Planet
    {

        public string planetName;
        public (double, double) planetCoordinate;
        public (double, double) planetAlpha;
        public Planet()
        {
            //PlanetEarth();
            PlanetAplha();
            PlanetNameGenerator();
            PlanetCoordinateGenerator();
        }
        
    
        public (double, double) PlanetEarth()
        {
           double x = 0;
           double y = 0;
           return (x, y);
        }

        public void PlanetAplha()
        {
            Random alphaAngle = new Random();
            double randomAngle = alphaAngle.Next(0, 359);


            double x = PlanetEarth().Item1 + (Math.Cos(randomAngle) * 4.3);
            double y = PlanetEarth().Item2 + (Math.Sin(randomAngle) * 4.3);
            planetAlpha = (x, y);
        }

        public void PlanetNameGenerator()
        {
            List<string> firstName = new List<string> {"a", "b", "c", "d", "e"};
            List<string> lastName = new List<string> {"z", "y", "x", "w", "v"};

            Random value = new Random();
            int name1 = value.Next(0, 4);
            int name2 = value.Next(0, 4);
            string tempFirst = firstName[name1];
            string tempLast = lastName[name2];

            planetName = tempFirst + " " + tempLast;
           
            
        }
        public void PlanetCoordinateGenerator()
        {
            Random value = new Random();

            double x = value.Next(0, 10) + value.NextDouble();

            double y = value.Next(0, 10) + value.NextDouble();

            planetCoordinate = (x, y);
            

        }


        public double Distance((double, double) x, (double, double) y)
        {
            double deltaX = y.Item1 - x.Item1;
            double deltaY = y.Item2 - x.Item2;

            double z = Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2);

            double distance = Math.Sqrt(z);
            return distance;

        }
        

    }
}

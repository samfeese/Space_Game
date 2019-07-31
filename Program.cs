using System;
using System.Threading;

namespace Space_Game
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
            ShipArt display = new ShipArt();
            Dialog talk = new Dialog();
            Planet coordinates = new Planet();

            display.ShipArtVertical();
            Thread.Sleep(1000);
            Console.Clear();

            display.ShipArtHorz();

            double earthX = coordinates.PlanetEarth().Item1;
            double earthY = coordinates.PlanetEarth().Item2;
            Console.WriteLine($"Earth's Coordinates are ({earthX}, {earthY})");

            double alphaX = coordinates.PlanetAplha().Item1;
            double alphaY = coordinates.PlanetAplha().Item2;
            Console.WriteLine($"Alpha's Coordinates are ({alphaX}, {alphaY})");





        }

    

    }
}

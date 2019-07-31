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

            //display.ShipArtVertical();
            //Thread.Sleep(1000);
            //Console.Clear();

            //display.ShipArtHorz();
            talk.StartGameDialog();
            
            (double, double) p = coordinates.PlanetAplha();
            double alphaX = p.Item1;
            double alphaY = p.Item2;


            Console.WriteLine($"Alpha's Coordinates are ({alphaX}, {alphaY})");

           




        }

    

    }
}

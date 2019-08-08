using System;
using System.Threading;
using System.Collections.Generic;
namespace Space_Game
{
    class Program
    {
        UserInterface ui = new UserInterface();
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface();
            ShipArt display = new ShipArt();
       

            display.ShipArtVertical();
            Thread.Sleep(1000);
            Console.Clear();
            ui.UIstart();

       

          


        }
    }
}
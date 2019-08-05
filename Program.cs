using System;
using System.Threading;
using System.Collections.Generic;
namespace Space_Game
{
    class Program
    {

        static void Main(string[] args)
        {

            //ShipArt display = new ShipArt();
            Dialog talk = new Dialog();

            Inventory.InventoryArt();
            //display.ShipArtVertical();
            //Thread.Sleep(1000);
            //Console.Clear();

            //talk.StartGameDialog();

            talk.StartMove();

            
        }
    }  
}

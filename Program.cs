using System;
using System.Threading;
using System.Collections.Generic;
namespace Space_Game
{
    class Program
    {

        static void Main(string[] args)
        {

            ShipArt display = new ShipArt();
            Dialog talk = new Dialog();

            //            Blackjack game = new Blackjack();
            //            Blackjack.Deck deck = new Blackjack.Deck();
            //            //display.ShipArtVertical();
            //            //Thread.Sleep(1000);
            //            //Console.Clear();

            //            //talk.StartGameDialog();

            //            //talk.StartMove();



            //=======


            display.ShipArtVertical();
            Thread.Sleep(1000);
            Console.Clear();


            // Inventory.InventoryArt();
            //display.ShipArtVertical();
            //Thread.Sleep(1000);
            //Console.Clear();


            // talk.StartGameDialog();

            talk.StartGameDialog();

        }
    }
}
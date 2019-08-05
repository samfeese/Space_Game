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
<<<<<<< HEAD
//<<<<<<< HEAD
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
=======

            Inventory.InventoryArt();
            //display.ShipArtVertical();
            //Thread.Sleep(1000);
            //Console.Clear();
>>>>>>> 287fb2f5461eb03d4f05f70cf241d44d0d83e4de

            // talk.StartGameDialog();

            talk.StartGameDialog();

<<<<<<< HEAD




//>>>>>>> 16c2f669e7b686b70f07bbfd25e3263c4a8af771





//<<<<<<< HEAD
//=======

//>>>>>>> 16c2f669e7b686b70f07bbfd25e3263c4a8af771

=======
            
>>>>>>> 287fb2f5461eb03d4f05f70cf241d44d0d83e4de
        }
    }  
}

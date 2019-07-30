using System;

namespace Space_Game
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
            ShipArt display = new ShipArt();
            Dialog talk = new Dialog();

            display.ShipArtVertical();

          
            talk.StartGameDialog();



        }

    

    }
}

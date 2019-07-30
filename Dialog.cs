using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Dialog
    {

        UserInterface ui = new UserInterface();
        public void StartGameDialog()
        {
            ui.UIstart();

            Console.WriteLine();
            Console.WriteLine("*BANG* *BANG* *BANG*");
            Console.WriteLine("You awake to three loud knocks at your space door.");

            Console.WriteLine($"\n\nHEY {ui.name}");



          

        }
    }
}

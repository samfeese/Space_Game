using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Space_Game
{
    static class Dialog
    {

     
        public static void StartGameDialog()
        {
            UserInterface ui = new UserInterface();

            


            Console.WriteLine();

            Console.WriteLine("*BANG* *BANG* *BANG*");
            Thread.Sleep(2000);

            Console.WriteLine("You awake to three loud knocks at your space door.");
            Thread.Sleep(2000);

            Console.WriteLine($"\n\nHEY! We know your in there open up!");
            Thread.Sleep(2000);

            Console.WriteLine("You look at the clock and its 34:22:35 space standard time");
            Thread.Sleep(2000);

            Console.Write("Get up and open the door? or Stay in bed?");

            Console.Write("   F1: Get up.   F2: Ignore them.");

            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.F1:
                    Console.WriteLine("\nYou get up and drag yourself towards the door.");
                    Thread.Sleep(2000);
                    Console.WriteLine("\nBefore you can get to the door the hinges are blown off and the door falls into your home.");
                    break;
                case ConsoleKey.F2:
                    Console.WriteLine("\nYou turn over and hope that they leave, you are recovering from a night of hard drinking and dont want to deal with anyone today.");
                    Thread.Sleep(2000);
                    Console.WriteLine("\nAs you drift off you hear a loud boom and before you can turn towards the door a figure, incased in smoke, intrudes in your home.");
                    break;
            }

            Console.WriteLine("\nBefore you stands a humanoid figure that is shining like a freshly polished bowling ball. \n'Listen here kid, my gears are too old for me to be waiting outside in the rain.'\n'I was starting to rust' the person talking is not a person at all, but a late model robot that looks like it has seen better days.");
            Thread.Sleep(3000);
            Console.WriteLine("\n'I'm here to deliver a message from the big boss, ya' got it?' \nAs you look at him, or it rather, in confusion it notices you dont understand.");
            Thread.Sleep(3000);
            Console.WriteLine("\n'What you've never seen a rusty ole' robot before?' it says as it clatters towards you \n'We are the Space Robot Mafia, your pops owes us money. A lot of money.'");
            Thread.Sleep(3000);
            Console.WriteLine("\n'When i say alot of money, i mean enough that it will probably never be paid off. \nAnd luckey for you, word is your good for nothing daddy has perished in space.'");
            Thread.Sleep(3000);
            Console.WriteLine("\n'So, YOU now owe us the money. As long as we robots stay operatonal, we are not as patient. \nIf you hit the age of 60 before you pay us off, your done. Over. Kaput. Capishe?'");
            Thread.Sleep(3000);
            Console.WriteLine("\nSo here is your first job: here is 50 Skooma, they love this stuff in space. Go trade it somewhere and pay us back!");


        }






    }
}

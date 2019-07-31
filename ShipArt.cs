using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace Space_Game
{
    class ShipArt
    {

        public void ShipArtVertical()
        {
            Console.Write("       ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("      ");
            Console.WriteLine();

            Console.Write("      ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            Console.WriteLine();

            Console.Write("     ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            Console.WriteLine();

            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            Console.WriteLine();

            Console.Write("     ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("     ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("   ");
            Console.WriteLine();

            
            Console.Write("      ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            Console.WriteLine();

        }
        public void ShipArtHorz()
        {
            int i = 0;
            string add = "  ";
            string a = "    ";
            string b = "   ";
            string c = "  ";
            string d = "___  ___  ___  ";
            string e = " __ __  __   __";
            string f = "_  _  _     _";
            string addLine = "__";
            


            while (i < 25)
            {

                if (i % 2 != 0)
                {

                    Console.WriteLine();
                    Console.WriteLine();

                  
                }
                

                    Console.Write(a);

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("  ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("    ");
                    Console.Write(d);
                    Console.WriteLine();

                    Console.Write(b);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("     ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("   ");
                    Console.Write(f);
                    Console.WriteLine();

                    Console.Write(c);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("  ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("        ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("  ");
                    Console.Write(e);
                    Console.WriteLine();

                    Console.Write(a);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("           ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("   ");
                    Console.Write(d);
                    Console.WriteLine();

                    Console.Write(c);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("  ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("        ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("  ");
                    Console.Write(f);
                    Console.WriteLine();

                    Console.Write(b);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("     ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("   ");
                    Console.Write(d);
                    Console.WriteLine();

                    Console.Write(a);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("  ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("    ");
                    Console.Write(f);
                    Console.WriteLine();

                    Thread.Sleep(500);
                    Console.Clear();
               
                i++;
                a += add;
                b += add;
                c += add;
              
            }
        }

        //public void ShipArtHorz2()
        //{
        //    Console.Write("      ");
        //    Console.BackgroundColor = ConsoleColor.White;
        //    Console.Write("  ");
        //    Console.BackgroundColor = ConsoleColor.Black;
        //    Console.Write("    ");
        //    Console.WriteLine();

        //    Console.Write("     ");
        //    Console.BackgroundColor = ConsoleColor.White;
        //    Console.Write("     ");
        //    Console.BackgroundColor = ConsoleColor.Black;
        //    Console.Write("   ");
        //    Console.WriteLine();

        //    Console.Write("    ");
        //    Console.BackgroundColor = ConsoleColor.Red;
        //    Console.Write("  ");
        //    Console.BackgroundColor = ConsoleColor.White;
        //    Console.Write("        ");
        //    Console.BackgroundColor = ConsoleColor.Black;
        //    Console.Write("  ");
        //    Console.WriteLine();

        //    Console.Write("      ");
        //    Console.BackgroundColor = ConsoleColor.White;
        //    Console.Write("           ");
        //    Console.BackgroundColor = ConsoleColor.Black;
        //    Console.Write("   ");
        //    Console.WriteLine();

        //    Console.Write("    ");
        //    Console.BackgroundColor = ConsoleColor.Red;
        //    Console.Write("  ");
        //    Console.BackgroundColor = ConsoleColor.White;
        //    Console.Write("        ");
        //    Console.BackgroundColor = ConsoleColor.Black;
        //    Console.Write("  ");
        //    Console.WriteLine();

        //    Console.Write("     ");
        //    Console.BackgroundColor = ConsoleColor.White;
        //    Console.Write("     ");
        //    Console.BackgroundColor = ConsoleColor.Black;
        //    Console.Write("   ");
        //    Console.WriteLine();

        //    Console.Write("      ");
        //    Console.BackgroundColor = ConsoleColor.White;
        //    Console.Write("  ");
        //    Console.BackgroundColor = ConsoleColor.Black;
        //    Console.Write("    ");
        //    Console.WriteLine();
        //}
        //    public void ShipArtHorz3()
        //{
        //    Console.Write("        ");
        //    Console.BackgroundColor = ConsoleColor.White;
        //    Console.Write("  ");
        //    Console.BackgroundColor = ConsoleColor.Black;
        //    Console.Write("    ");
        //    Console.WriteLine();

        //    Console.Write("       ");
        //    Console.BackgroundColor = ConsoleColor.White;
        //    Console.Write("     ");
        //    Console.BackgroundColor = ConsoleColor.Black;
        //    Console.Write("   ");
        //    Console.WriteLine();

        //    Console.Write("      ");
        //    Console.BackgroundColor = ConsoleColor.Red;
        //    Console.Write("  ");
        //    Console.BackgroundColor = ConsoleColor.White;
        //    Console.Write("        ");
        //    Console.BackgroundColor = ConsoleColor.Black;
        //    Console.Write("  ");
        //    Console.WriteLine();

        //    Console.Write("        ");
        //    Console.BackgroundColor = ConsoleColor.White;
        //    Console.Write("           ");
        //    Console.BackgroundColor = ConsoleColor.Black;
        //    Console.Write("   ");
        //    Console.WriteLine();

        //    Console.Write("      ");
        //    Console.BackgroundColor = ConsoleColor.Red;
        //    Console.Write("  ");
        //    Console.BackgroundColor = ConsoleColor.White;
        //    Console.Write("        ");
        //    Console.BackgroundColor = ConsoleColor.Black;
        //    Console.Write("  ");
        //    Console.WriteLine();

        //    Console.Write("       ");
        //    Console.BackgroundColor = ConsoleColor.White;
        //    Console.Write("     ");
        //    Console.BackgroundColor = ConsoleColor.Black;
        //    Console.Write("   ");
        //    Console.WriteLine();

        //    Console.Write("        ");
        //    Console.BackgroundColor = ConsoleColor.White;
        //    Console.Write("  ");
        //    Console.BackgroundColor = ConsoleColor.Black;
        //    Console.Write("    ");
        //    Console.WriteLine();
        //}

        //    public void ShipArtHorz4() { }

        //    public void ShipArtHorz5() { }

        //    public void ShipArtHorz6() { }

        //    public void ShipArtHorz7() { 
            


        
    }
}

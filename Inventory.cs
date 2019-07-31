using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    

    class Inventory
    {
        public (string, int) skooma; //= ("Skooma", 0);
        public (string, int) lulu = ("Lulu", 0);
        public (string, int) brams = ("Brams", 0);
        public (string, int) targens = ("Targens", 0);
        public (string, int) dryer = ("Dryer Lint", 0);

        public void ItemA(int change, (string, int) thing)
        {
            thing.Item1 = "Skooma";
            int i = 0;
            i += change;
            skooma.Item2 = i;
                       
        }

       



    }
}

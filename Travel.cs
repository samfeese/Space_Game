using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Travel
    {
        public void RandomEvent()
        {
            Random spaceEvent = new Random();

            int action = spaceEvent.Next(1, 10);

            int thing = action % 2;
            if (thing == 1)
            {
                //normal Travel
            }
            else if(thing == 0 && action != 10)
            {
                //space pirates
            }
            else if (action == 10)
            {
                //free money
                //normal travel
            }


        }

        
    }
}

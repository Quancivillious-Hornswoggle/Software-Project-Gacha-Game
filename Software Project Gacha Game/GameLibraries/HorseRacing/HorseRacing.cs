using Software_Project_Gacha_Game.GameLibraries.HorseRacing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class HorseRacing
    {
        Horse horse1 = new Horse();

        /***
         * GENERAL IDEA FOR HOW HORSE RACING WILL GO:
         * Each horse has a speed/odds (MAX 0.75 odds, TBD speed)
         * Each "tick" (based on horse's speed), roll a random double
         * If double is larger than odds, move forward
         * More interesting than all moving at once, no guaranteed wins
         */
    }
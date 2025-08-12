using Software_Project_Gacha_Game.GameLibraries.HorseRacing;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class HorseRacing
    {
    public static List<Horse> horses = new List<Horse>();
    public static void setUpRace()
    {
        horses.Clear();
        for (int i = 0; i < 5; i++)
        {
            horses.Add(new Horse());
            Debug.WriteLine("Name: " + horses[i].getName());
            Debug.WriteLine("Speed: " + horses[i].getSpeed());
            Debug.WriteLine("Move Chance: " + horses[i].getMoveChance());
            Debug.WriteLine("Odds: " + horses[i].getOdds());
        }
    }

        /***
         * GENERAL IDEA FOR HOW HORSE RACING WILL GO:
         * Each horse has a speed/odds (MAX 0.75 odds, TBD speed)
         * Each "tick" (based on horse's speed), roll a random double
         * If double is larger than odds, move forward
         * More interesting than all moving at once, no guaranteed wins
         * Global timer, if timer % speed = 0, horse has a chance to move
         */
    }
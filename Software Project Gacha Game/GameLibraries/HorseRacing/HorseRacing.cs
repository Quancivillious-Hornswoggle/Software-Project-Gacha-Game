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
        public static List<Horse> setUpRace()
        {
            horses.Clear();
            for (int i = 0; i < 2; i++)
            {
                horses.Add(new Horse());
            }
            return horses;
        }

        public static void startRace()
        {
            Stopwatch timer = new Stopwatch();
            bool raceOver = false;
            timer.Start();
            while (!raceOver)
            {
                foreach (Horse h in horses)
                {
                    if ((timer.ElapsedMilliseconds % h.getSpeed() == 0) && h.movementOpportunity())
                    {
                        // Horse successfully moved
                        // Update UI here/check if race is over or something?
                        // Code here right now is temporary debug code
                        Debug.WriteLine(h.getName() + " Successfully moved!");
                        raceOver = true;
                }
                }
            }
        }

        /***
         * GENERAL IDEA FOR HOW HORSE RACING WILL GO:
         * Each horse has a speed/move chance
         * Timer keeps track of race time, if ms elapsed is a multiple of horse's speed, has a chance to move
         * Random double is generated, then compared to move chance
         * If random < chance, horse moves
         * TBD how to track each horse's progress/who wins?
         */
    }
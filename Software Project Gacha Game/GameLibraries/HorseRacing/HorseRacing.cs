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
            for (int i = 0; i < 5; i++)
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
                        // TODO - Somehow show movement on UI
                        Debug.WriteLine(h.getName() + " Successfully moved!");
                        raceOver = h.hasWon();
                        if (raceOver)
                        {
                            Debug.WriteLine(h.getName() + " has won!");
                            break;
                            // TODO - Update UI for the winner
                        }
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
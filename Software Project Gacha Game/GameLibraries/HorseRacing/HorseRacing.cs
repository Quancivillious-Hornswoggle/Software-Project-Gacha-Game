using Software_Project_Gacha_Game.GameLibraries.HorseRacing;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    class HorseRacing
    {
    public static String betOnHorse = "";
    public static float betAmount;

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

        public static void makeBet(String horseName, float wager)
        {
            betOnHorse = horseName;
            betAmount = wager;
        }

        public static float startRace(PictureBox[] HorseIcons, Label winnerLabel)
        {
            Horse winner = new Horse();
            Stopwatch timer = new Stopwatch();
            bool raceOver = false;
            timer.Start();

            int index = 0;
            while (!raceOver)
            {
                foreach (Horse h in horses)
                {
                    if ((timer.ElapsedMilliseconds % h.getSpeed() == 0) && h.movementOpportunity())
                    {
                    // Horse successfully moved
                    // TODO - Somehow show movement on UI
                    HorseIcons[index].Location = new Point(HorseIcons[index].Location.X + 75, HorseIcons[index].Location.Y);
                    HorseIcons[index].Refresh();

                    Debug.WriteLine(h.getName() + " Successfully moved!");
                    raceOver = h.hasWon();
                    if (raceOver)
                    {
                            winner = h;
                            Debug.WriteLine(h.getName() + " has won!");
                            timer.Stop();
                            // Update corner winner label
                            winnerLabel.Text = (h.getName() + " has won!");
                        break;
                    }
                    }
                    index++;
                }
                index = 0;
            }
            Debug.WriteLine(winner.getOdds());
            if (winner.getName().Equals(betOnHorse)) { return (float)((1 - (winner.getOdds() / 100)) * betAmount); }
            return 0f;
            // Do they get nothing if they don't win? or less based on placement?
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
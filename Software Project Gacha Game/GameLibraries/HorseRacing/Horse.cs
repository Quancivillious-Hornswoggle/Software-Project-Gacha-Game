using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Project_Gacha_Game.GameLibraries.HorseRacing
{
    internal class Horse
    {
        private Random rand = new Random();
        private string name;
        private readonly string[] firstNames = { "Jovial", "Superstitional", "Downtown", "Door", "Garbage", "Gold", "Grass" };
        private readonly string[] lastNames = { "Merryment", "Realism", "Skybox", "Knob", "Bin", "Ship", "Wonder" };

        // How many ms it takes for a horse to get the chance to move
        // 1.0 - 1.5 seconds
        private int speed;
        private const int minSpeed = 2000;
        private const int maxSpeed = 3500;

        private float moveChance;
        private const float minMoveChance = 0.25f;
        private const float maxMoveChance = 0.50f;

        // Purely UI related, can help user determine which horse to bet on
        private float odds;

        // In order to determine the winner/how far each horse has gone
        private int progress;
        private int raceLength = 15;


        /***
         * Instantiates a new Horse
         * Generates a random name, speed value, move chance, then odds based off those values
         */
        public Horse()
        {
            setName();
            setSpeed();
            setMoveChance();
            setOdds();
            setProgress(0);
        }

        #region Getters/Setters
        public string getName()
        {
            return this.name;
        }

        private void setName()
        {
            int index = rand.Next(firstNames.Length);
            String first = firstNames[index];
            index = rand.Next(lastNames.Length);
            this.name = first + " " + lastNames[index];
        }

        // Should only be accessed by HorseRacing.cs
        // UI Should only show odds
        internal int getSpeed()
        {
            return this.speed;
        }

        private void setSpeed()
        {
            this.speed = rand.Next(minSpeed, (maxSpeed + 1));
        }

        internal float getMoveChance()
        {
            return this.moveChance;
        }

        private void setMoveChance()
        {
            this.moveChance = (float)(minMoveChance + (rand.NextDouble() * (maxMoveChance - minMoveChance)));
        }

        public float getOdds()
        {
            return this.odds;
        }

        private void setOdds()
        {
            double c1 = getMoveChance() / maxMoveChance;
            double c2 = (double)getSpeed() / maxSpeed;
            c1 = c1 * c2 * 100;
            c1 = Math.Floor(c1) - 5;
            if (c1 <= 1) { c1 = 1; }
            this.odds = (float)c1;
        }

        private int getProgress()
        {
            return this.progress;
        }

        private void setProgress(int progress)
        {
            this.progress = progress;
        }
        #endregion

        public Boolean movementOpportunity()
        {
            return (rand.NextDouble() <= getMoveChance());
        }

        public Boolean hasWon()
        {
            setProgress(getProgress() + 1);
            return (getProgress() >= raceLength);
        }
    }
}

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

        // TODO - Change min and max when known
        // How many seconds it takes to get a chance to move
        private double speed;
        private const double minSpeed = 0.25;
        private const double maxSpeed = 0.75;

        private double moveChance;
        private const double minMoveChance = 0.25;
        private const double maxMoveChance = 0.75;

        // Purely UI related, can help user determine which horse to bet on
        private float odds;

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
        internal double getSpeed()
        {
            return this.speed;
        }

        private void setSpeed()
        {
            this.speed = (minSpeed + (rand.NextDouble() * (maxSpeed - minSpeed)));
        }

        internal double getMoveChance()
        {
            return this.moveChance;
        }

        private void setMoveChance()
        {
            this.moveChance = (minMoveChance + (rand.NextDouble() * (maxMoveChance - minMoveChance)));
        }

        public float getOdds()
        {
            return this.odds;
        }

        private void setOdds()
        {
            double c1 = getMoveChance() / maxMoveChance;
            double c2 = getSpeed() / maxSpeed;
            c1 = c1 * c2 * 100;
            c1 = Math.Floor(c1);
            this.odds = (float)c1 - 5;
            // TODO - Generate odds based off the speed and move chance, then set it here
        }
        #endregion

        // More Stuff Here?
        // Boolean Method - see if they can move that "tick"?
        // Who keeps track of timer? Horse or Controller?
    }
}

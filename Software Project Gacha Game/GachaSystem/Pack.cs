using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Project_Gacha_Game.GachaSystem
{
    public class Pack
    {
        public RewardData.Pool Reward { get; private set; }

        public Pack() {
            Reward = GetRewardItem();
        }

        public RewardData.Pool GetReward() { return Reward; }

        private RewardData.Pool GetRewardItem()
        {
            // Get all Pool enum values
            var items = Enum.GetValues(typeof(RewardData.Pool)).Cast<RewardData.Pool>();

            // Calculate total weight by mapping Pool item to Chances enum value
            int totalWeight = items.Sum(item => (int)Enum.Parse(typeof(RewardData.Chances), item.ToString()));

            Random rng = new Random();
            int roll = rng.Next(1, totalWeight + 1);

            int cumulative = 0;
            foreach (var item in items)
            {
                cumulative += (int)Enum.Parse(typeof(RewardData.Chances), item.ToString());
                if (roll <= cumulative)
                {
                    return item;
                }
            }

            // Fallback (should never happen)
            return RewardData.Pool.Sticker_Pack;
        } 
    }
}

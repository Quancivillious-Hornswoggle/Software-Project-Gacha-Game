namespace Software_Project_Gacha_Game.GachaSystem
{
    public class RewardData
    {
        public enum Pool
        {
            Sticker_Pack,
            Wallpaper,
            Ringtone,
            Animated_Avatar,
            Miku_Voice_Greeting
        }

        public enum Chances : int
        {
            Sticker_Pack = 50,
            Wallpaper = 25,
            Ringtone = 15,
            Animated_Avatar = 8,
            Miku_Voice_Greeting = 2
        }
    }
}

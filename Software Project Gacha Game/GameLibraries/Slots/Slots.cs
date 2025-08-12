using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Slots
{
    // Game Variables
    private string[] symbols = ["💣", "🍒", "💎", "🍀", "🍉", "🍓", "🍋", "🍊", "🔔", "💰"];
    private string slot1 = string.Empty;
    private string slot2 = string.Empty;
    private string slot3 = string.Empty;

    // Data Variables
    private Random rng = new Random();

    // Public getters
    // Getter so UI can access all ui symbols for displaying
    public string[] GetSlotSymbols() { return symbols.ToArray();  }

    // Getter for all slots to display final determined slot
    public string GetSlot1() {  return slot1; }
    public string GetSlot2() { return slot2; }
    public string GetSlot3() { return slot3; }

    // Returns array of 3 symbols also sets symbol variables
    public string[] RunGame()
    {
        slot1 = symbols[rng.Next(symbols.Length)];
        slot2 = symbols[rng.Next(symbols.Length)];
        slot3 = symbols[rng.Next(symbols.Length)];

        return new string[] { slot1, slot2, slot3 };
    }
}

using System;
using System.Collections.Generic;

namespace Dice
{
    class Program
    {
        public static void Main(string[] argv)
        {
            // You have a `DiceSet` class which has a list for 6 dice
            // You can roll all of them with roll()
            // Check the current rolled numbers with getCurrent()
            // You can reroll with reroll()
            // Your task is to roll the dice until all of the dice are 6

            // Create dice set
            // Roll Dices 
            // Show Dices to check
            // Reroll to get all 6
            // Show Dices again

            DiceSet diceSet = new DiceSet();
            diceSet.RollAll();
            diceSet.ShowAll();
            diceSet.RerollAllNon6(); // RerollAll();
            diceSet.ShowAll();
        }
    }
}
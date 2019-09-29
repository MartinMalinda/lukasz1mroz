using System;

namespace Dice
{
    public class DiceSet
    {
        private Random randomValue = new Random();
        private int[] dice = new int[6];

        public int[] RollAll()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = randomValue.Next(1, 7);
            }
            return dice;
        }

        public void ShowAll ()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                Console.Write(dice[i] + " ");
            }
            Console.WriteLine();
        }

        public void RerollAllNon6()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                while (dice[i] != 6)
                {
                    Reroll(i);
                }
            }
        } 
    }
}
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

        // Unnessesary method ?
        public int[] GetCurrent()
        {
            return dice;
        }

        // Unnessesary method ?
        public int GetCurrent(int i)
        {
            return dice[i];
        }

        public void ShowAll ()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                Console.Write(dice[i] + " ");
            }
            Console.WriteLine();
        }

        // Unnessesary method ?
        public void Reroll()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = randomValue.Next(1, 7);
            }
        }

        // Unnessesary method ?
        public void Reroll(int k)
        {
            dice[k] = new Random().Next(1, 7);
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
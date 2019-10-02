using System;
using System.Collections.Generic;
using System.Text;

namespace Comparable
{
    public class Domino : IComparable<Domino>
    {

        // List for storing domino values
        private readonly int[] values;

        // Domino constructor
        public Domino(int valueA, int valueB)
        {
            this.values = new int[] { valueA, valueB };
        }

        // Getting dominovalues
        public int[] GetValues()
        {
            return values;
        }

        // Comparing dominos
        public int CompareTo(Domino other)
        {
            return this.values[0].CompareTo(other.values[0]);
        }
    }
}
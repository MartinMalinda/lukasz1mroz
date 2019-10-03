using System;
using System.Collections.Generic;
using System.Text;

namespace Sum
{
    public class Summary
    {
        public int SumInts(List<int> integers)
        {
            int total = 0;

            foreach (var item in integers)
            {
                total += item;
            }

            return total;
        }
        public int? SumAll(List<int?> numbersToSum)
        {
            int? sum = null;
            return sum;
        }
    }
}

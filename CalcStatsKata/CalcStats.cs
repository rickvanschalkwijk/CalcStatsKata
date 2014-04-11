using System.Collections.Generic;
using System.Linq;

namespace CalcStatsKata
{
    public class CalcStats
    {
        public CalcStats()
        {
        }

        public int FindMin(List<int> ints)
        {
            return ints.OrderBy(x => x).First();
        }

        public int FindMax(List<int> ints)
        {
            return ints.OrderBy(x => x).Last();
        }

        public int GetLength(List<int> ints)
        {
            return ints.Count;
        }

        public int GetAverage(List<int> ints)
        {
            int sum = ints.Sum();
            return sum / GetLength(ints);
        }
    }
}
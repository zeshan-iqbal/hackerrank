using System.Linq;
//https://www.hackerrank.com/challenges/30-scope/problem?h_r=next-challenge&h_v=zen

namespace Day9_Recursion
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] elements)
        {
            this.elements = elements;
        }

        public void computeDifference()
        {
            var sorted = elements.OrderByDescending(i => i);
            maximumDifference = (sorted.First() - sorted.Last());
        }
    }
}
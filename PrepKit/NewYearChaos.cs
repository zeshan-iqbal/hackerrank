using System;

namespace PrepKit
{
    //https://www.hackerrank.com/challenges/new-year-chaos/problem
    public class NewYearChaos
    {
        // Complete the minimumBribes function below.
        public void minimumBribes(int[] q)
        {
            //{1, 2, 3, 4, 5}
            //{2, 1, 5, 3, 4}; //3
            //{2, 5, 1, 3, 4}; //chaotic
            int bribeCount = 0;

            for (int i = q.Length - 1; i >= 0; i--)
            {
                if (q[i] - (i + 1) > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }

                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                {
                    if (q[j] > q[i]) bribeCount++;
                }
            }

            Console.WriteLine(bribeCount);
        }

        public void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));

                minimumBribes(q);
            }
        }
    }
}
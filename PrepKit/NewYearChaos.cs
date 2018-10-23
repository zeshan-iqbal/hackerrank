using System;

namespace PrepKit
{
    //https://www.hackerrank.com/challenges/new-year-chaos/problem
    public class NewYearChaos
    {
        // Complete the minimumBribes function below.
        /*public void minimumBribes(int[] q)
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
        }*/

        public void minimumBribes(int[] q)
        {
            int bribeCount = 0;
            //(i=2)
            for (int i = q.Length - 1; i >= 0; i--)
            {
                // arrays are zero based thats why we are checking that q[i] != (i+1) otherwise we can check if q[i] != i
                //123  132 q[i] = 2, i+1 =3, (2!=3)
                if (q[i] == (i + 1)) continue;
                //check if its in position q[i-1] i.e Bribed once
                if ((i - 1) >= 0 && i+1 == q[i - 1])
                {
                    //i-1 >=0 is for checking array index bound.
                    bribeCount++;
                    q[i -1] = q[i];
                    q[i] = i + 1;
                }
                // check if its in position q[i-2] i.e. Bribed twice
                else if (i - 2 >= 0 && i+1 == q[i - 2])
                {
                    //i-2 >=0 is for checking array index bound.
                    bribeCount += 2;
                    q[i - 2] = q[i - 1];
                    q[i - 1] = q[i];
                    q[i] = i + 1;
                }
                // i.e. Bribed more than twice
                else
                {
                    Console.WriteLine("Too chaotic");
                    return;
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
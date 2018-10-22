using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace PrepKit
{
    //https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem
    public class ArrayLeftRotation
    {
        // Complete the rotLeft function below.
        public int[] rotLeft(int[] a, int d)
        {
            if (a.Length == d || a.Length == 1)
                return a;

            Queue<int> queue = new Queue<int>(a);
            for (int i = 0; i < d; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }

            return queue.ToArray();
        }

        public void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
                ;
            int[] result = rotLeft(a, d);

            textWriter.WriteLine(string.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
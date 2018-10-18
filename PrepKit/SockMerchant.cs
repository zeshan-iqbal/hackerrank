using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//https://www.hackerrank.com/challenges/sock-merchant/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
namespace PrepKit
{
    public class SockMerchant
    {
        // Complete the sockMerchant function below.
        public int ComputePairWithLinq(int n, int[] ar)
        {
            return ar.GroupBy(i => i)
                .Sum(g => g.Count() / 2);
        }

        public int ComputePair(int n, int[] ar)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            foreach (var i in ar)
            {
                if (pairs.ContainsKey(i))
                    pairs[i]++;
                else
                    pairs.Add(i, 1);
            }

            int totalpairs = 0;
            foreach (var pair in pairs)
            {
                totalpairs += pair.Value / 2;
            }

            return totalpairs;
        }

        public void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' ')
                    , arTemp => Convert.ToInt32(arTemp));
            int result = ComputePairWithLinq(n, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
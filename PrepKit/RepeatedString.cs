using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace PrepKit
{
    //https://www.hackerrank.com/challenges/repeated-string/problem
    public class RepeatedString
    {
        public long repeatedString(string s, long n)
        {
            long count = 0;
            count += s.Count(c => c == 'a');
            if (s.Length == 1)
                return count * n;
            

            long countInFirstNMultiples = count * (n / s.Length);
            int remainder = (int)(n % s.Length);
            int remainderCount = s.Substring(0, remainder).Count(c => c == 'a');
            return countInFirstNMultiples + remainderCount;

            //long remainder = n, count = 0;
            //int start = 0;

            //do
            //{
            //    int size = n <= int.MaxValue ? (int)remainder : int.MaxValue;
            //    string substring = s.Substring(start, size);
            //    count += substring.Count(c => c == 'a');
            //    start = size;
            //    remainder = remainder - size;
            //} while (remainder > 0);

            //return count;
        }

        public void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}

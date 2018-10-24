using System;
using System.IO;

namespace PrepKit
{
    //https://www.hackerrank.com/challenges/two-strings/problem
    public class TwoStrings
    {
        public string twoStrings(string s1, string s2)
        {
            var alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();
            string flag = "NO";
            foreach (var alphabet in alphabets)
            {
                if (s1.IndexOf(alphabet, StringComparison.OrdinalIgnoreCase) >= 0 &&
                    s2.IndexOf(alphabet, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    flag = "YES";
                    break;                    
                }
            }

            return flag;
        }

        public void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s1 = Console.ReadLine();

                string s2 = Console.ReadLine();

                string result = twoStrings(s1, s2);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
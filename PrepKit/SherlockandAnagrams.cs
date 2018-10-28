using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;

namespace PrepKit
{
    static class Exten
    {
        public static string Slice(this string source, int start, int end)
        {
            if (end < 0) // Keep this for negative end support
            {
                end = source.Length + end;
            }
            int len = end - start;               // Calculate length
            return source.Substring(start, len); // Return Substring of length
        }
    }
    public class SherlockandAnagrams
    {
        // Complete the sherlockAndAnagrams function below.
        public int sherlockAndAnagrams(string s)
        {
            Dictionary<string, int> substrings = new Dictionary<string, int>();
            int totalAnagrams = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length + 1; j++)
                {
                    var substring = string.Concat(s.Substring(i, j - i).OrderBy(c => c));
                    if (substrings.ContainsKey(substring))
                    {
                        totalAnagrams += substrings[substring];
                        substrings[substring]++;
                    }
                    else
                        substrings.Add(substring, 1);                    
                }
            }

            return totalAnagrams;
        }

        public void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = sherlockAndAnagrams(s);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
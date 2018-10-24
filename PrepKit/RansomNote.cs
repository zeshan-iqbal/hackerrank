using System;
using System.Collections;
using System.Collections.Generic;

namespace PrepKit
{
    //https://www.hackerrank.com/challenges/ctci-ransom-note/problem
    public class RansomNote
    {
        // Complete the checkMagazine function below.
        public void checkMagazine(string[] magazine, string[] note)
        {
            if (magazine.Length < note.Length)
            {
                Console.WriteLine("No");
                return;
            }

            Dictionary<string, int> bagOfWords = new Dictionary<string, int>();

            foreach (var word in magazine)
            {
                if (bagOfWords.ContainsKey(word))
                    bagOfWords[word] = bagOfWords[word] + 1;
                else
                    bagOfWords.Add(word, 1);
            }

            foreach (var word in note)
            {
                if (bagOfWords.ContainsKey(word) && bagOfWords[word] > 0)
                    bagOfWords[word] = bagOfWords[word] - 1;
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");


        }

        public void Main(string[] args)
        {
            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            string[] magazine = Console.ReadLine().Split(' ');

            string[] note = Console.ReadLine().Split(' ');

            checkMagazine(magazine, note);
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    // Problem Statement: https://www.hackerrank.com/challenges/30-dictionaries-and-maps/problem
    static void Main(String[] args)
    {
        IDictionary<string, string> phoneBook = new Dictionary<string, string>();
        if (int.TryParse(Console.ReadLine(), out var phoneBookLength))
        {
            for (int i = 0; i < phoneBookLength; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var name = input[0];
                var number = input[1];
                phoneBook[name] = number;
            }

            var query = Console.ReadLine();
            while (!string.IsNullOrWhiteSpace(query))
            {
                Console.WriteLine(phoneBook.TryGetValue(query, out string phoneNumber)
                    ? $"{query}={phoneNumber}"
                    : "Not found");
                query = Console.ReadLine();
            }
        }        
    }
}

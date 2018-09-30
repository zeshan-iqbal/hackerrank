using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

public class Day10_BinaryNumbers
{
    //https://www.hackerrank.com/challenges/30-binary-numbers/problem

    public static void GetLargestConsecutiveBinaryNumber()
    {
        if (int.TryParse(Console.ReadLine(), out int quotient))
        {            
            if (quotient > 1)
            {
                StringBuilder binaryString = new StringBuilder();
                while (quotient > 0)
                {
                    int remainder = quotient % 2;
                    quotient = quotient / 2;
                    binaryString.Append(remainder);                    
                }

                var longestBinaryStringWithOnes = binaryString.ToString().Split('0').OrderByDescending(x => x.Length).First();
                //long number = 0;
                //for (int i = 0; i < longestBinaryStringWithOnes.Length; i++)
                //{
                //    number += (long)Math.Pow(2, i);
                //}
                Console.WriteLine(longestBinaryStringWithOnes.Length);
            }
            else
                Console.WriteLine(1);
        }
    }
}
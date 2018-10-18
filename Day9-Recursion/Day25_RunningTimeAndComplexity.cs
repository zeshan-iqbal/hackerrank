using System;
using System.Runtime.ConstrainedExecution;

namespace Day9_Recursion
{
    public class Day25_RunningTimeAndComplexity
    {
        private bool IsPrime(int n)
        {
            // check lower boundaries on primality
            if (n == 2)
            {
                return true;
            } // 1 is not prime, even numbers > 2 are not prime
            else if (n == 1 || (n & 1) == 0)
            {
                // (n&1) check is last bit is one. now if last bit is one then number is odd.
                return false;
            }

            // Check for primality using odd numbers from 3 to sqrt(n)
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                // n is not prime if it is evenly divisible by some 'i' in this range
                if (n % i == 0)
                {
                    return false;
                }
            }
            // n is prime
            return true;
        }
    }
}
using System;
using System.Linq;

namespace PrepKit
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SockMerchant
            var ar = new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };
            SockMerchant sockMerchant = new SockMerchant();
            Console.WriteLine($"Sock Merchant Number of Pairs: {sockMerchant.ComputePair(ar.Length, ar)}");
            #endregion

            #region CountingValleys
            var steps = "UDDDUDUU";
            var couningValleys = new CountingValleys();
            int numberOfValleys = couningValleys.countingValleys(steps.Length, steps);
            Console.WriteLine($"Number of valleys in steps {steps}: {numberOfValleys}");
            #endregion
        }
    }
}

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

            #region JumpingOnClouds
            
var a = new int[] {0, 0, 1, 0, 0, 0, 0, 1, 0, 0};
            //var a = new int[] { 0, 0, 1, 0, 0, 1, 0 };
            var jumpingOnClouds = new JumpingOnClouds();
            var numberOfJumps = jumpingOnClouds.jumpingOnClouds(a);
            Console.WriteLine($"Number of jumps: {numberOfJumps}");
            #endregion

            #region Repeated String

            var repeatedString = new RepeatedString();
            long count = repeatedString.repeatedString("gfcaaaecbg", 547602); //expect: 164280: actual: 164283
            Console.WriteLine($"Numbers of a in infinitely repeated string : {count}");
            #endregion

            #region NewYearChaos

            var chaos = new NewYearChaos();
            int[] q = { 2, 1, 5, 3, 4 }; //3
            chaos.minimumBribes(q);
            q = new[]{ 2, 5, 1, 3, 4}; //chaotic
            chaos.minimumBribes(q);

            #endregion
        }
    }
}

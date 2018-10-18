using System;
using System.IO;

namespace PrepKit
{
    //https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem
    public class JumpingOnClouds
    {
        // Complete the jumpingOnClouds function below.
        public int jumpingOnClouds(int[] c)
        {
            int numberOfJumps = 0;            
            for (int i = 0, length = c.Length; i < length - 1;)
            {                
                int jump2 = i + 2;
                int jump1 = i + 1;
                bool canJump2 = jump2 < length && c[jump2] == 0;
                i = canJump2 ? jump2 : jump1;
                numberOfJumps++;
            }
            return numberOfJumps;
        }

        public void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
                ;
            int result = jumpingOnClouds(c);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
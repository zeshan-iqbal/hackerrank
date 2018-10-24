using System;
using System.IO;

namespace PrepKit
{
    public class SherlockandAnagrams
    {
        // Complete the sherlockAndAnagrams function below.
        public int sherlockAndAnagrams(string s)
        {

            return int.MaxValue;
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
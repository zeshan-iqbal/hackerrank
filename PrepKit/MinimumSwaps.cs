using System;
using System.IO;
using System.Linq;

namespace PrepKit
{
    public class MinimumSwaps
    {
        // Complete the minimumSwaps function below.
        public int minimumSwaps(int[] arr)
        {
            int numberOfSwaps = 0;

            //1 3 5 2 4 6 8 -> 3
            for (int i = 0, j = 1, length = arr.Length; i < length; i++, j++)
            {
                if (arr[i] == j) continue;

                int k = j;
                while (k < arr.Length && arr[k] != j)
                {
                    k++;
                }

                arr[k] = arr[i];
                arr[i] = j;
                numberOfSwaps++;
            }

            return numberOfSwaps;
        }
        /**
         * The idea is that if  occupies  position,  occupies  position and so on, then there will be some integer  which will occupy  position. So, this forms a cycle.
         *So, if any element  is not at its correct position, we shift it to its correct position , then shift  to its correct position  and so on. So, if  is the length of the cycle (number of elements in the cycle), then it will require a minimum of swaps to rearrange the elements of the cycle to their correct positions.
         *We find all such cycles and compute our answer.
         */
        public int minimumSwaps2(int[] arr)
        {
            int numberOfSwaps = 0;

            //1 3 5 2 4 6 8 -> 3
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == i + 1) continue;

                arr[arr[i] - 1] = arr[i];
                arr[i] = i + 1;

                numberOfSwaps++;
            }

            return numberOfSwaps;
        }

        public int swap(int[] arr, int i, int j)
        {
            if (arr[i] == arr[j])
                return 1;

            return 1 + swap(arr, i, j);
        }

        public void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
                ;
            int res = minimumSwaps(arr);

            textWriter.WriteLine(res);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
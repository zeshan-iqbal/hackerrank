using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PrepKit
{
    //FrequencyQueries: https://www.hackerrank.com/challenges/frequency-queries/problem
    public class FrequencyQueries
    {
        /// <summary>
        /// This solution is slow for test case 9-13 and it won't pass. In order to pass those test case we need to use two dictionaries
        /// as following:
        /// m1 is to store values with their frequency
        /// m2 is to store the count of every frequency
        /// 
        /// </summary>
        /// <param name="queries"></param>
        /// <returns></returns>
        public List<int> freqQuery(List<List<int>> queries)
        {
            //Solution: https://www.hackerrank.com/challenges/frequency-queries/editorial            
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            List<int> output = new List<int>();
            foreach (var query in queries)
            {
                int queryType = query.First();
                int q = query.Last();
                switch (queryType)
                {
                    case 1:
                        if (frequency.ContainsKey(q)) frequency[q]++;
                        else frequency.Add(q, 1);
                        break;
                    case 2:
                        if (frequency.ContainsKey(q) && frequency[q] > 0) frequency[q]--;                            
                        break;
                    case 3:
                        output.Add(frequency.ContainsValue(q) ? 1 : 0);
                        break;
                }
            }
            return output;
        }

        public void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> queries = new List<List<int>>();            

            for (int i = 0; i < q; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            List<int> ans = freqQuery(queries);

            textWriter.WriteLine(String.Join("\n", ans));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
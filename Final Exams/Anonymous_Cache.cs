using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSet = new Dictionary<string, Dictionary<string, long>>();
            var cache = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "thetinggoesskrra")
                {
                    break;
                }

                if (input.Contains('|'))
                {
                    string[] inputLine = input.Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries);
                    string dataKey = inputLine[0];
                    long dataSize = long.Parse(inputLine[1]);
                    string dataSetName = inputLine[2];

                    if (dataSet.ContainsKey(dataSetName))
                    {
                        dataSet[dataSetName][dataKey] = dataSize;
                    }
                    else
                    {
                        if (!cache.ContainsKey(dataSetName))
                        {
                            cache[dataSetName] = new Dictionary<string, long>();
                        }
                        cache[dataSetName][dataKey] = dataSize;
                    }
                }
                else
                {
                    if (!dataSet.ContainsKey(input))
                    {
                        dataSet[input] = new Dictionary<string, long>();
                        if (cache.ContainsKey(input))
                        {
                            dataSet[input] = cache[input];
                        }
                    }
                }
            }

            if (dataSet.Count > 0)
            {
                var bestSet = dataSet
                    .OrderByDescending(x => x.Value.Values.Sum())
                    .First();

                Console.WriteLine($"Data Set: {bestSet.Key}, Total Size: {bestSet.Value.Values.Sum()}");
                foreach (var kvp in bestSet.Value)
                {
                    Console.WriteLine($"$.{kvp.Key}");
                }
            }
        }
    }
}

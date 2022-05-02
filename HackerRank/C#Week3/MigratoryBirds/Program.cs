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

namespace MigratoryBirds
{
    class Result
    {
        public static int migratoryBirds(List<int> arr)
        {
            arr.Sort();
            int mostFrequent = arr[0];
            int currElement = arr[0];
            int highCount = 1;
            int currCount = 0;

            if (arr.Count == 0)
            {
                return mostFrequent;
            }

            for (int i = 0; i < arr.Count; i += currCount)
            {      
                currElement = arr[i];
                for (int j = 0; j < arr.Count; j++)
                {
                    if (currElement == arr[j])
                    {
                        currCount++;
                    }
                    if (currCount > highCount)
                    {
                        mostFrequent = currElement;
                        highCount++;
                    }
                }
            }
            return mostFrequent;
        }
    }
    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = Result.migratoryBirds(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}



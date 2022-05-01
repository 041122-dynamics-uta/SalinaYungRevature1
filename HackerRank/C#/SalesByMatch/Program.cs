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

namespace SalesByMatch
{
    class Result
    {
        public static int sockMerchant(int n, List<int> ar)
        {
            ar.Sort();
            int numOfPairs = 0;
            int sameColor = 0;
            int currColor = ar[0];
        
            if (ar.Count == 0) 
            {
                return numOfPairs;
            }
        
            for (int i = 0; i < n; i += sameColor)
            {
                    currColor = ar[i];
                    sameColor = 0;
                    for (int j = 0; j < n; j++) 
                    {
                        if (currColor == ar[j])
                        {
                            sameColor++;
                        }
                    }
                    numOfPairs += (sameColor / 2);
            }
            return numOfPairs;
        }
    }
    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = Result.sockMerchant(n, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}

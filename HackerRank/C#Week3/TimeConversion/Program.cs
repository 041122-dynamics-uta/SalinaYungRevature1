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

namespace TimeConversion
{
    class Result
    {
        public static string timeConversion(string s)
        {
            int hour = Int32.Parse(s.Remove(2));
        
            if (s.Contains('A'))
            {
                if (hour == 12)
                {
                    s = s.Remove(0, 2);
                    string result = "00" + s;
                    s = result.Remove(8);
                }
                else
                {
                    s = s.Remove(8);
                }
            }
            else
            {
                if (hour != 12)
                {
                    s = s.Remove(0, 2);
                    hour += 12;
                    s = Convert.ToString(hour) + s;
                }
                s = s.Remove(8);
            }
            return s;
        }
    }
class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = Result.timeConversion(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}

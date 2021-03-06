using System;
using System.Collections;
using System.Collections.Generic;

namespace _11_ArraysAndListsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }//EoM

        /// <summary>
        /// This method takes an array of integers and returns a double, the average 
        /// value of all the integers in the array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static double AverageOfValues(int[] array)
        {
            //throw new NotImplementedException("AverageOfValues has not been implemented yet.");
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return (sum / array.Length);
        }

        /// <summary>
        /// This method increases each array element by 2 and 
        /// returns an array with the altered values.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int[] SunIsShining(int[] x)
        {
            //throw new NotImplementedException("SunIsShining has not been implemented yet.");
            for (int i = 0; i < x.Length; i++)
            {
                x[i] += 2;
            }
            return x;
        }

        /// <summary>
        /// This method takes an ArrayList containing types of double, int, and string 
        /// and returns the average of the ints and doubles only, as a decimal.
        /// It ignores the string values and rounds the result to 3 decimal places toward the nearest even number.
        /// </summary>
        /// <param name="myArrayList"></param>
        /// <returns></returns>
        public static decimal ArrayListAvg(ArrayList myArrayList)
        {
            //throw new NotImplementedException("ArrayListAvg has not been implemented yet.");
            double sum = 0;
            int count = 0;
            foreach (var el in myArrayList)
            {
                //ints and doubles only
                if (el.GetType() == typeof(int) || (el.GetType() == typeof(double)))
                {
                    sum += Convert.ToDouble(el);
                    count++;
                }
            }
            decimal avg = Convert.ToDecimal(sum / count);

            //rounds the result to 3 decimal places toward the nearest even number
            return Math.Round(avg, 3);
        }

        /// <summary>
        /// This method returns the rank (starting with 1st place) of a new 
        /// score entered into a list of randomly ordered scores.
        /// </summary>
        /// <param name="myArray1"></param>
        public static int ListAscendingOrder(List<int> scores, int yourScore)
        {
            //throw new NotImplementedException("ListAscendingOrder has not been implemented yet.");
            scores.Sort();
            int rank = 0;
            for (int i = 0; i < scores.Count; i++)
            {
                if (scores[i] > yourScore)
                {
                    rank = i + 1; //off by 1 index
                    break;
                }
            }
            return rank;
        }

        /// <summary>
        /// This method has with two parameters takes a List<string> and a string.
        /// The method returns true if the string parameter is found in the List, otherwise false.
        /// </summary>
        /// <param name="myArray2"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public static bool FindStringInList(List<string> myArray2, string word)
        {
            //throw new NotImplementedException("FindStringInList has not been implemented yet.");
            for (int i = 0; i < myArray2.Count; i++)
            {
                if (myArray2[i] == word)
                {
                    return true;
                }
            }
            return false;
        }
    }//EoP
}// EoN
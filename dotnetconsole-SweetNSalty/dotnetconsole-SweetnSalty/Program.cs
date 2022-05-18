using System;

namespace dotnetconsole_SweetnSalty
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize variable counters to increment
            int sweetCount = 0;
            int saltyCount = 0;
            int sweetAndSaltyCount = 0;

            //Get start number from user
            Console.WriteLine("Hello User! Please enter starting number.");
            int startNum = Int32.Parse(Console.ReadLine());
            //Get stop number from user
            Console.WriteLine("Please enter ending number.");
            int endNum = Int32.Parse(Console.ReadLine());
            //Get the quantity of numbers to print per line from the user
            Console.WriteLine("Please enter how many numbers to print per line.");
            int printNum = Int32.Parse(Console.ReadLine());

            //Empty line for readability, outputs displayed after
            Console.WriteLine();

            //For loop to loop through user inputted range and print sweet/salt/sweet'nsalty if it matches condition
            for (int i = startNum; i <= endNum; i++)
            {
                //If the num at i has no remainder when divided by 5 and by 3 (i is multiple of 5 and 3)
                if (i % 5 == 0 && i % 3 == 0)
                {
                    //Then print sweet'nsalty with space and increment the sweetsalty count
                    Console.Write(" Sweet'nSalty");
                    sweetAndSaltyCount++;
                }
                //Else if i is only divisible by 3 with no remainder
                else if (i % 3 == 0)
                {
                    //Then print sweet with space and increment the sweet count
                    Console.Write(" Sweet");
                    sweetCount++;
                }
                //Else if i is only divisible by 5 with no remainder
                else if (i % 5 == 0)
                {
                    //then print salty with space and increment the salty count
                    Console.Write(" Salty");
                    saltyCount++;
                }
                //If i is not a multiple of 5 or 3 then print i with space
                else
                {
                    Console.Write($" {i}");
                }
                //Print per line
                if (i % printNum == 0)
                {
                    Console.WriteLine();
                }
            }//End of for loop
            //Empty line for readability, counts displayed after
            Console.WriteLine();
            //Print to console on 3 separate lines: how many sweet, salty, and sweet'nsalty
            Console.WriteLine($"Sweet: {sweetCount}");
            Console.WriteLine($"Salty: {saltyCount}");
            Console.WriteLine($"Sweet'nSalty: {sweetAndSaltyCount}");
        }//EoM
    }
}
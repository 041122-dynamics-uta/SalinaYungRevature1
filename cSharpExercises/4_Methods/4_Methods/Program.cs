using System;

namespace _4_MethodsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /**
                YOUR CODE HERE.
            **/
            GetName();
            GreetFriend("Monica");
            GetNumber();
            GetAction();
            DoAction(5.0,2.0,3);
        }

        public static string GetName()
        {
            //throw new NotImplementedException("GetName() is not implemented yet0");
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            //Console.WriteLine(userName);
            return userName;
        }

        public static string GreetFriend(string name)
        {
            //throw new NotImplementedException("GreetFriend() is not implemented yet");
            Console.WriteLine($"Hello, {name}. You are my friend.");
            return $"Hello, {name}. You are my friend.";
        }

        public static double GetNumber()
        {
            //throw new NotImplementedException("GetNumber() is not implemented yet");
            double num;
            bool reRun = true;
            do
            {
                Console.WriteLine("Pick a number");
                string strNum = Console.ReadLine();
                if (double.TryParse(strNum, out num)) //validate user input is double
                {
                    reRun = false;
                }
                else
                {
                    Console.WriteLine("Invalid input, please pick a number.");
                }
            }
            while (reRun);
            return num;
        }

        public static int GetAction()
        {
            //throw new NotImplementedException("GetAction() is not implemented yet");
            bool reRun = true;
            do
            {
                Console.WriteLine("Please select: 1)Add 2)Subtract 3)Multiply 4)Divide");
                int action = Convert.ToInt32(Console.ReadLine());
                if (action == 1 || action == 2 || action == 3 || action == 4) 
                {
                    reRun = false;
                } 
                else 
                {
                    Console.WriteLine("Invalid input, please pick an action.");
                }
                return action;
            }
            while (reRun);
        }

        public static double DoAction(double x, double y, int action)
        {
            //throw new NotImplementedException("DoAction() is not implemented yet");
            if (action == 1) 
            {
                Console.WriteLine($"Your result is {x + y}");
                return x + y;
            }
            else if (action == 2) 
            {
                Console.WriteLine($"Your result is {Math.Abs(x - y)}");
                return Math.Abs(x - y);
            }
            else if (action == 3) {
                Console.WriteLine($"Your result is {x * y}");
                return x * y;
            } 
            else if (action == 4) {
                Console.WriteLine($"Your result is {x / y}");
                return x / y;
            } else
            {
                throw new FormatException("FormatException");
            }
        }
    }
}
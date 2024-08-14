using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements3
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintRangeOfNumbers()
        {
            Console.WriteLine("Enter two numbers to get the range.");
            Console.WriteLine("Number 1: ");
            var userNum1 = Console.ReadLine();
            Console.WriteLine("Number 2: ");
            var userNum2 = Console.ReadLine();

            if (int.TryParse(userNum1, out int rangeNum1) && int.TryParse(userNum2, out int rangeNum2))
            {
                for (int i = rangeNum1; i <= rangeNum2; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
                PrintRangeOfNumbers();
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void IncrementByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to accept two integers as parameters and check whether they are equal or not
        public static bool IsEqual(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            return false;
        }
        //Write a method to check whether a given number is even or odd
        public static bool IsEven(int a)
        {

            if (a % 2 == 0)
            {
                return true;
            }
            return false;
        }

        //Write a method to check whether a given number is positive or negative
        public static bool IsPositive(int a)
        {
            if (a >= 0)
            {
                return true;
            }
            return false;
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static bool IsOldEnoughToVote()
        {
            const int minAgeToVote = 18;

            Console.WriteLine("What is your age?");

            var userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int age))
            {
                if (age >= minAgeToVote)
                {
                    Console.WriteLine("You are old enough to vote.");
                    return true;
                }
                Console.WriteLine("You are not old enough to vote.");
                return false;

            }
            Console.WriteLine("That is not a valid age. Try again.");
            return IsOldEnoughToVote();
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool WithinRange()
        {
            Console.WriteLine("Enter number between -10 and 10: ");
            if (int.TryParse(Console.ReadLine(), out int userNum))
            {
                if ((userNum >= -10) && (userNum <= 10))
                {
                    Console.WriteLine($"{userNum} is within range.");
                    return true;
                }
                Console.WriteLine($"{userNum} is not in range.");
                return false;
            }
            Console.WriteLine("That is not a number.");
            return false;

        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplyTable()
        {
            int[] factors = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            Console.WriteLine("Enter a number: ");

            var userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int baseNumber))
            {
                for (int i = 0; i < factors.Length; i++)
                {
                    int answer = baseNumber * factors[i];

                    Console.WriteLine($"{baseNumber} * {factors[i]} = {answer}");

                }
            }
            else
            {
                Console.WriteLine("That is not a valid number. Try again.");
                MultiplyTable();
            }
        }

        //Call the methods to test them in the Main method below
        public static void Main(string[] args)
        {
            //PrintRangeOfNumbers();
            //IncrementByThree();
            //Console.WriteLine(IsEqual(5, 5));
            //Console.WriteLine(IsEven(5));
            //Console.WriteLine(IsEven(6));
            //Console.WriteLine(IsPositive(6));
            //Console.WriteLine(IsPositive(-6));
            //IsOldEnoughToVote();
            //WithinRange();
            //MultiplyTable();


        }
    }
}

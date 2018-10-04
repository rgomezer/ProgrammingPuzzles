using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class Puzzles
    {
        //Loop through numbers 1 to 1000
        //If a number is divisible by x print "Fizz"
        //If a number is divisible by y print "Buzz"
        //If a number is divisible by x and y print "FizzBuzz"
        public void FizzBuzz(int x, int y)
        {
            for (int i = 0; i < 1000; i++)
            {
                if (i % x == 0 && i % y == 0)
                {
                    Console.WriteLine("FizzBuzz: {0}", i);
                }
                else if (i % x == 0)
                {
                    Console.WriteLine("Fizz: {0}", i);
                }
                else if (i % y == 0)
                {
                    Console.WriteLine("Buzz: {0}", i);
                }
            }
        }

        //Find the Nth fibonacci number
        public int FindNthFiboNacci(int n)
        {
            if (n < 0)
            {
                return -1;
            }
            else if (n == 0 || n == 1)
            {
                return n;
            }

            return FindNthFiboNacci(n - 1) + FindNthFiboNacci(n - 2);
        }

        //Find the number of duplicates in an array of integers
        public int FindDuplicates(int[] array)
        {
            int count = 0;
            int temp = 0;

            if (array == null)
            {
                return -1;
            }

            Dictionary<int, int> duplicates = new Dictionary<int, int>();

            foreach (var value in array)
            {
                if (duplicates.ContainsKey(value))
                {
                    duplicates[value]++;
                }
                else
                {
                    duplicates[value] = 1;
                }
            }

            foreach (var item in duplicates)
            {
                temp = item.Value;

                if (temp > 1)
                {
                    count++;
                }
            }

            return count;
        }

        public bool isPallendrome(string input)
        {
            if(input == null)
            {
                return false;
            }

            int forward = 0;
            int backward = input.Length - 1;

            char temp;
            char temp2;

            for (int i = 0; i < input.Length; i++)
            {
                temp = input[forward];
                temp2 = input[backward];

                if (temp != temp2)
                {
                    return false;
                }

                backward--;
                forward++;
            }


            return true;
        }
    }
}

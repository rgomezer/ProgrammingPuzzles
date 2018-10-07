using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Puzzles obj = new Puzzles();

            obj.FizzBuzz(3, 5);

            Console.WriteLine("");
            Console.WriteLine("");

            int input = 7;

            int temp = obj.FindNthFiboNacci(input);

            Console.WriteLine("Nth Fibonacci number of : {0} is {1}", input, temp);
            Console.WriteLine("");
            Console.WriteLine("");

            int[] input2 = { 1, 1, 2, 2, 3, 3, 3, 4, 5, 6, 7, 8, 9 };
            int temp2 = obj.FindDuplicates(input2);

            Console.WriteLine("Number of Duplicates in Array: {0}", temp2);

            Console.WriteLine("");
            Console.WriteLine("");

            string test = "racecar";

            obj.isPallendrome(test).ToString();

            Console.WriteLine("Is {0} a pallendrome: {1}", test, obj.isPallendrome(test).ToString());

            string test2 = "teststring";

            Console.WriteLine("Is {0} a pallendrome: {1}", test2, obj.isPallendrome(test2).ToString());

            string test3 = "abbbaba";

            obj.isPallendrome(test3).ToString();

            Console.WriteLine("Is {0} a pallendrome: {1}", test3, obj.isPallendrome(test3).ToString());

            double answer = obj.exponent(2, 2.25);
            Console.WriteLine("The power of 2 cubed is: {0} ", answer);
        }
    }
}

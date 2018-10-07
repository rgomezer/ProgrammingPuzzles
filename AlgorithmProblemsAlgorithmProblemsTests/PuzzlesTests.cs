using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems.Tests
{
    [TestClass()]
    public class PuzzlesTests
    {
        [TestMethod()]
        public void FindDuplicatesTest()
        {
            Puzzles pPuzzle = new Puzzles();

            int[] input = { 1, 1, 2, 2, 3, 3, 3, 4, 5, 6, 7, 8, 9 };
            Assert.AreEqual(3, pPuzzle.FindDuplicates(input));

            int[] input2 = { 1, 1, 2, 2, 3, 3, 3, 4, 5, 6, 6, 6, 7, 8, 9, 9, 9, 11, 11, 10 };
            Assert.AreEqual(6, pPuzzle.FindDuplicates(input2));

            Assert.AreEqual(-1, pPuzzle.FindDuplicates(null));
        }

        [TestMethod()]
        public void isPallendromeTest()
        {
            Puzzles pPuzzle = new Puzzles();

            string test = "racecar";
            string test2 = "teststring";
            string test3 = "abbbba";
            string test4 = "abbbaba";

            Assert.AreEqual(true, pPuzzle.isPallendrome(test));
            Assert.AreEqual(false, pPuzzle.isPallendrome(test2));
            Assert.AreEqual(true, pPuzzle.isPallendrome(test3));
            Assert.AreEqual(false, pPuzzle.isPallendrome(test4));
            Assert.AreEqual(false, pPuzzle.isPallendrome(null));
        }

        [TestMethod()]
        public void FindNthFiboNacciTest()
        {
            Puzzles pPuzzle = new Puzzles();

            Assert.AreEqual(102334155, pPuzzle.FindNthFiboNacci(40));
            Assert.AreEqual(832040, pPuzzle.FindNthFiboNacci(30));
            Assert.AreEqual(6765, pPuzzle.FindNthFiboNacci(20));
            Assert.AreEqual(55, pPuzzle.FindNthFiboNacci(10));
            Assert.AreEqual(13, pPuzzle.FindNthFiboNacci(7));
            Assert.AreEqual(1, pPuzzle.FindNthFiboNacci(1));
            Assert.AreEqual(0, pPuzzle.FindNthFiboNacci(0));
            Assert.AreEqual(-1, pPuzzle.FindNthFiboNacci(-15));
        }

        [TestMethod()]
        public void ExponentialCalculatorTest()
        {
            Puzzles pPuzzle = new Puzzles();

            Assert.AreEqual(1, pPuzzle.exponent(2, 0));
            Assert.AreEqual(8, pPuzzle.exponent(2, 3));
            Assert.AreEqual(4294967296, pPuzzle.exponent(2, 32));
        }
    }
}
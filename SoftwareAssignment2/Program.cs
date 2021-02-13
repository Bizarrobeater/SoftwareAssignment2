using System;
using static SoftwareAssignment2.Test;

namespace SoftwareAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // Input: None
        // Expected PrintOutput:
        /*  1
         *  2
         *  3
         *  4
         *  5
         *  6
         *  7
         *  8
         *  9
         *  10
         *  Finished! 
         */
        // Returns: Nothing
            
        static void TestMethod1()
        {
            Fundamentals.CountToTen();
        }


        // Input: int
        // Output: n'th Fibonacci number
        // Example input: 10
        // Expected output: 55
        static void TestMethod2()
        {
            int resultInt = Fundamentals.Fibonacci(10);
            bool testResult = AssertAreEqual(resultInt, 55);
            Console.WriteLine($"TestMethod2 was succesful: {testResult}");
        }


        // Input: int
        // Output: Length of Collatz sequence starting at n
        
        // Example input1: 8
        // Example print output: 8, 4, 2, 1
        // Expected output1: 4 (int)
        
        // Example input2: 13
        // Example print output: 13, 40, 20, 10, 5, 16, 8, 4, 2, 1
        // Example output2: 10 (int)
        static void TestMethod3()
        {
            int resultInt = Fundamentals.CollatzSequenceLength(8);
            bool testResult = AssertAreEqual(resultInt, 4);
            Console.WriteLine($"TestMethod3 example 1 was succesful: {testResult}");

            resultInt = Fundamentals.CollatzSequenceLength(13);
            testResult = AssertAreEqual(resultInt, 10);
            Console.WriteLine($"TestMethod3 example 2 was succesful: {testResult}");
        }
    }
}

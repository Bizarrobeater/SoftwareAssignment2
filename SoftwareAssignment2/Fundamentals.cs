using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareAssignment2
{
    static class Fundamentals
    {
        public static void CountToTen()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }
            Console.WriteLine("Finished!");

        }

        public static int Fibonacci(int nthNumber)
        {
            int[] fibPair = { 0, 1 };
            for (int i = 0; i < nthNumber; i++)
            {
                fibPair = new int[]{ fibPair[1], fibPair[0] + fibPair[1]};
            }
            return fibPair[0];
        }

        public static int CollatzSequenceLength(int startNumber)
        {
            StringBuilder sequenceBuilder = new StringBuilder();
            int currNum = startNumber;
            int length = 1;

            while(currNum != 1)
            {
                sequenceBuilder.Append($"{currNum}, ");
                length++;
                if (currNum % 2 == 0)
                    currNum = currNum / 2;
                else
                    currNum = 3 * currNum + 1;
            }
            sequenceBuilder.Append(currNum);
            Console.WriteLine(sequenceBuilder.ToString());

            return length;
        }
    }
}

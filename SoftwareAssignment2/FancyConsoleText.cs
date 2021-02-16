using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAssignment2
{
    static class FancyConsoleText
    {
        const int waitTimeMS = 3; // wait time between each animation loop
        const int padLength = 20; // from how far the new letter should come

        public static void FromLeft(string text)
        {
            string finishedText = "";
            foreach (char c in text)
            {
                if (c != ' ')
                    AnimateCharFromleft(finishedText, c, text.Length);
                finishedText += c;
            }
        }

        private static string PadTextRight(string finishedText, char c, int charPad, int fullPad)
        {
            StringBuilder padder = new StringBuilder();
            padder.Append(finishedText.PadRight(charPad));
            padder.Append(c);
            padder.Length += fullPad - charPad;
            return padder.ToString();
        }

        private static void AnimateCharFromleft(string finishedText, char c, int fullStringLength)
        {
            string printText;
            int fullPadding = padLength + fullStringLength;
            for (int i = fullPadding; i >= 0; i--)
            {
                printText = PadTextRight(finishedText, c, i, fullPadding);
                ClearLastLine();
                Console.Write(printText);
                System.Threading.Thread.Sleep(waitTimeMS);
            }
        }

        public static void ClearLastLine()
        {
            Console.Write("\r");
        }
    }
}

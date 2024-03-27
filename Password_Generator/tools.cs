using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ask_Password_Generator
{
    static class tools
    {
        // Ask a positive number not null
        public static int AskPositiveNumberNotNull(string question)
        {
            return AskNumberBetween(question, 1, int.MaxValue, "ERROR : The number must be positive and not null");
        }

        // Ask a number between min and max
        public static int AskNumberBetween(string question, int min, int max, string customErrorMessage = null)
        {
            // Ask a number
            while (true)
            {
                int number = AskNumber(question);

                // Check if the number is between min and max
                if ((number >= min) && (number <= max))
                {
                    return number;
                }

                // Display an error message
                if (customErrorMessage != null)
                {
                    Console.WriteLine(customErrorMessage);
                }
                else
                {
                    Console.WriteLine($"ERROR : The number must be between {min} and {max}.");

                }

                Console.WriteLine();

                return AskNumberBetween(question, min, max, customErrorMessage);

            }
        }

        // Ask a number
        public static int AskNumber(string question)
        {
            while (true)
            {
                Console.Write(question);
                string answer = Console.ReadLine();

                // Check if the answer is a number
                try
                {
                    int answerParse = int.Parse(answer);
                    return answerParse;
                }
                catch
                {
                    Console.WriteLine("ERROR : You must enter a number.");
                    Console.WriteLine();
                }
            }
        }

    }
}

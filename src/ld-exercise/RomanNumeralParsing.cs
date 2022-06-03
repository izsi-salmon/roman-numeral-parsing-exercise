using System;
using System.Collections.Generic;
using System.Text;

namespace ld_exercise
{
    public class RomanNumeralParsing
    {
        // A dictionary, inside <> is <key, value>

        // Telling it that it is read only lets the compiler know that it doesn't need to onclude the code required to change it, and it will warn us if we try and change it
        private readonly Dictionary<int, string> _romanNumerals = new Dictionary<int, string>()
        {
            { 1000, "M" },
            { 500, "D" },
            { 100, "C" },
            { 50, "L" },
            { 10, "X" },
            { 5, "V" },
            { 1, "I" }
        };

        public void PrintRomanNumerals(int input)
        {
            string result = ParseRomanNumerals(input);

            Console.WriteLine(result);
        }

        // Can test this method using the unit tests
        public string ParseRomanNumerals(int input)
        {
            // Pseudo code:
            // For inputs under 10
            // Take the input and modulo it by 5
            // Add a V for each 5, add a I for each remainder

            string output = "";

            int total = input;

            int numberOfThousands = input / 1000;

            // string result = "";

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < numberOfThousands; i++)
            {
                result.Append(_romanNumerals[1000]);
                total -= 1000;
            }

            int numberOfFiveHundreds = total / 500;

            for (int i = 0; i < numberOfFiveHundreds; i++)
            {
                result.Append(_romanNumerals[500]);
                total -= 500;
            }

            int numberOfHundreds = total / 100;

            for (int i = 0; i < numberOfHundreds; i++)
            {
                result.Append(_romanNumerals[100]);
                total -= 100;
            }

            int numberOfFifties = total / 50;

            for (int i = 0; i < numberOfFifties; i++)
            {
                result.Append(_romanNumerals[50]);
                total -= 50;
            }

            int numberOfTens = total / 10;

            for (int i = 0; i < numberOfTens; i++)
            {
                result.Append(_romanNumerals[10]);
                total -= 10;
            }


            int numberOfFives = total / 5;

            for (int i = 0; i < numberOfFives; i++)
            {
                result.Append(_romanNumerals[5]);
                total -= 5;
            }

            int numberOfOnes = total;

            for (int i = 0; i < numberOfOnes; i++)
            {
                result.Append(_romanNumerals[1]);
            }

            // foreach (var item in _romanNumerals)
            // {
            //     //     int numerators = input / item.Key;
            //     //     input %= item.Key;
            // }

            output = result.ToString();

            return output;
        }
    }
}
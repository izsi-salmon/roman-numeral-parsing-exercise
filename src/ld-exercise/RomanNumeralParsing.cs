using System;
using System.Collections.Generic;
using System.Text;

namespace ld_exercise
{
    public class RomanNumeralParsing
    {
        // A dictionary, inside <> is <key, value>

        // Telling it that it is read only lets the compiler know that it doesn't need to onclude the code required to change it, and it will warn us if we try and change it
        private readonly Dictionary<int, char> _romanNumerals = new Dictionary<int, char>()
        {
            { 1000, 'M' },
            { 500, 'D' },
            { 100, 'C' },
            { 50, 'L' },
            { 10, 'X' },
            { 5, 'V' },
            { 1, 'I' }
        };

        public void PrintRomanNumerals(int input)
        {
            string result = ParseRomanNumerals(input);

            Console.WriteLine(result);
        }

        public string ParseRomanNumerals(int input)
        {
            StringBuilder result = new StringBuilder();

            int total = input;

            foreach (var romanNumeral in _romanNumerals)
            {
                Processor(romanNumeral.Key, romanNumeral.Value);
            }

            return result.ToString();

            void Processor(int romanNumeralNumber, char romanNumeralSymbol)
            {
                string numberOfNumerals = new string(romanNumeralSymbol, total / romanNumeralNumber);

                result.Append(numberOfNumerals);

                total %= romanNumeralNumber;
            }
        }
    }
}
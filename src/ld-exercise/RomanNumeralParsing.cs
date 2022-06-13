using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;

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

        [Benchmark]
        public string ParseRomanNumerals(int input)
        {
            StringBuilder result = new StringBuilder();

            int total = input;

            foreach (var romanNumeral in _romanNumerals)
            {
                AppendRomanNumerals(romanNumeral.Key, romanNumeral.Value);
            }

            return result.ToString();

            void AppendRomanNumerals(int romanNumeralNumber, char romanNumeralSymbol)
            {
                string numberOfNumerals = new string(romanNumeralSymbol, total / romanNumeralNumber);

                result.Append(numberOfNumerals);

                total %= romanNumeralNumber;
            }
        }

        [Benchmark]
        public string ParseRomanNumeralsBeta(int input)
        {
            string output = "";

            int total = input;

            int numberOfThousands = input / 1000;

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

            output = result.ToString();

            return output;
        }
    }
}
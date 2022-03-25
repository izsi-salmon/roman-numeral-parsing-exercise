using System;
using System.Collections.Generic;

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

        public string Parse(int input)
        {
            string output = "";

            output = _romanNumerals[input];

            foreach (var item in _romanNumerals)
            {
                int numerators = input / item.Key;
                input %= item.Key;
            }

            // TODO: modify the output to have the correct roman letters

            return output;
        }
    }
}
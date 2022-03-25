using System;
using System.Collections.Generic;

namespace ld_exercise
{
    public class RomanNumeralParsing
    {
        public string Parse(int input)
        {
            string output = "I";

            // A dictionary, inside <> is <key, value>
            Dictionary<int, string> romanNumerals = new Dictionary<int, string>()
            {
                { 1, "I" },
                { 5, "V" },
                { 10, "X" },
                { 50, "L" },
                { 100, "C" },
                { 500, "D" },
                { 1000, "M" }
            };

            output = romanNumerals[input];

            return output;
        }
    }
}
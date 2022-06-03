// Lesson notes

// Commandline commands
// dontnet run [arguments] – runs the program
// dotnet test – runs the unit tests
// dotnet watch run [arguments] – reruns the programme each time file changes, ie on save
// dotnet watch test – runs the tests each time files change

// Short cuts
// ctrl + k + d = format code

using System;
using System.Collections.Generic;

// Like the shelf in the library
namespace ld_exercise
{
    // Like the book in the shelf
    public class Program
    {
        public static void Main(string[] args)
        {
            var parsedInput = int.Parse(args[0]);
            new RomanNumeralParsing().PrintRomanNumerals(parsedInput);
        }
    }
}

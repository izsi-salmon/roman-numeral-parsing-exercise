using BenchmarkDotNet.Attributes;

namespace ld_exercise
{
    public class BenchMarkTests
    {
        private readonly RomanNumeralParsing _romanNumeralParser = new RomanNumeralParsing();

        private readonly int testInput = 1234;

        [Benchmark]
        public string ParseRomanNumerals() => _romanNumeralParser.ParseRomanNumerals(testInput);

        [Benchmark]
        public string ParseRomanNumeralsBeta() => _romanNumeralParser.ParseRomanNumeralsBeta(testInput);
    }
}
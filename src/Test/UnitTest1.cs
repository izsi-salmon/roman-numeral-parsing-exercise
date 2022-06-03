using System;
using ld_exercise;
using Xunit;

namespace Test
{
    public class RomanParsingTests
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(5, "V")]
        [InlineData(10, "X")]
        [InlineData(50, "L")]
        [InlineData(100, "C")]
        [InlineData(500, "D")]
        [InlineData(1000, "M")]
        public void SingleCharacterOutputs(int input, string expected)
        {
            // Arrange
            ld_exercise.RomanNumeralParsing sut = new RomanNumeralParsing();
            // Act
            var actual = sut.ParseRomanNumerals(input);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IIII")]
        public void OneToFour(int input, string expected)
        {
            // Arrange
            ld_exercise.RomanNumeralParsing sut = new RomanNumeralParsing();
            // Act
            var actual = sut.ParseRomanNumerals(input);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}

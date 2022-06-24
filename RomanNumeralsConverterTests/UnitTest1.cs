using ConvertToRomanNumerals;

namespace RomanNumeralsConverterTests
{
    public class RomanNumeralsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(123, "CXXIII")]
        [TestCase(2000, "MM")]
        [TestCase(1, "I")]
        [TestCase(1987, "MCMLXXXVII")]
        [TestCase(4999, "MMMMCMXCIX")]
        [TestCase(1645, "MDCXLV")]
        [TestCase(5, "V")]
        public void ConvertNumbersRomanNumerals_ReturnValidRomanNumerals(int input, string expectedResult)
        {
            //Arrange
            //Act
            var actualResult = ToRomanNumerals.ConvertNumbersRomanNumerals(input);
            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
using NUnit.Framework;
using System;

namespace FizzBuzz.Test
{ 
    [TestFixture]
    class FizzbuzzerTests
    {
        private static int[] indivisibleInputs = new int[] { 
            1, 2, 4, 7, 8, 11, 13
        };

        [TestCaseSource("indivisibleInputs")]
        public void Convert_WhenInputIsIndivisible_ReturnsNumberAsString(int number)
        {
            // Arrange
            FizzBuzzer fizzBuzzer = new FizzBuzzer();
            string expected = number.ToString();

            // Act
            string actual = fizzBuzzer.Convert(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void Convert_WhenInputIsDivisibleByFizz_ReturnsFizz(int number)
        {
            var fizzBuzzer = new FizzBuzzer();
            string expected = "Fizz";

            string actual = fizzBuzzer.Convert(number);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void Convert_WhenInputIsDivisibleByBuzz_ReturnsBuzz(int number)
        {
            var fizzBuzzer = new FizzBuzzer();
            string expected = "Buzz";

            string actual = fizzBuzzer.Convert(number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void Convert_WhenInputIsDivisibleByFizzAndBuzz_ReturnsFizzBuzz(int number)
        {
            var fizzBuzzer = new FizzBuzzer();
            string expected = "FizzBuzz";

            string actual = fizzBuzzer.Convert(number);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Convert_WhenInputIsZeroOrNegative_ThrowsArgumentException() 
        {
            FizzBuzzer fizzBuzzer = new FizzBuzzer();
            int number = 0;
            Assert.Throws<ArgumentException>(() => { fizzBuzzer.Convert(number); });        
        }
    }
}

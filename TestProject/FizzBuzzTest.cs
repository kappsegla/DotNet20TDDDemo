using DotNet20Demo;
using System;
using System.IO;
using Xunit;

namespace TestProject
{
    public class FizzBuzzTest
    {

        [Fact]
        public void Should_Return_1_For_Input_1()
        {
            string result = FizzBuzz.Convert(1);

            Assert.Equal("1", result);
        }

        [Fact]
        public void Should_Return_2_For_Input_2()
        {
            string result = FizzBuzz.Convert(2);

            Assert.Equal("2", result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        public void Should_Return_Fizz_For_Input_Divisable_With_3(int number)
        {
            string result = FizzBuzz.Convert(number);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_Return_Buzz_For_Input_5()
        {
            string result = FizzBuzz.Convert(5);

            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Should_Return_FizzBuzz_For_Input_15()
        {
            string result = FizzBuzz.Convert(15);

            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void Output()
        {
            TextWriter text = new StringWriter();
            Console.SetOut(text);
            //Call some method printing to Console
            Console.Write("FizzBuzz");

            Assert.Equal("FizzBuzz", text.ToString());

            //Clean up, change standard output to console again.
            var standardOut = new StreamWriter(Console.OpenStandardOutput());
            standardOut.AutoFlush = true;
            Console.SetOut(standardOut);
        }


    }
}

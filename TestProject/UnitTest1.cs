using DotNet20Demo;
using System;
using System.Diagnostics;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact(DisplayName ="Calling Greet with a name should return Hello name")]
        public void Greet_Should_Return_Hello_Martin()
        {
            Greeting greeting = new Greeting();

            var result = greeting.Greet("Martin");

            Assert.Equal("Hello Martin", result);
        }

        [Fact]
        public void Greet_Should_Return_HELLO_KALLE()
        {
            Greeting greeting = new Greeting();

            var result = greeting.Greet("KALLE");

            Assert.Equal("HELLO KALLE", result);
        }

        [Fact]
        public void Greet_Should_Return_HELLO_ULLA()
        {
            Greeting greeting = new Greeting();

            var result = greeting.Greet("ULLA");

            Assert.Equal("HELLO ULLA", result);
        }

        [Fact]
        public void Greet_Should_Throw_Exception_For_Number_As_Name()
        {
            Greeting greeting = new Greeting();

            Assert.Throws<ArgumentException>(()=>greeting.Greet("1"));
        }

        [Fact]
        public void Greet_Should_Throw_Exception_For_Numbers_In_Name()
        {
            Greeting greeting = new Greeting();

            Assert.Throws<ArgumentException>(() => greeting.Greet("A1B"));
        }



    }
}
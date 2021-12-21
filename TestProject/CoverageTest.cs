using DotNet20Demo;
using Xunit;

namespace TestProject
{
    public class CoverageTest
    {
        [Fact]
        public void When_value_is_over_0_returns_value()
        {
            Coverage coverage = new Coverage();

            var result = coverage.MethodThatDoesSomething(1);

            Assert.Equal(1, result);
        }

        [Fact]
        public void When_value_is_less_than_0_returns_0()
        {
            Coverage coverage = new Coverage();

            var result = coverage.MethodThatDoesSomething(-1);

            Assert.Equal(0, result);
        }

    }
}

using DotNet20Demo;
using Xunit;

namespace TestProject
{
    public class CoverageTest
    {
        [Fact]
        public void Greater_than_zero_is_unmodified()
        {
            Coverage coverage = new Coverage();

            var result = coverage.TruncateNegativeValueToZero(1);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Negative_number_is_modified_to_zero()
        {
            Coverage coverage = new Coverage();

            var result = coverage.TruncateNegativeValueToZero(-1);

            Assert.Equal(0, result);
        }

    }
}

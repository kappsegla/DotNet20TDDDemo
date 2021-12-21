namespace DotNet20Demo
{
    internal class Coverage
    {


        public int TruncateNegativeValueToZero(int value)
        {
            if (value <= 0)
                return 0;
            else
                return value;
        }
    }
}

namespace DotNet20Demo
{
    public class FizzBuzz
    {
        internal static string Convert(int number)
        {
            string answer = "";

            if (number % 3 == 0)
                answer += "Fizz";
            if (number % 5 == 0)
                answer += "Buzz";
            return answer != "" ?
                answer :
                number.ToString();

           /* return (number % 3, number % 5) switch
            {
                (0, 0) => "FizzBuzz",
                (0, _) => "Fizz",
                (_, 0) => "Buzz",
                (_, _) => number.ToString()
            };*/
        }
    }
}
using System.Diagnostics;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestProject")]
namespace DotNet20Demo
{
    public class Greeting
    {
        public string Greet(string name)
        {
            if (ContainsNumber(name))
                throw new ArgumentException();
            if (IsUpperCase(name))
                return "HELLO " + name;
            return "Hello " + name;
        }

        private bool ContainsNumber(string name)
        {
            foreach (char c in name)
                if (char.IsDigit(c))
                    return true;
            return false;
        }

        private bool IsUpperCase(string name)
        {
            if(name == name.ToUpper())
                return true;
            return false;
            /*
            foreach (char c in name)
                if (char.IsLower(c))
                    return false;
            return true;*/
        }
    }
}

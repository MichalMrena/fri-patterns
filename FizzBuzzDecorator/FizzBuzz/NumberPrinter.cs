using System.Text;

namespace FizzBuzz
{
    /// <summary>
    /// Basic class whose behaviour is to be decorated.
    /// This one only prints given number to given StringBuilder.
    /// </summary>
    public class NumberPrinter : IPrinter
    {
        public void Print(StringBuilder sb, int num)
        {
            sb.Append(num + "\n");
        }
    }
}
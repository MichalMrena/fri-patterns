using System.Text;

namespace FizzBuzz
{
    /// <summary>
    /// This class ensures that the instance of the 'basic class' only gets
    /// called if none of previous rules printed anything.
    /// </summary>
    public class FallbackDecorator : PrinterDecorator
    {
        public FallbackDecorator(IPrinter next) : base(next)
        {
        }

        public override void Print(StringBuilder sb, int num)
        {
            if (sb.IsEmpty())
            {
                CallNext(sb, num);
            }
            else
            {
                sb.Append("\n");
            }
        }

        protected override void Process(StringBuilder sb, int num)
        {
        }
    }
}
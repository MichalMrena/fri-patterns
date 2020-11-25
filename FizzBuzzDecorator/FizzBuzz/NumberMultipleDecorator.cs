using System.Text;

namespace FizzBuzz
{
    /// <summary>
    /// This class implements the actual 'FizzBuzzing', it prints
    /// the text from the rule if given number is multiple of the number
    /// from the rule.
    /// </summary>
    public class NumberMultipleDecorator : PrinterDecorator
    {
        private readonly Rule _rule;

        public NumberMultipleDecorator(Rule rule, IPrinter next) : base(next)
        {
            _rule = rule;
        }

        protected override void Process(StringBuilder sb, int num)
        {
            if (num % _rule.Num == 0)
            {
                sb.Append(_rule.Text);
            }
        }
    }
}
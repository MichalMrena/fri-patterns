using System.Text;

namespace FizzBuzz
{
    /// <summary>
    /// Base class for all decorators. Manages linking of multiple decorators
    /// using reference to the next decorator.
    /// </summary>
    public abstract class PrinterDecorator : IPrinter
    {
        private readonly IPrinter _next;

        protected PrinterDecorator(IPrinter next)
        {
            _next = next;
        }

        public virtual void Print(StringBuilder sb, int num)
        {
            Process(sb, num);
            CallNext(sb, num);
        }

        protected void CallNext(StringBuilder sb, int num)
        {
            _next.Print(sb, num);
        }

        protected abstract void Process(StringBuilder sb, int num);
    }
}
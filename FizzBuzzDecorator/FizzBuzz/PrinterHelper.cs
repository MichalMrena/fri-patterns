using System.Text;

namespace FizzBuzz
{
    /// <summary>
    /// Hides overhead with StringBuilder and returns simple string.
    /// </summary>
    public class PrinterHelper
    {
        private readonly IPrinter _printer;

        public PrinterHelper(IPrinter printer)
        {
            _printer = printer;
        }

        public string Print(int num)
        {
            var sb = new StringBuilder();
            _printer.Print(sb, num);
            return sb.ToString();
        }

    }
}
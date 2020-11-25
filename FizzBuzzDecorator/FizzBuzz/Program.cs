using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    internal class Program
    {
        private static void Main()
        {
            var rules = new[] {new Rule(3, "Fizz"), new Rule(5, "Buzz") };
            var printer = CreatePrinterHelper(rules);

            for (var i = 1; i <= 100; ++i)
            {
                Console.Write($"{i} : {printer.Print(i)}");
            }
        }

        private static IPrinter CreateMultipleDecorated(IPrinter prev, Rule rule)
        {
            return new NumberMultipleDecorator(rule, prev);
        }

        private static PrinterHelper CreatePrinterHelper(IEnumerable<Rule> rules)
        {
            var fallback = new FallbackDecorator(new NumberPrinter()) as IPrinter;
            return new PrinterHelper(rules.Reverse().Aggregate(fallback, CreateMultipleDecorated));
        }
    }
}

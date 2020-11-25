using System.Text;

namespace FizzBuzz
{
    public interface IPrinter
    {
        void Print(StringBuilder sb, int num);
    }
}
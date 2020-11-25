using System.Text;

namespace FizzBuzz
{
    public static class StringBuilderExtensions
    {
        /// <summary>
        /// Checks if the builder contains no characters.
        /// </summary>
        /// <param name="sb">StringBuilder to check</param>
        /// <returns>true if the builder contains no characters.</returns>
        public static bool IsEmpty(this StringBuilder sb)
        {
            return sb.Length == 0;
        }
    }
}
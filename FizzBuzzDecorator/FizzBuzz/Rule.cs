namespace FizzBuzz
{
    public class Rule
    {
        public int Num { get; }
            
        public string Text { get; }

        public Rule(int num, string text)
        {
            Num = num;
            Text = text;
        }
    }
}
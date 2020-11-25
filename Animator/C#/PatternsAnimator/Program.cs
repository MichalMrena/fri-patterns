using System;
using PatternsAnimator.Client;
using PatternsAnimator.Lib;
using PatternsAnimator.Utils;

namespace PatternsAnimator
{
    internal class Program
    {
        private static void Main()
        {
            var square = new Square();
            var move   = EffectFactory.Instance.MakeMove(square, new Point(10, 10));
            var rotate = EffectFactory.Instance.MakeRotate(square, Math.PI / 3);
            var effect = new CompositeEffect<Square>();
            effect.AddPart(move);
            effect.AddPart(rotate);

            Console.WriteLine(square);
            effect.Animate(square);
            Console.WriteLine(square);
        }
    }
}

using System;
using PatternsAnimator.Utils;

namespace PatternsAnimator.Lib
{
    public sealed class EffectFactory
    {
        private static readonly Lazy<EffectFactory> Lazy = new Lazy<EffectFactory>(() => new EffectFactory());

        public static EffectFactory Instance => Lazy.Value;

        private EffectFactory()
        {
        }

        public IEffect<T> MakeMove<T>(T _, Point p) where T : IMovable
        {
            return (IEffect<T>) new Mover(p);
        }

        public IEffect<T> MakeRotate<T>(T _, double angle) where T : IRotateable
        {
            return (IEffect<T>) new Rotator(angle);
        }
    }
}
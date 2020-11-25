using System.Collections.Generic;

namespace PatternsAnimator.Lib
{
    public class CompositeEffect<T> : EffectBase<T>
    {
        private readonly List<IEffect<T>> _parts;

        public CompositeEffect()
        {
            _parts = new List<IEffect<T>>();
        }

        public void AddPart(IEffect<T> e)
        {
            _parts.Add(e);
        }

        public override void Animate(T o)
        {
            foreach (var part in _parts)
            {
                part.Animate(o);
            }
        }

        protected override void DoAnimation(T o)
        {
        }
    }
}
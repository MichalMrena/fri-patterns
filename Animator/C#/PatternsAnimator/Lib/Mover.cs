using PatternsAnimator.Utils;

namespace PatternsAnimator.Lib
{
    public class Mover : EffectBase<IMovable>
    {
        private readonly Point _p;

        public Mover(Point p)
        {
            _p = p;
        }

        protected override void DoAnimation(IMovable o)
        {
            o.SetPosition(_p);
        }
    }
}
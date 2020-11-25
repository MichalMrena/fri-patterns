namespace PatternsAnimator.Lib
{
    public class Rotator : EffectBase<IRotateable>
    {
        private readonly double _angle;

        public Rotator(double angle)
        {
            _angle = angle;
        }

        protected override void DoAnimation(IRotateable o)
        {
            o.SetAngle(_angle);
        }
    }
}
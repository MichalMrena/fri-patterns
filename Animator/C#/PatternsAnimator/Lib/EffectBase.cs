namespace PatternsAnimator.Lib
{
    public abstract class EffectBase<T> : IEffect<T>
    {
        public virtual void Animate(T o)
        {
            if (o != null)
            {
                DoAnimation(o);
            }
        }

        protected abstract void DoAnimation(T o);
    }
}
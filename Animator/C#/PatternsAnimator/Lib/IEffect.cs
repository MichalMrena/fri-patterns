namespace PatternsAnimator.Lib
{
    public interface IEffect<in T>
    {
        void Animate(T o);
    }
}
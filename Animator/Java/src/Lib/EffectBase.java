package Lib;

public abstract class EffectBase<T> implements IEffect<T> {
    @Override
    public void animate(T o) {
        if (o != null) {
            this.doAnimation(o);
        }
    }

    protected abstract void doAnimation(T o);
}

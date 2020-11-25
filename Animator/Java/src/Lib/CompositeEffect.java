package Lib;

import java.util.ArrayList;
import java.util.List;

public class CompositeEffect<T> extends EffectBase<T> {
    private final List<IEffect<T>> parts;

    public CompositeEffect() {
        this.parts = new ArrayList<>();
    }

    public void addPart(IEffect<T> e) {
        this.parts.add(e);
    }

    @Override
    public void animate(T o) {
        for (var p : this.parts) {
            p.animate(o);
        }
    }

    @Override
    protected void doAnimation(T o) {
    }
}

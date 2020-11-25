package Lib;

import Utils.Point;

public class Mover extends EffectBase<IMovable> {
    private final Point position;

    public Mover(Point position) {
        this.position = position;
    }

    @Override
    protected void doAnimation(IMovable o) {
        o.setPosition(this.position);
    }
}

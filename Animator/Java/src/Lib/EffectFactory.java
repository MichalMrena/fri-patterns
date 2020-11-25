package Lib;

import Utils.Point;

public class EffectFactory {
    private static EffectFactory instance;

    public static EffectFactory getInstance() {
        if (null == instance) {
            instance = new EffectFactory();
        }

        return instance;
    }

    private EffectFactory() {
    }

    public <T extends IMovable> IEffect<T> makeMove(T o, Point p) {
        return (IEffect<T>) new Mover(p);
    }

    public <T extends IRotatable> IEffect<T> makeRotate(T o, double angle) {
        return (IEffect<T>) new Rotator(angle);
    }
}

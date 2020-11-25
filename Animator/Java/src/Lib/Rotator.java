package Lib;

public class Rotator extends EffectBase<IRotatable> {
    private final double angle;

    public Rotator(double angle) {
        this.angle = angle;
    }

    @Override
    protected void doAnimation(IRotatable o) {
        o.setAngle(this.angle);
    }
}

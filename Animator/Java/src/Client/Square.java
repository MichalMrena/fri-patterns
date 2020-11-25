package Client;

import Lib.IMovable;
import Lib.IRotatable;
import Utils.Point;

public class Square implements IMovable, IRotatable {
    private Point p;
    private double angle;

    public Square() {
        this.p     = new Point(0, 0);
        this.angle = 0.0;
    }

    @Override
    public void setPosition(Point p) {
        this.p = p;
    }

    @Override
    public void setAngle(double a) {
        this.angle = a;
    }

    @Override
    public String toString() {
        return "Square{" +
                "p=" + p +
                ", angle=" + angle +
                '}';
    }
}

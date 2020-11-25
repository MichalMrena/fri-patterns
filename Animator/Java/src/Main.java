import Client.Square;
import Lib.CompositeEffect;
import Lib.EffectFactory;
import Utils.Point;

public class Main {
    public static void main(String[] args) {
        var square = new Square();
        var move   = EffectFactory.getInstance().makeMove(square, new Point(10, 10));
        var rotate = EffectFactory.getInstance().makeRotate(square,Math.PI / 3);
        var effect = new CompositeEffect<Square>();
        effect.addPart(move);
        effect.addPart(rotate);

        System.out.println(square);
        effect.animate(square);
        System.out.println(square);
    }
}

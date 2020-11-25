using PatternsAnimator.Lib;
using PatternsAnimator.Utils;

namespace PatternsAnimator.Client
{
    public class Square : IMovable, IRotateable
    {
        private Point _position;
        private double _angle;

        public Square()
        {
            _position = new Point(0, 0);
            _angle = 0;
        }

        public void SetPosition(Point p)
        {
            _position = p;
        }

        public void SetAngle(double a)
        {
            _angle = a;
        }

        public override string ToString()
        {
            return $"Square: x = {_position.X}, y = {_position.Y}, angle = {_angle}";
        }
    }
}
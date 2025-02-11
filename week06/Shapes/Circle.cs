namespace Shapes
{
    public class Circle : Shape
    {
        private double _radius;

        //Construcor
        public Circle(string color, double radius) : base(color)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return _radius * _radius * 3.1415;
        }
    }
}
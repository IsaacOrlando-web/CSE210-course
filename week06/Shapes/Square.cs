namespace Shapes
{
    public class Square : Shape
    {
        private double _side;

        //GetSide
        public double GetSide()
        {
            return _side;
        } 

        //Constructor
        public Square(string color, double side) : base (color)
        {
            _side = side; 
        }

        public override double GetArea()
        {
            return _side * _side;
        }
    }
}
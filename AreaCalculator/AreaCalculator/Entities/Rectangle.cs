using AreaCalculator.Entities.Enums;

namespace AreaCalculator.Entities
{
    internal class Rectangle : Shape
    {
        public double Whidth { get; set; }
        public double Height { get; set; }

        public Rectangle(double whidth, double height, Color color) : base(color)
        {
            Whidth = whidth;
            Height = height;
        }

        public override double Area()
        {
            return Height * Whidth;
        }
    }
}

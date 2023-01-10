namespace FiguresLib
{
    public class Circle : Figure
    {
        public double radius { get; set; }
        public Circle(double r)
        {
            radius = r;
        }
        public override double GetArea()
        {
            Area = Math.PI * Math.Pow(radius, 2);
            return Area;
        }
        public override double GetPerimeter()
        {
            Perimeter = 2 * Math.PI * radius;
            return Perimeter;
        }
    }
}

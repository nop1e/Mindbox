namespace FiguresLib
{
    public class Figure
    {
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public virtual double GetArea()
        {
            return Area;
        }
        public virtual double GetPerimeter()
        {
            return Perimeter;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Area is: " + Math.Round(GetArea(), 4));
            Console.WriteLine("Perimeter is: " + Math.Round(GetPerimeter(), 4));
        }
    }
}
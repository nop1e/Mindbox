using FiguresLib;

namespace TestMindbox
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (0)
            {
                //triangle case
                case 1:
                    try
                    {
                        Console.Write("Input A Side: ");
                        double aSide = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Input B Side: ");
                        double bSide = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Input C Side: ");
                        double cSide = Convert.ToDouble(Console.ReadLine());
                        Triangle triangle = new Triangle(aSide, bSide, cSide);
                        triangle.DisplayInfo();
                        goto default;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Input correct values.");
                        goto case 1;
                    }

                //circle case
                case 2:
                    try
                    {
                        Console.Write("Input radius of a circle: ");
                        double r = Convert.ToDouble(Console.ReadLine());
                        Circle circle = new Circle(r);
                        circle.DisplayInfo();
                        goto default;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Input correct values.");
                        goto case 2;
                    }

                //unknown figure case
                case 3:
                    Console.Write("How many values figure have: ");
                    int sides = Convert.ToInt32(Console.ReadLine());
                    if (sides == 1)
                    {
                        Console.WriteLine("Maybe, it's a circle...");
                        goto case 2;
                    }

                    if (sides == 2)
                    {
                        Console.WriteLine("Not available for score.\n");
                        goto case 3;
                    }

                    if (sides == 3)
                    {
                        Console.WriteLine("Maybe, it's a triangle...");
                        goto case 1;
                    }

                    if (sides == 4)
                    {

                    }

                    goto default;

                default:
                    Console.WriteLine("\n1. Triangle");
                    Console.WriteLine("2. Circle");
                    Console.WriteLine("3. Unknown figure\n");
                    Console.Write("Enter the number: ");
                    try
                    {
                        int m = Convert.ToInt32(Console.ReadLine());
                        if (m == 0)
                            goto default;
                        if (m == 1)
                            goto case 1;
                        if (m == 2)
                            goto case 2;
                        if (m == 3)
                            goto case 3;

                        if (m > 3 || m < 1)
                        {
                            Console.WriteLine("\nInput correct number.");
                            goto default;
                        }

                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nInput correct number.");
                        goto default;
                    }
            }
        }
    }
}
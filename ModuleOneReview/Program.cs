namespace ModuleOneReview;
//  Write a program to find the area of a circle, triangle, rectangle, and square.
//  Area of circle 3.14*r*r....A=πr2
//  Area of triangle: A = 1/2 × b × h.
//  Area of a rectangle: A=wl
//  Area of a square A=a2


class Program
{
   
    public static double CircleArea(double radius)
    {
        return Math.PI * Math.Pow(radius,2);
    }

    public static double TriangelArea(double baseOfTri, double height)
    {
        return 0.5 * baseOfTri * height;
    }

    public static double RectangleArea(double length, double width)
    {
        return length * width;
    }

    public static double SquareArea( double side)
    {
        return Math.Pow(side,2); 
    }

    static void Main(string[] args)
    {

        string answer;

        Console.WriteLine("Hello!  What shape would you like to find the area of? 'C' Circle, 'T' Triangle, 'R' Rectangle, and 'S' Square");

        answer = Console.ReadLine();

        if (answer == "R")
        {
            Console.WriteLine("Please enter the length of the rectangle.");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enther the width!");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine(RectangleArea(length, width));
        }
        else if (answer == "C")
        {
            Console.WriteLine("Please enter the radius of the circle.");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine(CircleArea(radius));
        }
        else if (answer == "T")
        {
            Console.WriteLine("Please enter the base!");
            double baseOfTri = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the height of the triangle!");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(TriangelArea(baseOfTri, height));
        }
        else if (answer == "S")
        {
            Console.WriteLine("Please enter the value of the side of the square!");
            double side = double.Parse(Console.ReadLine());

            Console.WriteLine(SquareArea(side));
        }
        else
        {
            Console.WriteLine("Oops wrong answer! Please reenter a correct choice from options!");
        }
    }
}




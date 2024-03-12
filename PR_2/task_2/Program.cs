using System;

class Program
{
    static void Main(string[] args)
    {
        double side1, side2, side3;

        Console.WriteLine("Enter first side:");
        side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second side:");
        side2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter third side:");
        side3 = Convert.ToDouble(Console.ReadLine());

        if (IsValidTriangle(side1, side2, side3))
        {
            double perimeter = CalculatePerimeter(side1, side2, side3);
            Console.WriteLine($"Perimeter: {perimeter}");

            double area = CalculateArea(side1, side2, side3);
            Console.WriteLine($"Area: {area}");

            string triangleType = DetermineTriangleType(side1, side2, side3);
            Console.WriteLine($"Triangle Type {triangleType}");
        }
        else
        {
            Console.WriteLine("Triangle does not exist");
        }

        Console.ReadLine();
    }

    static bool IsValidTriangle(double side1, double side2, double side3)
    {
        return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
    }

    static double CalculatePerimeter(double side1, double side2, double side3)
    {
        return side1 + side2 + side3;
    }

    static double CalculateArea(double side1, double side2, double side3)
    {
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }

    static string DetermineTriangleType(double side1, double side2, double side3)
    {
        if (side1 == side2 && side2 == side3)
        {
            return "equilateral";
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            return "isoscalic";
        }
        else
        {
            return "notEquilateral";
        }
    }
}

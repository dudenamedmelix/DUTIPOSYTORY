using System;

class Program
{
    static void Main(string[] args)
    {
        int num1, num2, num3;


        Console.WriteLine("Enter first number:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter third number:");
        num3 = Convert.ToInt32(Console.ReadLine());


        SelectNumbersInInterval(num1, num2, num3);

        Console.ReadLine();
    }

    static void SelectNumbersInInterval(int num1, int num2, int num3)
    {

        if (num1 >= 1 && num1 <= 11)
        {
            Console.WriteLine($"Number {num1} located in [1, 10+26]");
        }

        if (num2 >= 1 && num2 <= 11)
        {
            Console.WriteLine($"Number {num2} located in [1, 10+26]");
        }

        if (num3 >= 1 && num3 <= 11)
        {
            Console.WriteLine($"Number  {num3}  located in [1, 10+26]");
        }
    }
}

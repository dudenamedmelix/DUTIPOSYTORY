using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arrayX = { -3, 7, 0, -5, 12, -8, 6, -10, 4, 9, -2, 13, 14, -12, -17, 16, 17 };

        Console.WriteLine("Array X:");
        PrintArray(arrayX);

        Console.WriteLine("Enter Module M:");
        int M = Convert.ToInt32(Console.ReadLine());

        int[] arrayY = GenerateArrayY(arrayX, M);
        Console.WriteLine($"Module M: {M}");
        Console.WriteLine("New Array Y:");
        PrintArray(arrayY);

        Console.ReadLine();
    }

    static void PrintArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }


    static int[] GenerateArrayY(int[] arrX, int M)
    {
        int[] arrY = new int[arrX.Length];
        int yIndex = 0;

        foreach (int element in arrX)
        {
            if (Math.Abs(element) > M)
            {
                arrY[yIndex++] = element;
            }
        }

        Array.Resize(ref arrY, yIndex);

        return arrY;
    }
}

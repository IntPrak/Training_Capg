using System;

class TwoDToOneD
{
    static void Main()
    {
        Console.Write("Enter rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];
        int[] array = new int[rows * cols];
        int index = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("Enter element: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
                array[index++] = matrix[i, j];
            }
        }

        Console.WriteLine("1D Array:");
        for (int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");
    }
}

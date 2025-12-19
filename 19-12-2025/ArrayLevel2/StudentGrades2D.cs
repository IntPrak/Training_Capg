using System;

class StudentGrades2D
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        double[,] marks = new double[n, 3];
        double[] percentage = new double[n];
        string[] grade = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter Physics, Chemistry, Maths: ");
            marks[i, 0] = double.Parse(Console.ReadLine());
            marks[i, 1] = double.Parse(Console.ReadLine());
            marks[i, 2] = double.Parse(Console.ReadLine());

            percentage[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3;

            grade[i] = percentage[i] >= 90 ? "A" :
                       percentage[i] >= 75 ? "B" :
                       percentage[i] >= 60 ? "C" : "D";
        }

        for (int i = 0; i < n; i++)
            Console.WriteLine("Percentage: " + percentage[i] + " Grade: " + grade[i]);
    }
}

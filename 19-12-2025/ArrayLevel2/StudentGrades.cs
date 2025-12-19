using System;

class StudentGrades
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        double[] percentage = new double[n];
        string[] grade = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter Physics, Chemistry, Maths: ");
            double p = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());

            if (p < 0 || c < 0 || m < 0)
            {
                Console.WriteLine("Invalid marks");
                i--;
                continue;
            }

            percentage[i] = (p + c + m) / 3;

            grade[i] = percentage[i] >= 90 ? "A" :
                       percentage[i] >= 75 ? "B" :
                       percentage[i] >= 60 ? "C" : "D";
        }

        for (int i = 0; i < n; i++)
            Console.WriteLine("Percentage: " + percentage[i] + " Grade: " + grade[i]);
    }
}

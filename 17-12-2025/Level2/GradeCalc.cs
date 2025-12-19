using System;

class GradeCalculation
{
    static void Main()
    {
        Console.Write("Enter Physics marks: ");
        double physics = double.Parse(Console.ReadLine());

        Console.Write("Enter Chemistry marks: ");
        double chemistry = double.Parse(Console.ReadLine());

        Console.Write("Enter Maths marks: ");
        double maths = double.Parse(Console.ReadLine());

        double average = (physics + chemistry + maths) / 3;

        string grade;
        string remarks;

        if (average >= 90)
        {
            grade = "A";
            remarks = "Excellent";
        }
        else if (average >= 75)
        {
            grade = "B";
            remarks = "Very Good";
        }
        else if (average >= 60)
        {
            grade = "C";
            remarks = "Good";
        }
        else
        {
            grade = "D";
            remarks = "Needs Improvement";
        }

        Console.WriteLine("Average Mark = " + average);
        Console.WriteLine("Grade = " + grade + ", Remarks = " + remarks);
    }
}

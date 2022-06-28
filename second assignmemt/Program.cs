using System;

namespace Program
{
    class First
    {
        static void Main(String[] args)
        {
            Console.Write("Enter number of subjects: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            double mark, average, total = 0;
            for (int i = 0; i < amount; i++)
            {
                Console.Write("Enter the mark of Subject " + (i + 1) + ": ");
                mark = Convert.ToDouble(Console.ReadLine());
                total += mark;
            }
            average = total / amount;
            Console.WriteLine("Your average is: " + average);

            char grade;
            if (average >= 90 & average <= 100)
                grade = 'A';
            else if (average >= 80 & average < 90)
                grade = 'B';
            else if (average >= 70 & average < 80)
                grade = 'C';
            else if (average >= 50 & average < 70)
                grade = 'D';
            else
                grade = 'F';
            Console.WriteLine("Your grade is: " + grade);
        }
    }
}
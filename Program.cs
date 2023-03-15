using System;
namespace U5_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration of the one-dimensional array to store names and identification numbers
            string[] students = new string[5];

            // Declaration of the multidimensional array to store the grades for each student
            int[,] grades = new int[5, 4];

            // Ask the user to input data for each student
            for (int i = 0; i < students.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Enter name and identification number for student " + (i + 1) + ":");
                students[i] = Console.ReadLine();

                for (int j = 0; j < grades.GetLength(1); j++)
                {
                    Console.WriteLine("Enter grade for subject " + (j + 1) + " for student " + (i + 1) + ":");
                    grades[i, j] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine();
            }

            // Calculate the average grade for each student
            double[] averages = new double[5];
            for (int i = 0; i < students.Length; i++)
            {
                double sum = 0;
                for (int j = 0; j < grades.GetLength(1); j++)
                {
                    sum += grades[i, j];
                }
                averages[i] = sum / grades.GetLength(1);
            }

            // Print the names, identification numbers, grades, and average grades for each student in a table
            Console.WriteLine("|{0,-20}|{1,-10}|{2,-10}|{3,-10}|{4,-10}|{5,-10}|", "Student", "Subject 1", "Subject 2", "Subject 3", "Subject 4", "Final Average");

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("|{0,-20}|{1,-10}|{2,-10}|{3,-10}|{4,-10}|{5,-10}   |", students[i], grades[i, 0], grades[i, 1], grades[i, 2], grades[i, 3], averages[i]);
            }
            Console.ReadKey();
        }
    }
}

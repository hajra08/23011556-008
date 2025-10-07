using System;

namespace VisualProgrammingAssignment
{
    public class GradeEvaluator
    {
        public void Evaluate()
        {
            Console.Write("Enter marks (0–100): ");
            if (int.TryParse(Console.ReadLine(), out int marks))
            {
                if (marks >= 85) Console.WriteLine("Grade: A");
                else if (marks >= 70) Console.WriteLine("Grade: B");
                else if (marks >= 55) Console.WriteLine("Grade: C");
                else if (marks >= 40) Console.WriteLine("Grade: D");
                else Console.WriteLine("Grade: F");
            }
            else Console.WriteLine("Invalid input!");
        }
    }
}

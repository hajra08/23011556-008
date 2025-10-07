using System;

namespace VisualProgrammingAssignment
{
    public class Factorial
    {
        public void Calculate()
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                long fact = 1;
                for (int i = 1; i <= n; i++) fact *= i;
                Console.WriteLine($"{n}! = {fact}");
            }
            else Console.WriteLine("Invalid input!");
        }
    }
}

using System;

namespace VisualProgrammingAssignment
{
    public class SumOfNumbers
    {
        public void CalculateSum()
        {
            Console.Write("Enter n: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int sum = 0;
                for (int i = 1; i <= n; i++) sum += i;
                Console.WriteLine($"Sum = {sum}");
            }
            else Console.WriteLine("Invalid input!");
        }
    }
}

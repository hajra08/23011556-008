using System;

namespace VisualProgrammingAssignment
{
    public class MultiplicationTable
    {
        public void PrintTable()
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                for (int i = 1; i <= 10; i++)
                    Console.WriteLine($"{n} x {i} = {n * i}");
            }
            else Console.WriteLine("Invalid input!");
        }
    }
}

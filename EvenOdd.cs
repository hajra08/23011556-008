using System;

namespace VisualProgrammingAssignment
{
    public class EvenOdd
    {
        public void Check()
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int n))
                Console.WriteLine(n % 2 == 0 ? $"{n} is Even." : $"{n} is Odd.");
            else
                Console.WriteLine("Invalid input!");
        }
    }
}
using System;

namespace VisualProgrammingAssignment
{
    public class ReverseNumber
    {
        public void Reverse()
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                int rev = 0;
                while (num != 0)
                {
                    rev = rev * 10 + num % 10;
                    num /= 10;
                }
                Console.WriteLine($"Reversed number: {rev}");
            }
            else Console.WriteLine("Invalid input!");
        }
    }
}

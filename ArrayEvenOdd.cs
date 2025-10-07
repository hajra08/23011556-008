using System;

namespace VisualProgrammingAssignment
{
    public class ArrayEvenOdd
    {
        public void Count()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            int even = 0, odd = 0;
            foreach (int n in arr)
            {
                if (n % 2 == 0) even++;
                else odd++;
            }

            Console.WriteLine($"Even count = {even}, Odd count = {odd}");
        }
    }
}

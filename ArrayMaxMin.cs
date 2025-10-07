using System;

namespace VisualProgrammingAssignment
{
    public class ArrayMaxMin
    {
        public void Find()
        {
            int[] arr = ReadArray();
            if (arr == null) return;

            int max = arr[0], min = arr[0];
            foreach (int n in arr)
            {
                if (n > max) max = n;
                if (n < min) min = n;
            }

            Console.WriteLine($"Max = {max}, Min = {min}");
        }

        private int[] ReadArray()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"[{i + 1}] = ");
                if (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.WriteLine("Invalid input!");
                    return null;
                }
            }
            return arr;
        }
    }
}

using System;

namespace VisualProgrammingAssignment
{
    public class ArraySearch
    {
        public void Search()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number to search: ");
            int key = Convert.ToInt32(Console.ReadLine());

            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    Console.WriteLine($"{key} found at index {i}");
                    found = true;
                    break;
                }
            }
            if (!found)
                Console.WriteLine($"{key} not found in array.");
        }
    }
}

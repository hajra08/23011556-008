using System;

namespace VisualProgrammingAssignment
{
    public class Calculator
    {
        public void Calculate()
        {
            Console.WriteLine("Select operation: 1.+ 2.- 3.* 4./");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            Console.Write("Enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case "1": Console.WriteLine($"Result = {a + b}"); break;
                case "2": Console.WriteLine($"Result = {a - b}"); break;
                case "3": Console.WriteLine($"Result = {a * b}"); break;
                case "4":
                    if (b == 0) Console.WriteLine("Cannot divide by zero!");
                    else Console.WriteLine($"Result = {a / b}");
                    break;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }
    }
}

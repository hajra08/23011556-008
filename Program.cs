using System;
using VisualProgrammingAssignment;

namespace ConsoleApp2   // ⚠ keep this the same as your project name
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("=== Visual Programming Assignment ===");
                Console.WriteLine("1. Even or Odd");
                Console.WriteLine("2. Simple Calculator");
                Console.WriteLine("3. Grade Evaluator");
                Console.WriteLine("4. Sum of Natural Numbers");
                Console.WriteLine("5. Multiplication Table");
                Console.WriteLine("6. Factorial");
                Console.WriteLine("7. Reverse Number");
                Console.WriteLine("8. Array Max/Min");
                Console.WriteLine("9. Array Even/Odd Count");
                Console.WriteLine("10. Array Search");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string ch = Console.ReadLine();
                Console.Clear();

                switch (ch)
                {
                    case "1": new EvenOdd().Check(); break;
                    case "2": new Calculator().Calculate(); break;
                    case "3": new GradeEvaluator().Evaluate(); break;
                    case "4": new SumOfNumbers().CalculateSum(); break;
                    case "5": new MultiplicationTable().PrintTable(); break;
                    case "6": new Factorial().Calculate(); break;
                    case "7": new ReverseNumber().Reverse(); break;
                    case "8": new ArrayMaxMin().Find(); break;
                    case "9": new ArrayEvenOdd().Count(); break;
                    case "10": new ArraySearch().Search(); break;
                    case "0": return;
                    default: Console.WriteLine("Invalid choice!"); break;
                }

                Console.WriteLine("\nPress Enter to return to menu...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}

using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");

            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition: " + (num1 / num2));
            Console.WriteLine("Subtraction: " + (num1 - num2));
            Console.WriteLine("Multiplication: " + (num1 / num2));

            if(num2 != 0)
            {
                Console.WriteLine("Division: " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed");
            }
        }
    }
}
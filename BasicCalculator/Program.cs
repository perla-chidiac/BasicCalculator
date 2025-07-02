using System;
using System.Reflection.Metadata.Ecma335;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Calculator");
            while (true) {
                try {
                    Console.Write("enter your first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("enter your second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("enter an operation ( + , - , * or /): ");
                    string op = Console.ReadLine();

                    double result = 0;

                    switch (op)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            result = num1 / num2;
                            break;
                        default:
                            Console.WriteLine("invalid operator");
                            continue;
                    }
                    Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter numbers only.\n");
                    continue;
                }
            }
        }
    }
}
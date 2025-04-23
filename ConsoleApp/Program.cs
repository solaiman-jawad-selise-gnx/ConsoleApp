using System;

namespace ConsoleApp
{
    public class Calculator
    {
        static int Compute(int a, int b)
        {
            Console.WriteLine(@"Pick Operand: 1: Add(+), 2: Subtract(-), 3: Multiply(*), 4: Divide(/)");
            ConsoleKey operand = Console.ReadKey().Key;
            switch (operand)
            {
                case ConsoleKey.Add:
                case ConsoleKey.D1:
                    return a + b;
                case ConsoleKey.Subtract:
                case ConsoleKey.D2:
                    return a - b;
                case ConsoleKey.Multiply:
                case ConsoleKey.D3:
                    return a * b;
                case ConsoleKey.Divide:
                case ConsoleKey.D4:
                    return a / b;
                default:
                    throw new ArgumentException("Invalid operation: "+operand);
            }
        }
        
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum; 
            int numtries = 3;

            while (numtries > 0)
            {
                try
                {
                    Console.WriteLine("First number:");
                    firstNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Second numeral:");
                    secondNum = Convert.ToInt32(Console.ReadLine());
                    int num = Calculator.Compute(firstNum, secondNum);
                    Console.WriteLine("\nYour Answer is: " + num);
                    return;
                }
                catch (Exception e)
                {
                    if (e is InvalidCastException)
                    {
                        Console.WriteLine("invalid numerals: " + e.Message);
                    }
                    else if (e is ArgumentException)
                    {
                        Console.WriteLine("invalid operand: " + e.Message);
                    }
                    else
                    {
                        Console.WriteLine(e.Message);
                    }
                    numtries--;
                    Console.WriteLine($"You have {numtries.ToString()} tries remaining");
                }
            }
            Console.WriteLine("Calculator is out of tries");
        }
    }

    
}
using System;

namespace ConsoleApp
{
    public class Application
    {

        static void Main(string[] args)
        {
            Operand firstNum = new Operand();
            Operand secondNum = new Operand();
            Calculator op = new Calculator();

            firstNum.OperandInputedCorrectly += op.OnCorrectOperandInputed;
            secondNum.OperandInputedCorrectly += op.OnCorrectOperandInputed;
            
            firstNum.ReadOperandFromIo();
            secondNum.ReadOperandFromIo();
            
            Console.WriteLine("\nYour Result is: " + op.Result);
        }
    }
}
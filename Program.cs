using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace prac46
{
    enum Operation
    {
        Add, Subtract, Multiply, Divide
    }
    internal class Program
    {
        double Calculate(double a, double b, Operation operation)
        {
            switch (operation)
            {
                case Operation.Add:
                    return a + b;
                case Operation.Subtract:
                    return a - b;
                case Operation.Multiply:
                    return a * b;
                case Operation.Divide:
                    if (b == 0)
                        throw new DivideByZeroException("Нельзя делить на ноль");
                    return a / b;
                default:
                    throw new ArgumentOutOfRangeException(nameof(operation), "Invalid operation.");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите операцию (Add, Subtract, Multiply, Divide):");
            string operationInput = Console.ReadLine();
            Operation operation;
            operation = (Operation)Enum.Parse(typeof(Operation), operationInput, true);
            Program program = new Program();
            double result;
            result = program.Calculate(firstNumber, secondNumber, operation);
            Console.WriteLine("Ответ: " + result);
        }
    }
}

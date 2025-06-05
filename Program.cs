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
        Администратор, Модератор, Пользователь, Гость
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вашу роль (Администратор, Модератор, Пользователь, Гость):");
            string input = Console.ReadLine();
            Operation userRole;
            if (Enum.TryParse(input, out userRole))
            {
                switch (userRole)
                {
                    case Operation.Администратор:
                        Console.WriteLine("Вы администратор");
                        break;
                    case Operation.Модератор:
                        Console.WriteLine("Вы модератор");
                        break;
                    case Operation.Пользователь:
                        Console.WriteLine("Вы пользователь");
                        break;
                    case Operation.Гость:
                        Console.WriteLine("Вы гость");
                        break;
                    default:
                        Console.WriteLine("Неизвестная роль");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Неизвестная роль");
            }
        }
    }
}

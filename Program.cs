using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace prac46
{
    enum Post
    {
        CEO,Manager,Worker
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Введите должность работника (CEO, Manager, Worker):");
            string input = Console.ReadLine();
            Post workerPost;
            if (!Enum.TryParse(input, true, out workerPost))
            {
                Console.WriteLine("Некорректная должность.");
                return;
            }
            Console.WriteLine("Введите количество отработанных часов:");
            int hours;
            if (!int.TryParse(Console.ReadLine(), out hours) || hours < 0)
            {
                Console.WriteLine("Некорректное количество часов.");
                return;
            }
            Accauntant accauntant = new Accauntant();
            accauntant.AskForBonus(workerPost, hours);

        }
    }
}

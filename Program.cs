using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace prac46
{
    internal class Program
    {
        enum Months
        {
            Январь,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }
        static void Main(string[] args)
        {
            //int count = -1;
            //foreach (var month in Enum.GetValues(typeof(Months)))
            //{
            //    count++;
            //    Console.WriteLine($"{count}\t{month.ToString()}");
            //}
            for(int i = 0; i < Enum.GetNames(typeof(Months)).Length; i++)
            {
                Console.WriteLine($"{i}\t{Enum.GetName(typeof(Months), i)}");
            }
        }
    }
}

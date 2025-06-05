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
        enum Days
        {
            Sat,Sun,Mon,Tue,Wed,Thu,Fri
        }
        static void Main(string[] args)
        {
            Days i;
            for (i = Days.Sat; i <= Days.Fri; i++)
            {
                Console.WriteLine(i + " имеет значение " + (int)i);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac46
{
    internal class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if(Post.CEO == worker && hours > 100)
            {
                Console.WriteLine("Вы можете получить премию!");
                return true;
            }
            else if(Post.Manager == worker && hours > 150)
            {
                Console.WriteLine("Вы можете получить премию!");
                return true;
            }
            else if(Post.Worker == worker && hours > 200)
            {
                Console.WriteLine("Вы можете получить премию!");
                return true;
            }
            else
            {
                Console.WriteLine("Вы не можете получить премию!");
                return false;
            }
        }
    }
}

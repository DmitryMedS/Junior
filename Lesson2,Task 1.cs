using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Дмитрий";
            Console.WriteLine("Сколько раз мне повторить твое имя");
            int countWrite;
            int canWorking = 0;
            countWrite = Convert.ToInt32(Console.ReadLine());
            while (canWorking<countWrite)
            {
                canWorking++;
                Console.WriteLine(name);
            }

            
        }
    }
}

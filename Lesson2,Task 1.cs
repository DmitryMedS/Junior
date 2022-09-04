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
            int countWrite;
            int isWork = 0;
            string name = "Дмитрий";
            Console.WriteLine("Сколько раз мне повторить твое имя");
            countWrite = Convert.ToInt32(Console.ReadLine());

            while (isWork < countWrite)
            {
                isWork++;
                Console.WriteLine(name);
            }
        }
    }
}

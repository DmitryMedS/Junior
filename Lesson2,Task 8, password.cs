using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isWorking= "";
            string completion = "exit";

            while (isWorking != completion)
            {
                Console.WriteLine("Программа выполняется");
                Console.WriteLine("Для выхода введите - exit");
                isWorking = Console.ReadLine();
            }
           Console.WriteLine("Программа завершена");
        }
    }
}

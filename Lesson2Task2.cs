using System;
namespace Lesson2.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isWorking= "";
            string exit = "exit";

            while (isWorking != completion)
            {
                Console.WriteLine("Программа выполняется \nДля выхода введите - exit");
                isWorking = Console.ReadLine();
            }
           Console.WriteLine("Программа завершена");
        }
    }
}

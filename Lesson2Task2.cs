using System;
namespace Lesson2.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput= "";
            string exit = "exit";

            while (userInput != exit)
            {
                Console.WriteLine("Программа выполняется \nДля выхода введите - exit");
                userInput = Console.ReadLine();
            }
            
           Console.WriteLine("Программа завершена");
        }
    }
}

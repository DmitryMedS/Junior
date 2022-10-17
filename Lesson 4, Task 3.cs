using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int number;
            bool isWorking = true;
            while (isWorking)
            {
                Console.WriteLine("Введите число");
                userInput= Console.ReadLine();
                bool isNumber = int.TryParse(userInput.ToString(), out number);
                if (isNumber)
                {
                    Console.WriteLine($"ваше число {number} Преобразовалось");
                    isWorking = false;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("  Вы ввели не число! Попробуйте еще");
                    Console.ReadLine();
                }
            }
        }
    }
}

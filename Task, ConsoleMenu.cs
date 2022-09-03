using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name ="";
            string color;
            string password ="";
            string writeName;
            string userInput;
            string control = "лох";
            while (control!="exit")
            {
                Console.WriteLine("Выберите команду:\n\nУстановить имя - SetName;\n" +
                    "Изменить цвет консоли - ChangeConsoleColor;\nУстановить пароль - SetPassword;\n" +
                    "Вывести имя - WriteName\nВыход из программы - Esc");
               userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "SetName":
                       name = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Имя установлено...");

                        break;
                    case "ChangeConsoleColor":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        break;
                    case "SetPassword":
                        password = Console.ReadLine();
                        Console.WriteLine("Пароль сохранен!");
                        break;
                    case "WriteName":
                        Console.WriteLine("Введите пароль!");
                        writeName = Console.ReadLine();

                        if (password == writeName)
                        {
                         Console.WriteLine(name);
                        }
                        else
                        {
                            Console.WriteLine("Неверный пароль");
                        }
                        
                        break;
                    case "Esc":
                        control = "exit";
                        break;

                }
                Console.WriteLine("Программа запвершена...");


            }
        }
        
    }
}

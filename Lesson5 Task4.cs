using System;
using System.Collections.Generic;
namespace DinamicList
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;

            Dictionary<string, string> people = new Dictionary<string, string>();

            people.Add("Шевчук Дмитрий Витальевич", "Программист");

            string names;
            string profesions;
            string deleteName;
            int userInput;

            Console.SetCursorPosition(15, 2);
            Console.WriteLine("Кадровый учет");

            while (isWork)
            {
                Console.WriteLine("\n\n\n1 - Добавить досье\n\n2 - Показать все досье\n\n3 - Удалить досье\n\n4 - Выход");
                Console.WriteLine("Выберите пункт меню");

                switch (userInput = Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Добавление досье\nВведите ФИО:\n");
                        names = Console.ReadLine();
                        Console.WriteLine("\n  Введите Профессию:\n");
                        profesions = Console.ReadLine();
                        people.Add(names, profesions);
                        break;

                    case 2:
                        foreach (var item in people)
                        {
                            Console.WriteLine($"ФИО - {item.Key}, должность -  {item.Value}.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Введите ФИО которое хотите удалить");
                        deleteName = Console.ReadLine();
                        people.Remove(deleteName);
                        break;

                    case 4:
                        isWork = false;
                        break;
                }

            }
        }
    }   
}    
        
        
        
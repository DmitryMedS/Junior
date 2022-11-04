using System;
using System.Collections.Generic;
namespace DinamicList
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            bool isWork = true;
            string userInput = null;
            int number;

            List<int> numbers = new List<int>();
            Console.WriteLine("Введите число что бы запомнить его\n"+
                "команда sum -  для вывода суммы чисел\nкоманда exit - выход из программы");

            while (isWork == true)
            { 
              userInput = Console.ReadLine();
                
                if(userInput == "sum") 
                { 
                     for(int i = 0;i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }

                        Console.WriteLine("Сумма эллементов = " + sum);
                }
                    else if(userInput == "exit")
                    {
                    isWork = false;
                    }
                else
                {
                    numbers.Add(Convert.ToInt32(userInput));
                }   
            }
        }
    }
}




using System;
using System.Collections.Generic;


namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> words = new Dictionary<string, string>();

            words.Add("черный", "белый");
            words.Add("сладкий", "соленый");
            words.Add("большой", "маленький");

            bool isWork = true;

            while (isWork == true)
            {
                Console.WriteLine("Введите слово");
                string word = Console.ReadLine();

                  if (words.ContainsKey(word))
                    {
                        Console.WriteLine(words[word]);
                    }

                   else
                   {
                       Console.WriteLine("неверное значение");
                       isWork = false;
                       break;
                   }
            }
        }
    }
}



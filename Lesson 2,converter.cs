using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rub;
            float usd;
            float euro;
            float cny;
            float rubToUsd = 60.2f;
            float usdToRub = 60.2f;
            float rubToEuro = 60.3f;
            float euroToRub = 60.3f;
            float rubToCny = 8.7f;
            float cnyToRub = 8.7f;
            float currencyCount;
            int userInput = 0;
            Console.WriteLine("количество рублей");
            rub = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("количество долларов");

            usd = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("количество евро");

            euro = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("количество юаней");

            cny = Convert.ToSingle(Console.ReadLine());
            bool control = true;
            while (control == true)
            {
                Console.WriteLine("Приветствую вас в нашем обменнике...");
            Console.WriteLine("1 - Обмен долларов на рубли");
            Console.WriteLine("2 - Обмен рублей на доллары");
            Console.WriteLine("3 - Обмен евро на рубли");
            Console.WriteLine("4 - Обмен рублей на евро");
            Console.WriteLine("5 - Обмен юаней на рубли");
            Console.WriteLine("6 - Обмен рублей на юани");
            Console.WriteLine("7 - Выход");
            userInput = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Обмен долларов на рубли");
                        Console.WriteLine("Сколько хотите обменять?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (usd >= currencyCount)
                        {
                            usd -= currencyCount; cny -= currencyCount;
                            rub += currencyCount * cnyToRub;
                            rub += currencyCount * usdToRub;
                        }
                        else
                        {
                            Console.WriteLine(" Недопустимое кол-во долларов.");
                        }
                        Console.WriteLine("Ваш баланс " + rub + " рублей " + usd + " долларов");

                        break;
                    case 2:
                        Console.WriteLine("Обмен рублей на доллары");
                        Console.WriteLine("Сколько хотите обменять?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rub >= currencyCount)
                        {
                            rub -= currencyCount;
                            usd += currencyCount / rubToUsd;
                        }
                        else
                        {
                            Console.WriteLine(" Недопустимое кол-во рублей.");
                        }
                        Console.WriteLine("Ваш баланс " + rub + " рублей " + usd + " долларов");

                        break;
                    case 3:
                        Console.WriteLine("Обмен евро на рубли");
                        Console.WriteLine("Сколько хотите обменять?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (euro >= currencyCount)
                        {
                            euro -= currencyCount;
                            rub += currencyCount * euroToRub;
                        }
                        else
                        {
                            Console.WriteLine(" Недопустимое кол-во долларов.");
                        }
                        Console.WriteLine("Ваш баланс " + rub + " рублей " + euro + " евро");

                        break;
                    case 4:
                        Console.WriteLine("Обмен рублей на евро");
                        Console.WriteLine("Сколько хотите обменять?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rub >= currencyCount)
                        {
                            rub -= currencyCount;
                            euro += currencyCount / rubToEuro;
                        }
                        else
                        {
                            Console.WriteLine(" Недопустимое кол-во рублей.");
                        }
                        Console.WriteLine("Ваш баланс " + rub + " рублей " + euro + " евро");

                        break;
                    case 5:
                        Console.WriteLine("Обмен юаней на рубли");
                        Console.WriteLine("Сколько хотите обменять?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (cny >= currencyCount)
                        {
                            cny -= currencyCount;
                            rub += currencyCount * cnyToRub;
                        }
                        else
                        {
                            Console.WriteLine(" Недопустимое кол-во долларов.");
                        }
                        Console.WriteLine("Ваш баланс " + rub + " рублей " + cny + " юаней");

                        break;
                    case 6:
                        Console.WriteLine("Обмен рублей на юани");
                        Console.WriteLine("Сколько хотите обменять?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rub >= currencyCount)
                        {
                            rub -= currencyCount;
                            cny += currencyCount / rubToCny;
                        }
                        else
                        {
                            Console.WriteLine(" Недопустимое кол-во рублей.");
                        }
                        Console.WriteLine("Ваш баланс " + rub + " рублей " + cny + " юаней");

                        break;
                    case 7:
                        control = false;
                        break;

                }
            }

        }
    }
}

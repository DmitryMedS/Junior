using System;
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
            int userInput;
            bool isWork = true;

            Console.WriteLine("количество рублей");
            rub = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("количество долларов");
            usd = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("количество евро");
            euro = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("количество юаней");
            cny = Convert.ToSingle(Console.ReadLine());
            
                while (isWork == true)
            {
                if (rub < 0 || usd < 0 || euro < 0 || cny < 0)
                {
                    Console.WriteLine("Такое колличество рублей быть не может!");
                    break;
                }
                Console.WriteLine("Приветствую вас в нашем обменнике...");
                Console.WriteLine("1 - Обмен долларов на рубли\n2 - Обмен рублей на доллары\n" +
                                  "3 - Обмен евро на рубли\n4 - Обмен рублей на евро\n" +
                                  "5 - Обмен юаней на рубли\n6 - Обмен рублей на юани\n7 - Выход");
                userInput = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Обмен долларов на рубли");
                        Console.WriteLine("Сколько хотите обменять?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                       
                        if (usd >= currencyCount && currencyCount >= 0)
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
                        Console.WriteLine("Обмен рублей на доллары\nСколько хотите обменять?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                       
                        if (rub >= currencyCount && currencyCount >= 0)
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
                        Console.WriteLine("Обмен евро на рубли\nСколько хотите обменять?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                      
                        if (euro >= currencyCount && currencyCount >= 0)
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
                        Console.WriteLine("Обмен рублей на евро\nСколько хотите обменять?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                      
                        if (rub >= currencyCount && currencyCount >= 0)
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
                        Console.WriteLine("Обмен юаней на рубли\nСколько хотите обменять?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                      
                        if (cny >= currencyCount && currencyCount >= 0)
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
                        Console.WriteLine("Обмен рублей на юани\nСколько хотите обменять?");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                      
                        if (rub >= currencyCount && currencyCount >= 0)
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
                        Console.WriteLine("Вы вышли из обменника");
                        isWork = false;
                        break;
                }
            }

        }
    }
}

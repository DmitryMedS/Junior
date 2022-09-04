using System;
namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int minValue = 5;
            int maxValue = 101;
            int number = rnd.Next(minValue, maxValue);
            int summ = 0;
            int multipleNumber1 = 3;
            int multipleNumber2 = 5;

            Console.WriteLine(number);

            for (int i = 1; i < number; i++)
                {
                   if (i % multipleNumber1 == 0)
                     {
                         sum += i;
                    Console.WriteLine(i);
                      }
                 if (i % multipleNumber2 == 0)
                      {
                    sum += i;
                    Console.WriteLine(i);
                      }
                }
            Console.WriteLine(sum);
                }
             }
        }
    }
}

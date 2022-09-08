using System;
namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minValue = 5;
            int maxValue = 101;
            int number = random.Next(minValue, maxValue);
            int summ = 0;
            int multipleNumber1 = 3;
            int multipleNumber2 = 5;

            for (int i = 1; i < number; i++)
            {
                if (i % multipleNumber1 == 0 | i % multipleNumber2 == 0)
                {
                    summ += i;
                    Console.WriteLine(i);
                } 
            }
            Console.WriteLine(summ);
        }
    }
}

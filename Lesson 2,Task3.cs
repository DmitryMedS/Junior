using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int sum = 0;
            Console.WriteLine(number);
            for (int i = 1; i < number; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                    Console.WriteLine(i);


                }
                 if (i % 5 == 0)
                {
                    sum += i;
                    Console.WriteLine(i);
                }


            }
            Console.WriteLine(sum);

        }
    }
}

using System;
namespace Lesso
{
    internal class Program
    {
        static void Main(string[] args)
        {
	    Random random = new Random();

            int minValue = 1;
            int maxValue = 101;
            int number = random.Next(minValue,maxValue);
            int sum = 0;
            int aliquotNumber = 3;
            int aliquotNumber2 = 5;

            Console.WriteLine(number);

            for (int i = 0; i < number; i++)
            {
                if (i % aliquotNumber == 0 | i % aliquotNumber2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);

        }
      }
}

using System;
namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[30];
            int minValue = 10;
            int maxValue = 50;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValue, maxValue);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            if (array[0] > array[1])
            {
                Console.WriteLine(array[0]);
            }

            if (array[array.Length - 1] > array[array.Length - 2])
            {
                Console.WriteLine(array[array.Length - 1]);
            }
            
            for (int i = 1; i < array.Length-1; i++)
            {
                  if (array[i] > array[i+1]&& array[i] > array[i - 1])
                  {
                    Console.WriteLine(array[i]);
                  }
            }
        } 
    } 
}


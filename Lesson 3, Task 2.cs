using System;
namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maxNumber = 0;
            int minValue = 1;
            int maxValue = 10;
            int[,] array = new int[ 10,10];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minValue,maxValue);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j]>maxNumber )
                    {
                        maxNumber = array[i, j];
                    }
                }
            }

            Console.WriteLine("Максимальное значение массива - "+maxNumber);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j] == maxNumber)
                    {
                        array[i, j] = 0;
                    }
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

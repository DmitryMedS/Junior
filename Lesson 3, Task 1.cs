using System;
namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int column = 0;
            int line = 1;
            int sumLine = 0;
            int multiColumn = 1;
            int[,] array = { {1,2,3,4},
                             {2,3,3,1},
                             {3,2,3,4},
                             {2,2,3,4 } };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]+" ");

                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sumLine += array[line,i ];

                }
           
            for (int j = 0; j < array.GetLength(1); j++)
                {
                multiColumn *= array[j,column];

                }
            Console.WriteLine("произведение первого столбца " + multiColumn + " сумма второй строки " + sumLine);
        }
    }
}

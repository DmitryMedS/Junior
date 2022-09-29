using System;
namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 30;
            int[] array = new int[arraySize];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 4);
                Console.Write(array[i] + " ");
            }

            int repite = 0, maxRepite = 0, elemNumber = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    repite++;
                }
                else
                {
                    repite = 0;
                }
                if (repite >= maxRepite)
                {
                    elemNumber = i;
                    maxRepite = repite;
                }
            }

            Console.WriteLine("\n\nГруппа повторяющихся чисел начианется с индекса {0} заканичивается индексом" +
                " {1}\nдлиной {2} элемента со значениями = {3}\n", elemNumber - maxRepite,
                elemNumber, maxRepite + 1, array[elemNumber]);
           
            for (int i = 0; i < array.Length; i++)
            {

                if (i >= (elemNumber - maxRepite) && i <= elemNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(array[i] + " ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}

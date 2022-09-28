using System;
namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int[] array = new int[100];
            Random random = new Random();

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 101);
                Console.Write(array[i]+ " ");
            }
            
            for (int j = 0; j < array.Length; j++)
            {
               for (int i  = 0;i< array.Length - 1; i++)
            {
                   if (array[i] > array[i+ 1] )
                   {
                    number = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = number;
                   } 
                }
            }
            Console.WriteLine("\nмассив отсортирован ");
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }

        }
    }
}

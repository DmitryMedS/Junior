using System;
namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,2,3,4,5,6,7,8};
            int userInput;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("значение сдвига = ");
            userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < userInput; i++)
            {
                int number = array[0];

                for (int j = 0; j < array.GetLength(0) - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.GetLength(0) - 1] = number;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}

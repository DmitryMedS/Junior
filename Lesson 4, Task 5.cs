using System;
namespace Shuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ShuffleArr(array);
        }
        static void ShuffleArr(int[] array)
        {
            Random rnd = new Random();

            int ShuffleEL, rndId;
            for (int i = array.Length-1 ;i >= 0 ; i--)
            {
                rndId = rnd.Next(i);
                ShuffleEL = array[rndId];
                array[rndId] = array[i];
                array[i] = ShuffleEL;
                Console.Write(ShuffleEL + " ");
            }
        }
    }
}

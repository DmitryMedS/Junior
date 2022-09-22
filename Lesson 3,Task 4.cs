using System;
namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[0];
            string userInput;
            bool isWork = true;
            int sum = 0;

            while (isWork)
            {
                userInput = Console.ReadLine();

                 if (userInput == "sum")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += array[i];
                        
                    }
                    Console.WriteLine(sum);
                }

               else if (userInput == "exit" )
                {
                    isWork = false;
                }

                else
                {
                    int[] tempArray = new int[array.Length + 1];

                    for (int i = 0; i < array.Length; i++)
                    {
                        tempArray[i] = array[i];
                    }
                    tempArray[tempArray.Length - 1] = Convert.ToInt32(userInput);
                    array = tempArray;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}

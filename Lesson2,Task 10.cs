using System;
namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            int minNumber = 2;
            int maxNumber = 1000;
            int extent = 0;
            int upExtent = 1;
            int number = rand.Next(minNumber, maxNumber);

            for (int i =  0; upExtent < number; i++)
                 {
                upExtent = upExtent * minNumber;
                   extent++;
                 }
            Console.WriteLine(number + " < "+upExtent +"  "+ minNumber + "/" +extent+" степени");}
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int minNumber = 0;
            int maxNumber = 28;
            int value = rand.Next(minNumber, maxNumber);
            int count = 0;
            int sumNumber=0;
            int closedProgramm = 1000;
            int minNumberCheck = 99;
            int maxNumberCheck = 999;

            for(int i = 0; i <= closedProgramm; i++)
            {
                count += value;
                if (count >= closedProgramm)
                {
                    break;
                }
                if (count > minNumberCheck && count <= maxNumberCheck)
                {
                    sumNumber++;
                }
            }
            Console.WriteLine(sumNumber);
           
        }
    }
}

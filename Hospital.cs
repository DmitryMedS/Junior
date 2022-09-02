using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPeople;
            int countTime = 10;
            int countHourse;
            int countMinute;
            Console.WriteLine("Вы пришли в поликлинику сколько вы видите человек перед вами?");
                countPeople = Convert.ToInt32(Console.ReadLine());
            countHourse = countPeople * countTime / 60;
            countMinute = countPeople * countTime % 60;
            Console.WriteLine("Вам осталось ждать " + countHourse + " часов и " + countMinute + " минут");



        }
    }
}

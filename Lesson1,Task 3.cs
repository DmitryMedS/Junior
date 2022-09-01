using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price = 10;
            int diamond;
            int gold;
            
            Console.WriteLine("ВЫ пришли в магазин");
            Console.WriteLine("сколько золота у вас?");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Алмазы стоят по 10 золотых за Алмаз");
            Console.WriteLine("сколько сколько алмазов желаете купить?");
            diamond = Convert.ToInt32(Console.ReadLine());
            gold -= diamond * price;
            Console.WriteLine("У вас золота - "+ gold);
            Console.WriteLine("Алмазов - "+diamond);
        }
    }
}

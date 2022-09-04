using System;
namespace Lesson2.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countRepeat;
            int number = 0;
            string name = "Дмитрий";
            Console.WriteLine("Сколько раз мне повторить твое имя");
            countRepeat = Convert.ToInt32(Console.ReadLine());

            while (number < countRepeat)
            {
                number++;
                Console.WriteLine(name);
            }
        }
    }
}

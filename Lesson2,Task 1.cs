using System;
namespace Lesson2.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countRepeat;
            string name = "Дмитрий";
            
            Console.WriteLine("Сколько раз мне повторить твое имя");
            countRepeat = Convert.ToInt32(Console.ReadLine());

            for (int i = 0;i < countRepeat;i++)
            {
                Console.WriteLine(name);
            }
        }
    }
}

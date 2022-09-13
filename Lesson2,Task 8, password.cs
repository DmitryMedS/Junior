using System;
namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int password = 123456;
            int inputUser;

            for (int tryCount = 2; tryCount >= 0; tryCount--)
            {
                Console.WriteLine("Введите пароль для доступа к почте: ");
                inputUser = Convert.ToInt32(Console.ReadLine());

                if (inputUser == password)
                {
                    Console.WriteLine("  Пароль введен верно\n  Тайное сообщение...");
                    break;
                }
                else
                {
                    Console.WriteLine("Hеверный пароль Осталось " + tryCount + " попыток.. ");
                }
            }
        }
    }
}

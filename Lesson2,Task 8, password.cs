using System;
namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int password = 123456;
            int inputUser;
            int tryCount = 2;

            for (int i = tryCount; i >= 0; i--)
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
                    Console.WriteLine("Hеверный пароль Осталось " + i + " попыток.. ");
                }
            }
        }
    }
}

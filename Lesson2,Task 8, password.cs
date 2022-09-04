using System;


namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int password = 123456;
            int inputUser;
            bool isWork = true;
            int tryCount = 3;

            while (isWork & tryCount > 0)
            {
                Console.WriteLine("Введите пароль для доступа к почте: ");
                inputUser = Convert.ToInt32(Console.ReadLine());

                if (inputUser == password)
                {
                    Console.WriteLine("  Пароль введен верно\n  Тайное сообщение...");
                    isWork = false;
                }
                else 
                {
                    tryCount--;
                    Console.WriteLine("Hеверный пароль Осталось " +tryCount+ " попыток.. ");   
                }
            }
        }
    }
}

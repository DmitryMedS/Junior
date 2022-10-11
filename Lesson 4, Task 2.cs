using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 5; int maxHealth = 100;
            int mana = 3; int maxMana = 100;
            while (true)
            {
                DrawBar(health, maxHealth, ConsoleColor.Red, 0, '#');
                DrawBar(mana, maxMana, ConsoleColor.Blue, 1, '*');
                Console.SetCursorPosition(0, 5);
                Console.Write("Введите % на которое изменянтся жизни ");
                health += Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите % на которое изменится мана ");
                mana += Convert.ToInt32(Console.ReadLine());

                Console.ReadKey();
                Console.Clear();
            }
        }
            static void DrawBar(int value, int maxValue, ConsoleColor color, int position, char symbol = ' ')
            {
                ConsoleColor defaultColor = Console.BackgroundColor;
                string bar = "";
                for (int i = 0; i < value; i++)
                {
                    bar += symbol;
                }
                Console.SetCursorPosition(0, position);
                Console.Write("[");
                Console.BackgroundColor = color;
                Console.Write(bar);
                Console.BackgroundColor = defaultColor;
                bar = "";
                for (int i = value; i < maxValue; i++)
                {
                    bar += ' ';

                }
                 Console.Write(bar + ']'+value+'%');
            }
    }
}
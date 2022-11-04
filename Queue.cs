using System;
using System.Collections.Generic;
namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;

            Queue<int> visitors = new Queue<int>();
            visitors.Enqueue(125);
            visitors.Enqueue(75);
            visitors.Enqueue(452);
            visitors.Enqueue(245);
            visitors.Enqueue(75);

            while (visitors.Count > 0)
            {
                Console.WriteLine("к вам пришел посетитель и купил товар на сумму " + visitors.Peek());

                sum += visitors.Dequeue();

                Console.WriteLine("теперь ваш баланс " + sum);
                Console.ReadLine();
                Console.Clear();

                if (visitors.Count == 0)
                {
                    Console.WriteLine("посетители закончились");         
                }
            }
        }
    }
}



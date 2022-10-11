using System;


namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;
            string name;
            string profession;
            string[] names = {"Шевчук Дмитрий Витальевич" };
            string[] professions = {"Программист"};
            int userInput;

            Console.SetCursorPosition(15, 2);
            Console.WriteLine("Кадровый учет");
            
             while (isWork)
            {           
                Console.WriteLine("\n\n\n1 - Добавить досье\n\n2 - Показать все досье\n\n3 - Удалить досье\n\n4 - Поиск по фамилии\n\n5 - Выход");
                Console.WriteLine( "Выберите пункт меню");
                
                switch (userInput = Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:

                        CreateDosier(ref names, ref professions);

                         break;
                    case 2:

                        for(int i = 0; i < professions.Length; i++)
                        {
                            Console.Write((i+1)+" - "+names[i] + " -  "+professions[i] );
                               Console.WriteLine();
                        }
                        break;
                    case 3:

                        Delete(ref names, ref professions);

                            break;
                    case 4:
                        FindDossier(names, professions);
                        break;

                    case 5:
                        isWork = false;
                        break;
                }
                
            }
        }
        static void CreateDosier(ref string[] names, ref string[] professions)

        {
            string name;
            string profession;

            Console.WriteLine("Добавление досье\nВведите фамилию:\n");
            name = (" - " + Console.ReadLine() + " - ").ToUpper();
            Console.WriteLine("Введите Имя:\n");
            name += (Console.ReadLine() + " - ").ToUpper();
            Console.WriteLine("Введите Отчество:\n");
            name += (Console.ReadLine() + " - ").ToUpper();
            Console.WriteLine("\n  Введите Профессию:\n");
            profession = (Console.ReadLine()).ToUpper();
            AddDossier(ref names, name);
            AddDossier(ref professions, profession);
            Console.WriteLine("Досье успешно добавлено!");
            Console.ReadKey();

        }
        static void AddDossier(ref string[] names, string name)
        {
            string[] tempNames = new string[names.Length + 1];
            for (int i = 0; i < names.Length; i++)
            {
                tempNames[i] = names[i];
            }
            tempNames[tempNames.Length - 1] = name;
            names = tempNames;
           
            
            
        }
        static void Delete(ref string[] names, ref string[] professions)
        {
            int userInput;

            Console.Clear();
            Console.WriteLine("Ведите номер досье: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput > 0 & userInput <= names.Length)
            {
                DecreaseArray(ref names, userInput);
                DecreaseArray(ref professions, userInput);
                Console.WriteLine("Досье успешно удалено");
            }
            else
            {
                Console.WriteLine("Досье не найденоно");
            }
            Console.ReadKey();
        }
        static void DecreaseArray(ref string[] decrease, int inputData)
        {
            string[] tempDecrease = new string[decrease.Length - 1];

            for (int i = 0; i < inputData; i++)
            {
                tempDecrease[i] = decrease[i];
            }

            for (int i = inputData + 1; i < decrease.Length; i++)
            {
                tempDecrease[i - 1] = decrease[i];
            }
            decrease = tempDecrease; ;
        }
        static void FindDossier(string[] fullNames, string[] positions)
        {
            string userInput = (Console.ReadLine()).ToUpper();
            bool isFinded = false;
            Console.Clear();
            Console.WriteLine("   Введите фамилию:  \n");
         
            foreach (var fullName in fullNames)
            {
                if (fullName.Contains(userInput))
                {
                    int number = Array.IndexOf(fullNames, fullName);
                    Console.Clear();
                    Console.WriteLine($" ID - Фамилия -  Имя - Отчество -  Должность ");
                    Console.WriteLine($"Досье найдено: {number} - {fullNames[number]} {positions[number]}");
                    isFinded = true;
                }
            }

            if (isFinded == false)
            {
                Console.Clear();
                Console.WriteLine("Досье не найдено!");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
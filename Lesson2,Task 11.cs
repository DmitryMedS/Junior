using System;
namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol = '(';
            string textInput;
            int nesting = 0;
            int nesting2 = 0;
            
            textInput = Console.ReadLine();

            for(int i = 0; i < textInput.Length; i++)
            {
                if (textInput[i] == symbol)
                {
                    nesting++;
                    if (nesting > nesting2)
                    {
                        nesting2 = nesting;
                    }  
                }
                else
                {
                    nesting--;
                }
            }
            if(nesting == 0)
            {
                Console.WriteLine(" все верно " + textInput + " вложенность " + nesting2 + " кратная");
            }
            else
            {
                Console.WriteLine("НЕ ВЕРНО");
            }        
          }
       }
    }


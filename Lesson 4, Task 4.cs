using System;
using System.IO;

namespace GameMap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            int pacmanX, pacmanY;
            int pacmanDX=0, pacmanDY=0;
            char[,] map = ReadMap("map1", out pacmanX, out pacmanY);
            bool isPlaying = true;

            DrawMap(map);
            Console.SetCursorPosition(pacmanY, pacmanX);
            Console.Write('#');

            while (isPlaying)
            {
               if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                   ChangeDirection (key,ref pacmanDX,ref pacmanDY);
                 }
                if (map[pacmanX+pacmanDX,pacmanY+pacmanDY] != 'o')
                {
                   Move(map, '#', ref pacmanX, ref pacmanY, pacmanDX, pacmanDY);
                }
                System.Threading.Thread.Sleep(150);

                      }
             }
        static void ChangeDirection(ConsoleKeyInfo key, ref int DX,ref int DY)
        {
            switch (key.Key) 
            {
                case ConsoleKey.UpArrow:
                    DX = -1;
                    DY = 0;
                    break;
                case ConsoleKey.DownArrow:
                    DX = 1;
                    DY = 0;
                    break;
                case ConsoleKey.LeftArrow:
                    DX = 0;
                    DY = -1;
                    break;
                case ConsoleKey.RightArrow:
                    DX = 0;
                    DY = 1;
                    break;
            }

        }
        static void Move(char[,] map, char symbol, ref int X, ref int Y, int DX, int DY)
        {
            Console.SetCursorPosition(Y, X);
            Console.Write(map[X, Y]);
            X += DX;
            Y += DY;
            Console.SetCursorPosition(Y, X);
            Console.Write(symbol);
        }
        
        static char[,] ReadMap(string mapName, out int pacmanX, out int pacmanY)
        {
            pacmanX = 0;
            pacmanY = 0;

            string[] newFile = File.ReadAllLines($"Maps/{mapName}.txt");
            char[,] map = new char[newFile.Length, newFile[0].Length];
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = newFile[i][j];
                    if (map[i, j] == '#')
                    {
                        pacmanX = i;
                        pacmanY = j;
                        map[i, j] = '*';

                    }
                }
            }
            return map;
        }
        static void DrawMap(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}

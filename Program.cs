using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Map
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RPG Map");
            Console.WriteLine("WASD to move");
            Console.WriteLine("----");
            Console.WriteLine();

            int borderX = 21;
            int borderY = 11;
            int PlayerX = borderX / 2;
            int PlayerY = borderY / 2;
            ConsoleKeyInfo key = Console.ReadKey();

            // Print horizontal borders
            for (int x = 0; x < borderX; x++)
            {
                Console.SetCursorPosition(x, 0);
                Console.Write("-");
                Console.SetCursorPosition(x, borderY - 1);
                Console.Write("-");
            }

            // Print vertical borders
            for (int y = 1; y < borderY - 1; y++)
            {
                Console.SetCursorPosition(0, y);
                Console.Write("|");
                Console.SetCursorPosition(borderX - 1, y);
                Console.Write("|");
            }


            //Print the map for the Player
            int width = 20;
            int height = 10;
            for (int a = 1; a <= width - 1; a++)
            {
                for (int b = 1; b <= height - 1; b++)
                {
                    Console.SetCursorPosition(a, b);
                    Console.WriteLine("^");
                }
            }

            //Print Player 
            Console.SetCursorPosition (PlayerX, PlayerY);
            Console.WriteLine("*");
            while (true) 
            {
                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.W:
                        if (PlayerY > 1) PlayerY--; break;

                    case ConsoleKey.S:
                        if (PlayerY < height - 1) PlayerY++; break;

                    case ConsoleKey.D:
                        if (PlayerX < width - 1) PlayerX++; break;

                    case ConsoleKey.A:
                        if (PlayerX > 1) PlayerX--; break;
                }
                Console.Clear();

                for (int x = 0; x < borderX; x++)
                {
                    Console.SetCursorPosition(x, 0);
                    Console.Write("-");
                    Console.SetCursorPosition(x, borderY - 1);
                    Console.Write("-");
                }

                // Print vertical borders
                for (int y = 1; y < borderY - 1; y++)
                {
                    Console.SetCursorPosition(0, y);
                    Console.Write("|");
                    Console.SetCursorPosition(borderX - 1, y);
                    Console.Write("|");
                }

                // Print the map for the Player
                for (int a = 1; a <= width - 1; a++)
                {
                    for (int b = 1; b <= height - 1; b++)
                    {
                        Console.SetCursorPosition(a, b);
                        Console.Write("^");
                    }
                }
                Console.SetCursorPosition(PlayerX, PlayerY);
                Console.WriteLine("*");

            } 
        }
    }
}

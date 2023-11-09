using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class RPGMap
{
    private static char[,] map =
   {
        {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
        {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
        {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
        {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'}
    };

    //usage: map[a,b]

    //Map Legend:
    // ` = Grass
    // ~ = Water
    // * = Trees
    // ^ = Mountains

    private void ColorMap(char color)
    {
        switch (color)
        {
            case '^':
                Console.ForegroundColor = ConsoleColor.DarkGray; 
                break;
            case '*':
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                break;
            case '~':
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
            case '`':
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            default:
                Console.ForegroundColor = ConsoleColor.White;
                break;
        }
    }

    public void DisplayMap()
    {
        Console.WriteLine("+" + new string('-', map.GetLength(1)) + "+");
        for (int a = 0;  a < map.GetLength(0); a++)
        {
            Console.Write("|");
            for (int b = 0; b < map.GetLength(1); b++)
            {
                ColorMap(map[a, b]);
                Console.Write(map[a, b]);
            }
            Console.ResetColor();
            Console.WriteLine("|");
        }
        Console.WriteLine("+" + new string('-', map.GetLength(1)) + "+");
    }

    public void DisplayMap(int scale)
    {
        Console.WriteLine("+" + new string('-', map.GetLength (1) * scale) + "+");
        for (int a = 0; a < map.GetLength(0); a++)
        {
            for (int aRowScale = 0; aRowScale < scale; aRowScale++)
            {
                Console.Write("|");
                for (int b = 0; b < map.GetLength(1); b++)
                {
                    for(int bRowScale = 0;bRowScale < scale; bRowScale++)
                    {
                        ColorMap(map[a,b]);
                        Console.Write(map[a,b]);
                    }
                }
                Console.ResetColor();
                Console.WriteLine("|");
            }
        }
        Console.WriteLine("+" + new string('-', map.GetLength(1) * scale) + "+");
    }
}

class Program
{
    static void Main(string[] args)
    {
        RPGMap map = new RPGMap();

        Console.WriteLine("OG Map");
        map.DisplayMap();
        Console.WriteLine();

        Console.WriteLine("Scaled Map 2x");
        map.DisplayMap(2);
        Console.WriteLine();

        Console.WriteLine("Scaled Map 3x");
        map.DisplayMap(3);
        Console.WriteLine();

        Console.WriteLine("Scaled Map 5x");
        map.DisplayMap(5);
        Console.WriteLine();

        Console.WriteLine("Scaled Map 7x");
        map.DisplayMap(7);
        Console.ReadKey(true);
    }
}


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

    private void ColorCharacters(char character, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(character);
        Console.ResetColor();
    }


    public void DisplayMap()
    {
        Console.WriteLine("+" + new string('-', map.GetLength(1)) + "+");
        for (int i = 0; i < map.GetLength(0); i++)
        {
            Console.Write("|");
            for (int j = 0; j < map.GetLength(1); j++)
            {
                Console.Write(map[i, j]);
            }
            Console.WriteLine("|");
        }
        Console.WriteLine("+" + new string('-', map.GetLength(1)) + "+");
    }

    public void DisplayMap(int scale)
    {
        Console.WriteLine("+" + new string('-', map.GetLength(1) * scale) + "+");
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int rowScale = 0; rowScale < scale; rowScale++)
            {
                Console.Write("|");
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    for (int colScale = 0; colScale < scale; colScale++)
                    {
                        Console.Write(map[i, j]);
                    }
                }
                Console.WriteLine("|");
            }
        }
        Console.WriteLine("+" + new string('-', map.GetLength(1) * scale) + "+");
    }

    private ConsoleColor
}

class Program
{
    static void Main(string[] args)
    {
        RPGMap rpgMap = new RPGMap();

        Console.WriteLine("Unscaled Map:");
        rpgMap.DisplayMap();
        Console.WriteLine();

        Console.WriteLine("Scaled Map (2x):");
        rpgMap.DisplayMap(2);
        Console.WriteLine();

        Console.WriteLine("Scaled Map (3x):");
        rpgMap.DisplayMap(5);
        Console.ReadKey();
    }
}




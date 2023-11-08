using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RPGMap
{
    private char[,] map =
    {
        {'^', '^', '^'},
        {'^', '^', '^'},
        {'^', '^', '^'}
    };

    private int playerRow = 1;
    private int playerCol = 1;

    public void DisplayMap()
    {
        Console.Clear();
        Console.WriteLine("+--+");
        for (int a = 0; a < map.GetLength(0); a++)
        {
            Console.Write("|");
            for (int b = 0; b < map.GetLength(1); b++)
            {
                if (a == playerRow && b == playerCol)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write(map[a, b]);
                }
            }
            Console.WriteLine("|");
        }
        Console.WriteLine("+--+");
    }



    public void MovePlayer(ConsoleKeyInfo key)
    {
        switch (key.Key)
        {
            case ConsoleKey.UpArrow:
                if (playerRow > 0)
                {
                    map[playerRow, playerCol] = '^';
                    playerRow--;
                    map[playerRow, playerCol] = '*';
                }
                break;
            case ConsoleKey.DownArrow:
                if (playerRow < map.GetLength(0) - 1)
                {
                    map[playerRow, playerCol] = '^';
                    playerRow++;
                    map[playerRow, playerCol] = '*';
                }
                break;
            case ConsoleKey.LeftArrow:
                if (playerCol > 0)
                {
                    map[playerRow, playerCol] = '^';
                    playerCol--;
                    map[playerRow, playerCol] = '*';
                }
                break;
            case ConsoleKey.RightArrow:
                if (playerCol < map.GetLength(1) - 1)
                {
                    map[playerRow, playerCol] = '^';
                    playerCol++;
                    map[playerRow, playerCol] = '*';
                }
                break;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        RPGMap rpgMap = new RPGMap();

        while (true)
        {
            rpgMap.DisplayMap();
            ConsoleKeyInfo key = Console.ReadKey(true);
            rpgMap.MovePlayer(key);
        }
    }
}

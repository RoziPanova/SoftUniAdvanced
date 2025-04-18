using System;

namespace _02ClearSkies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] airspace = new char[n, n];
            int enemiesCount = 0;
            int armor = 300;
            int currentRow = -1;
            int currentCol = -1;
            for (int r = 0; r < n; r++)
            {
                string line = Console.ReadLine();
                for (int c = 0; c < n; c++)
                {
                    if (line[c] == 'E')
                    {
                        enemiesCount++;
                    }
                    if (line[c] == 'J')
                    {
                        currentRow = r;
                        currentCol = c;
                        airspace[r, c] = '-';
                        continue;
                    }
                    airspace[r, c] = line[c];
                }
            }

            while (true)
            {
                string direction = Console.ReadLine();
                switch (direction)
                {
                    case "up":
                        currentRow--;
                        break;
                    case "down":
                        currentRow++;
                        break;
                    case "left":
                        currentCol--;
                        break;
                    case "right":
                        currentCol++;
                        break;
                    default: break;
                }
                if (currentRow < 0)
                {
                    currentRow = n - 1;
                }
                if (currentRow > n - 1)
                {
                    currentRow = 0;
                }
                if (currentCol < 0)
                {
                    currentCol = n - 1;
                }
                if (currentCol > n - 1)
                {
                    currentCol = 0;
                }
                if (airspace[currentRow, currentCol] == 'E' && enemiesCount != 0)
                {
                    enemiesCount--;
                    armor -= 100;
                    airspace[currentRow, currentCol] = '-';
                }
                if (enemiesCount == 0)
                {
                    Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
                    break;
                }

                if (armor == 0)
                {
                    Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{currentRow}, {currentCol}]!");
                    break;
                }
                if (airspace[currentRow, currentCol] == 'R')
                {
                    armor = 300;
                    airspace[currentRow, currentCol] = '-';
                }
            }
            airspace[currentRow, currentCol] = 'J';
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(airspace[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
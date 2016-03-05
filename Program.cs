using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameoflife
{
    class Game
    {
        static void Main(string[] args)
        {
            int[,] grid = new int[,]
            {
              
                           };

            Grid lGrid = new Grid(grid);

            Console.WriteLine(" Generation 0 ");
            lGrid.DrawGeneration();
            Console.WriteLine();

            Random R = new Random();
            for (int i = 0; i < 50; i++)
            {
                int x = R.Next(20);
                int y = R.Next(20);
                grid[x, y] = 1;
            }

            while (lGrid.AliveCells() > 0)
            {

                Console.WriteLine();
                Console.WriteLine("Generation {0}", lGrid.GenerationCount);
                lGrid.GenerationProcess();
                lGrid.DrawGeneration();

                Console.WriteLine();

                if (lGrid.AliveCells() == 0)
                {
                    Console.WriteLine("Every one is dead.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(" Press [Enter] to continue or a[Enter] to quit.");

                    Console.ReadLine();

                    if (Console.ReadLine() == "a" || Console.ReadLine() == "A")
                        break;
                }
    }
}
    }
}

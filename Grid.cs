using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameoflife
{
    class Grid
    {
        int[,] generation;   // Denna håller den postition som den är på just då
        int[,] lastgeneration; // Denna håller dem gamla cellerna

        int generationCount; // Denna räknar Celler som blivir iterated

        //  Dessa ska du ha för att bestämma en höjd och bredd så att cellerna inte går utanför
        int width;  // håller bredden och höjden  1 bredden 2 höjden
        int height;

        // En propperty skall användas
        public int GenerationCount
        {
            get { return generationCount; }
        }

        // Constructor behöver du nu \n denna gör å man måste skicka in en 2D array \n 

        // Denna constructor clonar så att generationen uppstår
        // och sen ställer den in bredden och höjden ( GetLength)
        public Grid(int[,] newGrid)
        {
            generation = (int[,])newGrid.Clone();
            generationCount = 1;
            // Tänk på att width och height är annorlunda från matten \n  man kan säga att på matten är det x,Y \n här är det y,x
            width = generation.GetLength(1); // Denna Indikerar levande celler
            height = generation.GetLength(0); // Denna indikerar döda celler

            lastgeneration = new int[height, width];
        }

        // Nu skapar vi en Neighbours Metod som ska innehålla if satser med x,y
        // Det som dessa if satser gör är att de räknar hur många
        // grannar som cellen har och ser till att den inte kommer utanför bredd och höjd
        private int Neighbours(int x, int y)
        {
            int count = 0;
            if (x > 0 && y > 0)

            {
                if (generation[y - 1, x - 1] == 1)
                    count++;
            }

            if (y > 0)
            {
                if (generation[y - 1, x] == 1)
                    count++;

            }

            if (x < width - 1 && y > 0)
            {
                if (generation[y - 1, x + 1] == 1)
                    count++;
            }

            if (x > 0)
            {
                if (generation[y, x - 1] == 1)
                    count++;
            }


            if (x < width - 1)
            {
                if (generation[y, x + 1] == 1)
                    count++;
            }

            if (x > 0 && y < height - 1)
            {
                if (generation[y + 1, x - 1] == 1)
                    count++;
            }

            if (y < height - 1)
            {
                if (generation[y + 1, x] == 1)
                    count++;
            }

            if (x < width - 1 && y < height - 1)
            {
                if (generation[y + 1, x + 1] == 1)
                    count++;
            }
            return count++;
        }


        //  Nu Lägger vi till en ny metod som skriver ut 
        // för att vi ska kuna se så neighbours fungerar.

        public void WriteNeighbours()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                    Console.Write("", Neighbours(x, y));

            }
        }

        // Skapa en veriabel som håller nesta Processen 
        // och sen satte jag att den skulle klona den generationen som redan finns 
        // 
        public void GenerationProcess()
        {
            int[,] nextGeneration = new int[height, width];
            lastgeneration = (int[,])generation.Clone(); // Clone för att om man skulle göra en tilldelning så skulle den andra också ändras.

            generationCount++;

            // Här är 2 for loopar så upprepars alla celler i Gridden.
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                { 
                    // Sen är här  if satser med elses, 
                    // Den första här kollar om cellen har 0 eller 1 granne
                    // har den det så dör den
                    if (generation[y, x] == 0 && Neighbours(x, y) == 3)
                        nextGeneration[y, x] = 1;

                    // Denna här if satten kollar om den är död eller har 3 celler
                    // då föds en ny cell 
                    // Den sista längs till höger kollar om den lever och har 2 eller 3 grannar
                    // och om detta stämmer så fortsätter den att leva annars är den död.
                    if (generation[x, y] == 0 && Neighbours(y, x) == 1 && (Neighbours(x, y) == 2 || Neighbours(y, x) == 3))
                        nextGeneration[x, y] = 1;
                    {
                        nextGeneration = (int[,])nextGeneration.Clone();
                    }
                }
            }
        }


        public void DrawGeneration()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)

                    Console.Write("{0}", generation[y, x]);
                Console.WriteLine();


            }
            Console.WriteLine();
        } 

        public int AliveCells()
        {
            int count = 0;
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                    if (generation[y, x] == 1)
                        count++;
            return count;
        }
            }
        }
        
    

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Gameoflife
//{
//    class Generation : Grid
//    {

//        //  Nu Lägger vi till en ny metod som skriver ut 
//        // för att vi ska kuna se så neighbours fungerar.

//        public void WriteNeighbours()
//        {
//            for (int y = 0; y < height; y++)
//            {
//                for (int x = 0; x < width; x++)
//                    Console.Write("", Neighbours(x, y));

//            }
//        }

//        // Skapa en veriabel som håller nesta Processen 
//        // och sen satte jag att den skulle klona den generationen som redan finns 
//        // 
//        public void GenerationProcess()
//        {
//            int[,] nextGeneration = new int[height, width];
//            lastgeneration = (int[,])generation.Clone(); // Clone för att om man skulle göra en tilldelning så skulle den andra också ändras.

//            generationCount++;

//            // Här är 2 for loopar så upprepars alla celler i Gridden.
//            for (int y = 0; y < height; y++)
//            {
//                for (int x = 0; x < width; x++)
//                {
//                    // Sen är här  if satser med elses, 
//                    // Den första här kollar om cellen har 0 eller 1 granne
//                    // har den det så dör den
//                    if (generation[y, x] == 0 && Neighbours(x, y) == 3)
//                        nextGeneration[y, x] = 1;

//                    // Denna här if satten kollar om den är död eller har 3 celler
//                    // då föds en ny cell 
//                    // Den sista längs till höger kollar om den lever och har 2 eller 3 grannar
//                    // och om detta stämmer så fortsätter den att leva annars är den död.
//                    if (generation[x, y] == 0 && Neighbours(y, x) == 1 && (Neighbours(x, y) == 2 || Neighbours(y, x) == 3))
//                        nextGeneration[x, y] = 1;
//                    {
//                        nextGeneration = (int[,])nextGeneration.Clone();
//                    }
//                }
//            }
//        }


//        public void DrawGeneration()
//        {
//            for (int y = 0; y < height; y++)
//            {
//                for (int x = 0; x < width; x++)

//                    Console.Write("{0}", generation[y, x]);
//                Console.WriteLine();


//            }
//            Console.WriteLine();
//        }

//        public int AliveCells()
//        {
//            int count = 0;
//            for (int y = 0; y < height; y++)
//                for (int x = 0; x < width; x++)
//                    if (generation[y, x] == 1)
//                        count++;
//            return count;
//        }
//    }
//}
  
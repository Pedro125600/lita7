using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = new int[10];
            int[] v2 = new int[10];
            int[,] matriz = new int[10,10];
            Random r = new Random();

           for(int i = 0; i < 10; i++)
            {
                v1[i] = r.Next(10);
                v2[i] = r.Next(10);
            }

            Console.WriteLine("\nVetor 1");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(v1[i] + " ");
            }


            Console.WriteLine("\nVetor 2");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(v2[i] + " ");
            }

            Console.WriteLine("\nMatrizs");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {


                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = v1[i] + v2[j];
                    Console.Write(matriz[i, j] + " ");

                }

                Console.WriteLine("\n");
            }


            Console.ReadLine();
        }
    }
}

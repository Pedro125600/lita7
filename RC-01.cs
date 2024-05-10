using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De o valor de N");
            int n = int.Parse(Console.ReadLine());
            int[] vetor = new int[n]; 
            int[,] matriz = new int[n, n];

            Random r = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = r.Next(10);
                }
            }

            Console.WriteLine("\n");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");

                }
                Console.WriteLine("\n");
            }



            for (int i = 0; i < matriz.GetLength(0); i++)
            {

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    int maior = vetor[i];
                   if (maior < matriz[i,j])
                    {
                        vetor[i] = matriz[i, j];
                    }

                }
                Console.WriteLine("\n");
                Console.WriteLine($"O maior valor na linha {i + 1 } e : {vetor[i]}  ");

            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("De o tamanho de linhaas ");
            int linhas = int.Parse(Console.ReadLine());

            Console.WriteLine("De o tamanho de colunas ");
            int colunas = int.Parse(Console.ReadLine());


            int[,] matriz = new int[linhas, colunas];
            int[] somaL = new int[linhas];


            Random r = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = r.Next(10);
                    somaL[i] += matriz[i, j];
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


           

            Console.WriteLine("A soma das linha e :");
            for(int i = 0; i < somaL.Length;i++)
            {
                Console.WriteLine($"Linha {i + 1} : {somaL[i]} ");
            }

          




            Console.ReadLine();
        }
    }
    }


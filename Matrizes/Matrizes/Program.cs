using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matrizes.Entities;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] separator = Console.ReadLine().Split(' ');
            int M = int.Parse(separator[0]);
            int N = int.Parse(separator[1]);

            Matriz.Mat = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    Matriz.Mat[i, j] = int.Parse(valores[j]);
                }
            }

            int num = int.Parse(Console.ReadLine());
            int[] numbers = new int[2];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (Matriz.Mat[i, j] == num)
                    {
                        Console.WriteLine(   Matriz.PrintValor(i, j));
                    }
                }
            }
        }
    }
}

using System;
using System.Globalization;
using POO_q3.Entities;

namespace POO_q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nota1, nota2, nota3;

            Console.Write("Nome do aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            nota1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota3 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Aluno a = new Aluno(nome, nota1, nota2, nota3);

            Console.WriteLine(a);
        }
    }
}

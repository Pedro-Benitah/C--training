/*
     * EXERCÍCIO 02:
    Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
    médio dos funcionários.
 */

using System;
using System.Globalization;
using POO_q2.Entities;

namespace POO_q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario;

            Console.WriteLine("Insira os dados do 1ª empregado:");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Salário: ");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            AverageSalary c1 = new AverageSalary(nome, salario);

            Console.WriteLine("Insira os dados do 2ª empregado:");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Salário: ");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            AverageSalary c2 = new AverageSalary(nome, salario);

            Console.WriteLine($"O salário total médio dos funcionários é: ${((c1.Salary+c2.Salary)/2).ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}

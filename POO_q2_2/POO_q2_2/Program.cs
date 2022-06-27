/*
     * Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). Em
    seguida, mostrar os dados do funcionário (nome e salário líquido). Em seguida, aumentar o
    salário do funcionário com base em uma porcentagem dada (somente o salário bruto é
    afetado pela porcentagem) e mostrar novamente os dados do funcionário. Use a classe
    projetada abaixo.
 */

using System;
using System.Globalization;
using POO_q2_2.Entities;

namespace POO_q2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioBruto, imposto;
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            salarioBruto = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            imposto = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Job f1 = new Job(nome, salarioBruto, imposto);
            Console.WriteLine(f1);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            f1.AumentarSalario(Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine(f1);
        }
    }
}

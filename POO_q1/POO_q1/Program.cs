/*
     * EXERCÍCIO 01:
    Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
    velha.
 */

using System;
using System.Globalization;
using POO_q1.Entities;

namespace POO_q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;

            Console.WriteLine("Insira as informações da 1ª pessoa:");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            OlderPerson pessoa1 = new OlderPerson(nome, idade);

            Console.WriteLine("Insira as informações da 2ª pessoa:");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            OlderPerson pessoa2 = new OlderPerson(nome, idade);

            if (pessoa1.Age > pessoa2.Age)
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa1.Name}");
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa2.Name);
            }
        }
    }
}

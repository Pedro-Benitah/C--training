using System;
using System.Globalization;

namespace BancoVirtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double saldo;
            string nome;
            char resp;
            Conta c;

            Console.Write("Digite o número da conta: ");
            numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular: ");
            nome = Console.ReadLine();

            Console.Write("Deseja fazer um deposito inicial (s/n)? ");
            resp = char.Parse(Console.ReadLine());

            if(resp == 's')
            {
                Console.Write("Dijite o valor do deposito inicial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(saldo, nome, numero);
            }
            else
            {
                c = new Conta(nome, numero);
            }
            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(c);

            Console.Write("\nQuanto deseja depositar: ");
            c.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);

            Console.Write("\nQuanto deseja sacar: ");
            c.Sacar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);
        }
    }
}

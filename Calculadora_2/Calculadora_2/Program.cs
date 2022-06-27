/*
    Calculadora.
*/

using System;

namespace Calculadora_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Calculadora.Resposta = "S";
            Calculadora.Solucao = 0;
            while (Calculadora.Resposta[0] == 'S')
            {
                Console.WriteLine("Calculadora - Utilize apenas valores numéricos nas contas, por favor\n");
                Console.WriteLine("Escolha a operação (+, -, *, /, **)");
                Calculadora.Scan(Console.ReadLine());
                if (Calculadora.Operador == -1)
                {
                    Console.WriteLine("Valor inserido não é aceito");
                }
                else
                {

                    Console.WriteLine("Insira o valor do 1º número: ");
                    Calculadora.Valor1 = Calculadora.VerificarPontuacao(Console.ReadLine());
                    Console.WriteLine("Insira o valor do 2º número: ");
                    Calculadora.Valor2 = Calculadora.VerificarPontuacao(Console.ReadLine());

                    Calculadora.VerificarCalculo();

                    Calculadora.PrintarResposta();
                }
                Console.WriteLine("Deseja tentar de novo? ");
                Calculadora.Resposta = Console.ReadLine().ToUpper(); ;
                if (Calculadora.Resposta == "")
                {
                    Calculadora.Resposta = "n";
                }
                Console.Clear();
                if (Calculadora.Operador != -1 && Calculadora.Resposta[0] == 'S')
                {
                    Console.WriteLine($"Último valor calculado: {Calculadora.Solucao}\n");
                }

            }
        }


    }
}

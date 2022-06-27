/*
    Calculadora.
*/

using System;
using System.Globalization;

namespace Questão_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operador;
            float valor1, valor2, solucao;
            string resposta, operacao;

            resposta = "S";
            solucao = 0;
            while (resposta[0] == 'S')
            {
                Console.WriteLine("Calculadora - Utilize apenas valores numéricos nas contas, por favor\n");
                Console.WriteLine("Escolha a operação (+, -, *, /, **)");
                operador = Scan(Console.ReadLine());
                if (operador == -1)
                {
                    Console.WriteLine("Valor inserido não é aceito");
                }
                else
                {

                    Console.WriteLine("Insira o valor do 1º número: ");
                    valor1 = VerificarPontuacao(Console.ReadLine());
                    Console.WriteLine("Insira o valor do 2º número: ");
                    valor2 = VerificarPontuacao(Console.ReadLine());

                    switch (operador)
                    {
                        case 1:
                            solucao = Soma(valor1, valor2);
                            operacao = "soma";
                            break;
                        case 2:
                            solucao = Subtracao(valor1, valor2);
                            operacao = "subtração";
                            break;
                        case 3:
                            solucao = Multiplicacao(valor1, valor2);
                            operacao = "multiplicação";
                            break;
                        case 4:
                            solucao = Divisao(valor1, valor2);
                            operacao = "divisão";
                            break;
                        case 5:
                            solucao = Potencia(valor1, valor2);
                            operacao = "potência";
                            break;
                        default:
                            solucao = 0;
                            operacao = "";
                            break;
                    }
                    Console.WriteLine($"O resultado da {operacao} dos valores {valor1} e {valor2} é {solucao}.");
                }
                Console.WriteLine("Deseja tentar de novo? ");
                resposta = Console.ReadLine().ToUpper(); ;
                if (resposta == "")
                {
                    resposta = "n";
                }
                Console.Clear();
                if (operador != -1 && resposta[0] == 'S')
                {
                    Console.WriteLine($"Último valor calculado: {solucao}\n");
                }

            }
        }
        static int Scan(string resp)
        {
            if (resp == "+")
            {
                return 1;
            }
            else if (resp == "-")
            {
                return 2;
            }
            else if (resp == "*")
            {
                return 3;
            }
            else if (resp == "/")
            {
                return 4;
            }
            else if (resp == "**")
            {
                return 5;
            }
            else
            {
                return -1;
            }
        }
        static float Soma(float x, float y)
        {
            return x + y;
        }
        static float Subtracao(float x, float y)
        {
            return x - y;
        }
        static float Multiplicacao(float x, float y)
        {
            return x * y;
        }
        static float Divisao(float x, float y)
        {
            return x / y;
        }
        static float Potencia(float x, float y)
        {
            float xInicial = x;
            for (int i = 1; i < y; i++)
            {
                x *= xInicial;
            }
            return x;
        }
        static float VerificarPontuacao(string x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == '.')
                {
                    return float.Parse(x, CultureInfo.InvariantCulture);
                }
            }
            return float.Parse(x);
        }

    }
}

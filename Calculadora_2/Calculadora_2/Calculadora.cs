using System;
using System.Globalization;

namespace Calculadora_2
{
    internal class Calculadora
    {
        public static int Operador;
        public static float Valor1, Valor2, Solucao;
        public static string Resposta, Operacao;

        public static void Scan(string resp)
        {
            if (resp == "+")
            {
                Operador = 1;
            }
            else if (resp == "-")
            {
                Operador = 2;
            }
            else if (resp == "*")
            {
                Operador = 3;
            }
            else if (resp == "/")
            {
                Operador = 4;
            }
            else if (resp == "**")
            {
                Operador = 5;
            }
            else
            {
                Operador = -1;
            }
        }

        public static float VerificarPontuacao(string valorExtenso)
        {
            for (int i = 0; i < valorExtenso.Length; i++)
            {
                if (valorExtenso[i] == '.')
                {
                    return float.Parse(valorExtenso, CultureInfo.InvariantCulture);
                }
            }
            return float.Parse(valorExtenso);
        }
        public static void VerificarCalculo()
        {
            switch (Operador)
            {
                case 1:
                    Soma();
                    Operacao = "soma";
                    break;
                case 2:
                    Subtracao();
                    Operacao = "subtração";
                    break;
                case 3:
                    Multiplicacao();
                    Operacao = "multiplicação";
                    break;
                case 4:
                    Divisao();
                    Operacao = "divisão";
                    break;
                case 5:
                    Potencia();
                    Operacao = "potência";
                    break;
                default:
                    Solucao = 0;
                    Operacao = "";
                    break;
            }
        }
        public static void Soma()
        {
            Solucao = Valor1 + Valor2;
        }
        public static void Subtracao()
        {
            Solucao = Valor1 - Valor2;
        }
        public static void Multiplicacao()
        {
            Solucao = Valor1 * Valor2;
        }
        public static void Divisao()
        {
            Solucao = Valor1 / Valor2;
        }
        public static void Potencia()
        {
            float Valor1Inicial = Valor1;
            Solucao = Valor1;
            for (int i = 1; i < Valor2; i++)
            {
                Solucao *= Valor1Inicial;
            }
        }
        public static void PrintarResposta()
        {
            Console.WriteLine($"O resultado da {Operacao} dos valores {Valor1} e {Valor2} é {Solucao}.");
        }
    }
}

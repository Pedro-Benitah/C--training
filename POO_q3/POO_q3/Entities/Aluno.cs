using System.Globalization;

namespace POO_q3.Entities
{
    internal class Aluno
    {
        public string Nome { get; private set; }
        public double Nota1 { get; private set; }
        public double Nota2 { get; private set; }
        public double Nota3 { get; private set; }
        private double NotaFinal;

        public Aluno(string nome, double nota1, double nota2, double nota3)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
            NotaFinal = Nota1 + Nota2 + Nota3;
        }

        private string Aprovado()
        {

            if (NotaFinal >= 60)
            {
                return "APROVADO";
            }
            else
            {
                return "REPROVADO"
                    + "\nFALTARAM "
                    + NotaRestante()
                    + " PONTOS";
            }
        }
        private string NotaRestante()
        {
            return (60 - NotaFinal).ToString("F2", CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return "NOTA FINAL = "
                + NotaFinal.ToString("f2", CultureInfo.InvariantCulture)
                +"\n"
                + Aprovado();
        }

        /*
         * NOTA FINAL = 52.00
            REPROVADO
            FALTARAM 8.00 PONTOS
        */


    }
}

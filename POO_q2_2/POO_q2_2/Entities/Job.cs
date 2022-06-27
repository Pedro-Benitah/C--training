using System.Globalization;

namespace POO_q2_2.Entities
{
    internal class Job
    {
        public string Nome { get; private set; }
        public double SalarioBruto { get; private set; }
        public double Imposto { get; private set; }

        public Job(string nome, double salarioBruto, double imposto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto *= 1+porcentagem/100;
        }
        public override string ToString()
        {
            return "Funcionário: "
                + Nome
                + ", $ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

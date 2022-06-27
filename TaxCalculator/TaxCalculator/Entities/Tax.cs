using System.Globalization;

namespace TaxCalculator.Entities
{
    internal abstract class TaxPlayer
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        protected TaxPlayer(string name)
        {
            Name = name;
        }

        protected TaxPlayer(double annualIncome, string name) : this(name)
        {
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();

        public override string ToString()
        {
            return Name
                +": $ "
                +Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

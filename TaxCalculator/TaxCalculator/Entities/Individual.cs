namespace TaxCalculator.Entities
{
    internal class Individual : TaxPlayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(double annualIncome, string name) : base(annualIncome, name)
        {
            
        }

        public Individual(double healthExpenditures, double annualIncome, string name) : base(annualIncome, name)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if(AnnualIncome < 20000)
            {
                return (AnnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }
            else
            {
                return (AnnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }
        }
    }
}

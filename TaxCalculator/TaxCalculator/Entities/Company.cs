namespace TaxCalculator.Entities
{
    internal class Company : TaxPlayer
    {
        public double NumberOfEmployees { get; set; }

        public Company(double annualIncome, string name) : base(annualIncome, name)
        {

        }

        public Company(double numberOfEmployees, double annualIncome, string name) : base(annualIncome, name)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
    }
}

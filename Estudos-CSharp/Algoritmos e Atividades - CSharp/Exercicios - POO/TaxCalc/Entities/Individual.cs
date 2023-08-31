namespace Entities.TaxCalc
{
    public class Individual : TaxPayer
    {
        public double HealtExpenditures { get; set; }

        public Individual()
        {
        }
        public Individual(string name, double anualIncome, double healExpenditures) : base(name, anualIncome)
        {
            this.HealtExpenditures = healExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.00)
            {
                return AnualIncome * 0.15 - HealtExpenditures * 0.5;
            }
            else
            {
                return AnualIncome * 0.25 - HealtExpenditures * 0.5;
            }
        }
    }
}
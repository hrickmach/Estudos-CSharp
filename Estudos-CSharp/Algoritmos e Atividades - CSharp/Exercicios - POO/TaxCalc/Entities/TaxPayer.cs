namespace Entities.TaxCalc
{
    public abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer()
        {
        }
        public TaxPayer(string name, double anualIncome)
        {
            this.Name = name;
            this.AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
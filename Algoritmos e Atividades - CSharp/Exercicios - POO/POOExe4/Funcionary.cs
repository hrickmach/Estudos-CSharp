using System.Globalization;

namespace POOExe4
{
    public class Funcionary
    {
        public string Name;
        public double GrossSalary;
        public double Tax;

        public double LiquidSalary()
        {
            return GrossSalary - Tax;
        }
        public void IncreaseSalary(double percentage)
        {
            GrossSalary += (GrossSalary * percentage / 100.0);
        }
        public override string ToString()
        {
            return Name
            + ", $ "
            + LiquidSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
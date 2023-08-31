namespace POOExe6
{
    public class CurrencyConversion
    {
        public static double Iof = 6.0;

        public static double DolarToReal(double dolarQuote, double qntDolar)
        {
            double total = dolarQuote * qntDolar;
            return total + total * Iof / 100.0;
        }
    }
}
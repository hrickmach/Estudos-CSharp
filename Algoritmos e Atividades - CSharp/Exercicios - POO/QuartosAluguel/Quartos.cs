
namespace QuartosAluguel
{
    public class Quartos
    {
        public string Nome { get; set; }
        public string EMail { get; set; }
        public int Quarto { get; set; }

        public Quartos(string nome, string eMail, int quarto)
        {
            Nome = nome;
            EMail = eMail;
            Quarto = quarto;
        }

        public override string ToString()
        {
            return Quarto
                + ": "
                + Nome
                + ", "
                + EMail;
        }
    }
}
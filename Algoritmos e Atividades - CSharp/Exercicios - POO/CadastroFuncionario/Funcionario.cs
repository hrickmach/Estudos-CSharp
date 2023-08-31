
using System.Globalization;

namespace CadastroFuncionario
{
    public class Funcionario
    {
        public int ID { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            ID = id;
            Nome = nome;
            Salario = salario;
        }

        public void AcrecimoSalario(double porcent)
        {
            Salario += (Salario * porcent / 100.0);
        }

        public override string ToString()
        {
            return ID
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
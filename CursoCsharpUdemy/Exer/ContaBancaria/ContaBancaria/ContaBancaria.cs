using System.Globalization;

namespace ContaBancaria
{
    public class ContaBancaria
    {
        public int Number { get; private set; }
        public string Name { get; set; }
        public double Balance { get; private set; }

        public ContaBancaria(int number, string name)
        {
            Number = number;
            Name = name;
        }

        public ContaBancaria(int number, string name, double balance) : this(number, name)
        {
            Balance = balance;
        }

        public void Deposito(double valor)
        {
            Balance += valor;
        }

        public void Saque(double valor)
        {
            Balance -= valor + 5.0;
        }

        public override string ToString()
        {
            return $"Conta {Number}, Titular: {Name}, Saldo: ${Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

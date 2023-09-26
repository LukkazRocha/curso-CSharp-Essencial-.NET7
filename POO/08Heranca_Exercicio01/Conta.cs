namespace _08Heranca_Exercicio01
{
    public class Conta
    {
        public int Numero { get; set; }
        public string? Titular { get; set; }
        public decimal Saldo { get; set; } = 0.00m;
        public virtual double Juros { get; set; } = 0.00;

        private decimal CalculaRemuneracao(double juros)
        {
            return Saldo * (decimal)juros;
        }

        public virtual decimal Sacar(decimal valor)
        {
            Saldo -= valor;
            return Saldo;
        }

        public decimal Depositar(decimal valor)
        {
            Saldo += valor;
            Saldo += CalculaRemuneracao(Juros);
            return Saldo;
        }
    }
}

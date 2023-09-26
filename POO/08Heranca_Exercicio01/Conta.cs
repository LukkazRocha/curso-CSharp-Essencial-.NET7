namespace _08Heranca_Exercicio01
{
    public class Conta
    {
        public int Numero { get; set; }
        public string? Titular { get; set; }
        public decimal Saldo { get; set; } = 0.0m;
        public virtual double Juros { get; set; } = 0.0;

        public decimal Depositar(decimal valor)
        {
            Saldo += valor;
            return Saldo;
        }

        public decimal Sacar(decimal valor)
        {
            Saldo -= valor;
            return Saldo;
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo: {Saldo:c}");
        }
    }
}

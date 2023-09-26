namespace _08Heranca_Exercicio01
{
    public class ContaInvestimento : Conta
    {
        public override double Juros { get; set; } = 0.009;
        public double Imposto { get; set; } = 0.001;

        private decimal CalculaImposto(double imposto)
        {
            return Saldo * (decimal)imposto;
        }

        public override decimal Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo = Saldo - valor - CalculaImposto(Imposto);
                return Saldo;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente...");
                return Saldo;
            }

        }
    }
}

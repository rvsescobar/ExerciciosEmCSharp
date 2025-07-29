class ContaBancaria
{
    protected double Saldo { get; set; }

    public virtual void Depositar(double valor)
    {
        Saldo += valor;
    }

    public virtual void Sacar(double valor)
    {
        Saldo -= valor;
    }

    public virtual double CalcularSaldo()
    {
        return Saldo;
    }
}

class ContaCorrente : ContaBancaria
{
    private double TaxaManutencao { get; set; }

    public override void Sacar(double valor)
    {
        base.Sacar(valor + TaxaManutencao);
    }
}

class ContaPoupanca : ContaBancaria
{
    private double TaxaRendimento { get; set; }

    public override double CalcularSaldo()
    {
        return base.CalcularSaldo() * (1 + TaxaRendimento);
    }
}
public interface IPagavel
{
    decimal CalcularPagamento();
}

public class Produto : IPagavel
{
    public string Nome { get; set; }
    public decimal PrecoUnitario { get; set; }
    public int Quantidade { get; set; }

    public decimal CalcularPagamento()
    {
        return PrecoUnitario * Quantidade;
    }
}

public class Servico : IPagavel
{
    public string Nome { get; set; }
    public decimal TaxaHoraria { get; set; }
    public int HorasTrabalhadas { get; set; }

    public decimal CalcularPagamento()
    {
        return TaxaHoraria * HorasTrabalhadas;
    }
}
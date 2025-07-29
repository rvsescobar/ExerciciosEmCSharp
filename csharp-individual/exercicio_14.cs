public interface IArmazenavel
{
    void Salvar();
    void Recuperar();
}

public class Arquivo : IArmazenavel
{
    public string NomeArquivo { get; set; }

    public void Salvar()
    {
        Console.WriteLine($"Salvando dados no arquivo {NomeArquivo}.");
    }

    public void Recuperar()
    {
        Console.WriteLine($"Recuperando dados do arquivo {NomeArquivo}.");
    }
}

public class BancoDeDados : IArmazenavel
{
    public string NomeBanco { get; set; }

    public void Salvar()
    {
        Console.WriteLine($"Salvando dados no banco de dados {NomeBanco}.");
    }

    public void Recuperar()
    {
        Console.WriteLine($"Recuperando dados do banco de dados {NomeBanco}.");
    }
}
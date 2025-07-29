public class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public string Placa { get; set; }

    public Veiculo(string marca, string modelo, int ano, string placa)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Placa = placa;
    }
}

public class Cliente
{
    public string Nome { get; set; }
    public string Contato { get; set; }

    public Cliente(string nome, string contato)
    {
        Nome = nome;
        Contato = contato;
    }
}

public class Mecanico
{
    public string Nome { get; set; }
    public string Especialidade { get; set; }

    public Mecanico(string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
    }
}

public class Oficina
{
    private List<Veiculo> veiculosNaOficina;

    public Oficina()
    {
        veiculosNaOficina = new List<Veiculo>();
    }

    public void AgendarServico(Veiculo veiculo, Cliente cliente, Mecanico mecanico, string dataAgendamento)
    {
        veiculosNaOficina.Add(veiculo);

        //Lógica para agendar o serviço (pode ser expandida conforme necessário).
        Console.WriteLine($"Serviço agendado para {veiculo.Placa} em {dataAgendamento} com o mecânico {mecanico.Nome}.");
    }

    public void RealizarServico(Veiculo veiculo, Mecanico mecanico)
    {
        if (veiculosNaOficina.Contains(veiculo))
        {
            Console.WriteLine($"Serviço realizado em {veiculo.Placa} pelo mecânico {mecanico.Nome}.");
            veiculosNaOficina.Remove(veiculo);
        }
        else
        {
            Console.WriteLine($"O veículo {veiculo.Placa} não está na oficina para realizar o serviço.");
        }
    }
}
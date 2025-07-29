public class Pet
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Especie { get; set; }

    public Pet(string nome, int idade, string especie)
    {
        Nome = nome;
        Idade = idade;
        Especie = especie;
    }
}

public class Dono
{
    public string Nome { get; set; }
    public string Contato { get; set; }

    public Dono(string nome, string contato)
    {
        Nome = nome;
        Contato = contato;
    }
}

public class Medico
{
    public string Nome { get; set; }
    public string Especialidade { get; set; }

    public Medico(string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
    }
}

public class Consulta
{
    public Pet Animal { get; set; }
    public Dono DonoAnimal { get; set; }
    public Medico Veterinario { get; set; }
    public string DataConsulta { get; set; }

    public Consulta(Pet animal, Dono dono, Medico veterinario, string dataConsulta)
    {
        Animal = animal;
        DonoAnimal = dono;
        Veterinario = veterinario;
        DataConsulta = dataConsulta;
    }
}

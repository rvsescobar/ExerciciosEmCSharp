class Funcionario
{
    public string Nome { get; set; }
    public double Salario { get; set; }
}

class Gerente : Funcionario
{
    public string Setor { get; set; }
}

class Programador : Funcionario
{
    public string LinguagemDeProgramacao { get; set; }
}

class Analista : Funcionario
{
    public string AreaDeAtuacao { get; set; }
}
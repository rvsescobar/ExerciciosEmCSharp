# _Exercícios em C#_

Este repositório consiste em alguns exercícios básicos de lógica, utilizando a linguagem C#. 
Praticamos aqui a lógica de programação, orientação a objetos, conceitos de herança, interfaces, expressões lambdas, LINQ e integração báscia com APIs.

### 33 exercícios básicos

1) Modelar um Pet Shop com classes como Pet, Dono, Consulta e médico.

```c#
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
```

2) Modelar o funcionamento de uma oficina automobilistica.

```c#
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
```

3) Criar um programa `Program.cs` e simular o funcionamento do programa.

```c#
class Program
{
    static void Main()
    {
        //Criar instâncias de Veiculo, Cliente, Mecanico e Oficina.
        Veiculo meuCarro = new Veiculo("Chevrolet", "Cruze", 2020, "ABC1234");
        Cliente cliente = new Cliente("Carlos", "987654321");
        Mecanico mecanico = new Mecanico("Mário", "Mecânica Geral");
        Oficina oficina = new Oficina();

        //Agendar e realizar um serviço na oficina.
        oficina.AgendarServico(meuCarro, cliente, mecanico, "2023-12-18");
        oficina.RealizarServico(meuCarro, mecanico);
    }
}
```

4) Escrever um programa que funcione como uma calculadora, que pode realizar as 4 operações básicas, além de calcular raiz quadrada e potências. O usuario deve entrar com dois números e um simbolo que represente a operação a ser feita. 

```c#
public class Calculadora
{
    public static double Calcular(double numero1, double numero2, char operacao)
    {
        double resultado = 0;

        switch (operacao)
        {
            case '+':
                resultado = Somar(numero1, numero2);
                break;
            case '-':
                resultado = Subtrair(numero1, numero2);
                break;
            case '*':
                resultado = Multiplicar(numero1, numero2);
                break;
            case '/':
                resultado = Dividir(numero1, numero2);
                break;
            case '^':
                resultado = Potencia(numero1, numero2);
                break;
            case 'r':
                resultado = RaizQuadrada(numero1);
                break;
            default:
                Console.WriteLine("Operação inválida.");
                break;
        }

        return resultado;
    }

    private static double Somar(double a, double b)
    {
        return a + b;
    }

    private static double Subtrair(double a, double b)
    {
        return a - b;
    }

    private static double Multiplicar(double a, double b)
    {
        return a * b;
    }

    private static double Dividir(double a, double b)
    {
        if (b != 0)
            return a / b;
        else
        {
            Console.WriteLine("Erro: Divisão por zero.");
            return 0;
        }
    }

    private static double Potencia(double a, double b)
    {
        return Math.Pow(a, b);
    }

    private static double RaizQuadrada(double a)
    {
        return Math.Sqrt(a);
    }
}
```

5) Criar uma hierarquia de classes representando formas geométricas, como Quadrado, Círculo e Triângulo. Utilize herança para criar uma classe base chamada FormaGeometrica, que contenha métodos para calcular a área e o perímetro de uma forma.

```c#
abstract class FormaGeometrica
{
    public abstract double CalcularArea();
    public abstract double CalcularPerimetro();
}

class Quadrado : FormaGeometrica
{
    public double Lado { get; set; }

    public override double CalcularArea()
    {
        return Lado * Lado;
    }

    public override double CalcularPerimetro()
    {
        return 4 * Lado;
    }
}

class Circulo : FormaGeometrica
{
    public double Raio { get; set; }

    public override double CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }

    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * Raio;
    }
}

class Triangulo : FormaGeometrica
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public override double CalcularArea()
    {
        return 0.5 * Base * Altura;
    }

    public override double CalcularPerimetro()
    {
        //Considerando um triângulo genérico.
        return Base + Altura + Math.Sqrt(Base * Base + Altura * Altura);
    }
}
```

6) Crie uma hierarquia de classes representando funcionários de uma empresa. Utilize herança para criar classes como Gerente, Programador e Analista. Cada classe deve ter propriedades específicas, além das propriedades comuns a todos os funcionários, como Nome e Salário.

```c#
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
```

7) Criar uma hierarquia de classes representando contas bancárias, como ContaCorrente e ContaPoupanca. Utilize herança e o conceito de métodos virtuais para implementar um método CalcularSaldo que retorne o saldo atual da conta.

```c#
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
```

8) Criar uma hierarquia de classes representando animais, como Mamifero, Ave e Peixe. Utilize herança e o conceito de métodos virtuais para implementar um método EmitirSom que represente o som característico de cada tipo de animal.

```c#
class Animal
{
    public virtual string EmitirSom()
    {
        return "Som genérico de animal";
    }
}

class Mamifero : Animal
{
    public override string EmitirSom()
    {
        return "Som de mamífero";
    }
}

class Ave : Animal
{
    public override string EmitirSom()
    {
        return "Som de ave";
    }
}

class Peixe : Animal
{
    public override string EmitirSom()
    {
        return "Som de peixe";
    }
}
```

9) Criar uma hierarquia de classes representando produtos eletrônicos, como Smartphone, Tablet e Laptop. Utilize herança e o conceito de métodos virtuais para implementar um método ExibirInformacoes que retorne informações específicas de cada produto.

```c#
class ProdutoEletronico
{
    public string Modelo { get; set; }
    public double Preco { get; set; }

    public virtual string ExibirInformacoes()
    {
        return $"Modelo: {Modelo}, Preço: {Preco:C}";
    }
}

class Smartphone : ProdutoEletronico
{
    public string SistemaOperacional { get; set; }

    public override string ExibirInformacoes()
    {
        return $"{base.ExibirInformacoes()}, SO: {SistemaOperacional}";
    }
}

class Tablet : ProdutoEletronico
{
    public string TipoTela { get; set; }

    public override string ExibirInformacoes()
    {
        return $"{base.ExibirInformacoes()}, Tela: {TipoTela}";
    }
}

class Laptop : ProdutoEletronico
{
    public string Processador { get; set; }

    public override string ExibirInformacoes()
    {
        return $"{base.ExibirInformacoes()}, Processador: {Processador}";
    }
}
```

10) Criar uma interface chamada IForma que declare métodos para calcular a área e o perímetro de uma forma geométrica. Implemente esta interface em duas classes: Circulo e Retangulo.

```c#
public interface IForma
{
    double CalcularArea();
    double CalcularPerimetro();
}

public class Circulo : IForma
{
    public double Raio { get; set; }

    public double CalcularArea()
    {
        return Math.PI * Math.Pow(Raio, 2);
    }

    public double CalcularPerimetro()
    {
        return 2 * Math.PI * Raio;
    }
}

public class Retangulo : IForma
{
    public double Comprimento { get; set; }
    public double Largura { get; set; }

    public double CalcularArea()
    {
        return Comprimento * Largura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (Comprimento + Largura);
    }
}
```

11) Criar duas interfaces adicionais, IPilotavel e IVoavel. Implemente essas interfaces na classe Veiculo.

```c#
public interface IPilotavel
{
    void Pilotar();
}

public interface IVoavel
{
    void Voar();
}

public class Veiculo : IPilotavel, IVoavel
{
    public void Pilotar()
    {
        Console.WriteLine("Veículo está pilotando");
    }

    public void Voar()
    {
        Console.WriteLine("Veículo está voando");
    }
}
```

12) Criar uma interface chamada IPagavel com um método CalcularPagamento. Implemente essa interface em duas classes, Produto e Servico. O método CalcularPagamento deve retornar o valor total a ser pago, levando em consideração a quantidade para produtos e a taxa horária para serviços.

```c#
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
```

13) Criar uma interface chamada INotificavel com um método EnviarNotificacao. Implemente essa interface em duas classes, Email e SMS. O método EnviarNotificacao deve exibir mensagens diferentes para cada tipo de notificação.

```c#
public interface INotificavel
{
    void EnviarNotificacao();
}

public class Email : INotificavel
{
    public string EnderecoEmail { get; set; }

    public void EnviarNotificacao()
    {
        Console.WriteLine($"Enviando e-mail para {EnderecoEmail}: Notificação importante!");
    }
}

public class SMS : INotificavel
{
    public string NumeroTelefone { get; set; }

    public void EnviarNotificacao()
    {
        Console.WriteLine($"Enviando SMS para {NumeroTelefone}: Notificação importante!");
    }
}
```

14) Criar uma interface chamada IArmazenavel com métodos Salvar e Recuperar. Implemente essa interface em duas classes, Arquivo e BancoDeDados. Os métodos Salvar e Recuperar devem exibir mensagens simulando a ação de salvar e recuperar dados.

```c#
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
```

15) Escrever um programa que faça uam requisição para a API de games **CheapShark** e mostre na tela a lista de promoções cadastrada na ferramenta (Você pode utilizar o endpoint: https://www.cheapshark.com/api/1.0/deals).

```c#
using (HttpClient client = new HttpClient())
{
    string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
    Console.WriteLine(resposta);
}
```

16) Escrever um programa que solicite dois números `a` e `b` lidos do teclado e realize a divisão de `a` por `b`. Caso essa operação não seja possível, mostrar uma mensagem no console  que deixe claro o erro ocorrido.

```c#
try
{
    Console.Write("Digite o numerador: ");
    int numerador = int.Parse(Console.ReadLine());

    Console.Write("Digite o denominador: ");
    int denominador = int.Parse(Console.ReadLine());

    int resultado = numerador / denominador;
    Console.WriteLine($"Resultado: {resultado}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Erro: na matemática não é permitida a divisão por 0.");
}
```

17) Declarar uma lista de inteiros e tente acessar um elemento em um índice inexistente. Tratar a exceção apropriada.

```c#
try
{
    List<int> numeros = new List<int> { 1, 2, 3 };
    Console.WriteLine($"Elemento no índice 5: {numeros[5]}");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}
```

18) Criar uma classe simples com um método e chame esse método em um objeto nulo. Tratar a exceção de método em objeto nulo.

```c#
try
{
    MinhaClasse objetoNulo = null;
    objetoNulo.Meumetodo();
}
catch (NullReferenceException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}
```

19) Modelar e desserializar a classe Filme, que pode ser encontrada no [endpoint disponibilizado](https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json)

Classe Filme:
```c#
using System.Text.Json.Serialization;
namespace Filmes;

internal class Filme
{
    [JsonPropertyName("title")]
    public string? Titulo { get; set; }
    [JsonPropertyName("year")]
    public string? Ano {  get; set; }
    [JsonPropertyName("crew")]
    public string? Elenco { get; set; }
    [JsonPropertyName("imDbRating")]
    public string? Nota { get; set; }
    public string FichaTecnica => $"\n\nTitulo: {Titulo} ({Ano}) - Nota: {Nota}\nElenco: [{Elenco}]\n\n";
}
```
Program.cs:
```c#
using Filmes;

using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
       
        var filmes = JsonSerializer.Deserialize<List<Filme>>(resposta);
        foreach(var filme in filmes)
        {
            Console.WriteLine(filme.FichaTecnica);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
```

20) Modelar e desserializar a classe Pais, que pode ser encontrada no [endpoint disponibilizado](https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json)

Classe Pais:
```c#
namespace Paises;
using System.Text.Json.Serialization;
internal class Pais
{
    [JsonPropertyName("nome")]
    public string? Nome { get; set; }
    [JsonPropertyName("capital")]
    public string? Capital { get; set; }
    [JsonPropertyName("populacao")]
    public int? Populacao { get; set; }
    [JsonPropertyName("continente")]
    public string? Continente { get; set; }
    [JsonPropertyName("idioma")]
    public string? Idioma { get; set; }
    public string Informacoes => $"Pais: {Nome} - Capital: {Capital} - Populacao: {Populacao}";

}
```
Program.cs:
```c#
using Paises;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");

        var paises = JsonSerializer.Deserialize<List<Pais>>(resposta);
        foreach (var pais in paises)
        {
            Console.WriteLine(pais.Informacoes);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
```

21) Modelar e desserializar a classe Carro, que pode ser encontrada no [endpoint disponibilizado](https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json)

Classe Carro:
```c#
using System.Text.Json.Serialization;

namespace Carros;

internal class Carro
{
    [JsonPropertyName("marca")]
    public string? Marca {  get; set; }
    [JsonPropertyName("modelo")]
    public string? Modelo { get; set;}
    [JsonPropertyName("ano")]
    public int? Ano { get; set; }
    [JsonPropertyName("tipo")]
    public string? Tipo { get; set; }

    public string Informacoes => $"Carro {Marca} {Modelo} {Ano} {Tipo}";

}
```
Program.cs:
```c#
using Carros;

using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://github.com/ArthurOcFernandes/Exerc-cios-C-/raw/curso-4-aula-2/Jsons/Carros.json");
       
        var carros = JsonSerializer.Deserialize<List<Carro>>(resposta);
        foreach(var carro in carros)
        {
            Console.WriteLine(carro.Informacoes);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
```

22) Modelar e desserializar a classe Livro, que pode ser encontrada no [endpoint disponibilizado](https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json)

classe Livro:
```c#
using System.Text.Json.Serialization;

namespace Livros;

internal class Livro
{

    [JsonPropertyName("titulo")]
    public string? Titulo { get; set; }
    [JsonPropertyName("autor")]
    public string? Autor {  get; set; }
    [JsonPropertyName("ano_publicacao")]
    public int? Ano { get; set; }
    [JsonPropertyName("genero")]
    public string? Genero { get; set; }

    public string FichaTecnica => $"Titulo: {Titulo}\nAutor: {Autor}\nAno: {Ano}\nGenero: {Genero}\n\n";
}
```
Program.cs:
```c#
using Livros;

using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://github.com/ArthurOcFernandes/Exerc-cios-C-/raw/curso-4-aula-2/Jsons/Livros.json");
       
        var livros = JsonSerializer.Deserialize<List<Livro>>(resposta);
        foreach(var livro in livros)
        {
            Console.WriteLine(livro.FichaTecnica);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
```

23) Dada uma lista de números, criar uma consulta LINQ para retornar apenas os elementos únicos da lista.

```c#
List<int> numeros = new List<int> { 1, 2, 3, 2, 4, 5, 3, 6, 7, 8, 9, 1 };

var numerosUnicos = numeros.Distinct();

Console.WriteLine("Números únicos na lista:");
foreach (var numero in numerosUnicos)
{
    Console.Write(numero + " ");
}
```

24) Dadas duas listas de números, criar uma consulta LINQ para retornar uma lista que contenha apenas os números que estão presentes em ambas as listas. 

```c#
List<int> lista1 = new List<int> { 1, 2, 3, 4, 5 };
List<int> lista2 = new List<int> { 3, 4, 5, 6, 7 };

var numerosComuns = lista1.Intersect(lista2);

Console.WriteLine("Números presentes em ambas as listas:");
foreach (var numero in numerosComuns)
{
    Console.Write(numero + " ");
}
```

25) Dada uma lista de livros com título, autor e ano de publicação, criar uma consulta LINQ para retornar uma lista com os títulos dos livros publicados após o ano 2000, ordenados alfabeticamente.

Classe Livro
```c#
class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }
}
```

```c#
List<Livro> livros = new List<Livro>
{
    new Livro { Titulo = "Aprendendo LINQ", Autor = "João Silva", AnoPublicacao = 2005 },
    new Livro { Titulo = "Programação em C#", Autor = "Ana Oliveira", AnoPublicacao = 2010 },
    new Livro { Titulo = "Algoritmos e Estruturas de Dados", Autor = "Carlos Santos", AnoPublicacao = 1998 },
    new Livro { Titulo = "Introdução à Inteligência Artificial", Autor = "Mariana Costa", AnoPublicacao = 2021 },
    new Livro { Titulo = "Design Patterns", Autor = "Paulo Rocha", AnoPublicacao = 2002 }
};

var titulosLivros = livros
    .Where(l => l.AnoPublicacao > 2000)
    .OrderBy(l => l.Titulo)
    .Select(l => l.Titulo);

Console.WriteLine("Títulos de livros publicados após 2000, ordenados alfabeticamente:");
foreach (var titulo in titulosLivros)
{
    Console.WriteLine(titulo);
}
```

26) Dada uma lista de produtos com nome e preço, criar uma consulta LINQ para calcular o preço médio dos produtos.

classe Produto:
```c#
class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}
```
main:
```c#
List<Produto> produtos = new List<Produto>
        {
            new Produto { Nome = "Laptop", Preco = 1200 },
            new Produto { Nome = "Smartphone", Preco = 800 },
            new Produto { Nome = "Tablet", Preco = 500 },
            new Produto { Nome = "Câmera", Preco = 300 }
        };

        var precoMedio = produtos.Average(p => p.Preco);

        Console.WriteLine("Preço médio dos produtos: " + precoMedio);
```

27) Dada uma lista de strings, criar uma consulta LINQ para ordenar as palavras por comprimento e retornar apenas aquelas que têm mais de 3 caracteres.

```c#
List<string> palavras = new List<string> { "cachorro", "gato", "elefante", "leão", "cobra" };

var palavrasFiltradas = palavras.Where(p => p.Length > 3).OrderBy(p => p.Length);

Console.WriteLine("Palavras com mais de 3 caracteres, ordenadas por comprimento:");
foreach (var palavra in palavrasFiltradas)
{
    Console.Write(palavra + " ");
}
```

28) Dada uma lista de inteiros, criar uma consulta LINQ para retornar apenas os números pares.

```c#
List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var numerosPares = numeros.Where(x => x % 2 == 0);

Console.WriteLine("Números Pares:");
foreach (var numero in numerosPares)
{
    Console.Write(numero + " ");
}
```

29) Criar um programa que permite ao usuário inserir informações de uma pessoa (nome, idade, e e-mail), serializa essas informações em formato JSON e salva em um arquivo.

```c#
using System;
using System.IO;
using System.Text.Json;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main()
    {
        //Criar uma instância de Pessoa e obter informações do usuário.
        Pessoa pessoa = new Pessoa();
        Console.Write("Digite o nome: ");
        pessoa.Nome = Console.ReadLine();
        Console.Write("Digite a idade: ");
        pessoa.Idade = int.Parse(Console.ReadLine());
        Console.Write("Digite o e-mail: ");
        pessoa.Email = Console.ReadLine();

        //Serializar a pessoa em JSON.
        string jsonString = JsonSerializer.Serialize(pessoa);

        //Nome do arquivo para salvar.
        string fileName = "pessoa.json";

        //Escrever JSON no arquivo.
        File.WriteAllText(fileName, jsonString);

        Console.WriteLine($"Os dados foram salvos em {fileName}");
    }
}
```

30) Criar um programa que lê um arquivo JSON contendo informações de uma pessoa, desserializa essas informações e exibe na tela.

```c#
using System;
using System.IO;
using System.Text.Json;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main()
    {
        //Nome do arquivo para ler.
        string fileName = "pessoa.json";

        //Verificar se o arquivo existe.
        if (File.Exists(fileName))
        {
            //Ler conteúdo do arquivo JSON.
            string jsonString = File.ReadAllText(fileName);

            //Desserializar JSON para objeto Pessoa.
            Pessoa pessoa = JsonSerializer.Deserialize<Pessoa>(jsonString);

            //Exibir informações da pessoa.
            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Idade: {pessoa.Idade}");
            Console.WriteLine($"E-mail: {pessoa.Email}");
        }
        else
        {
            Console.WriteLine($"O arquivo {fileName} não existe.");
        }
    }
}
```

31) Criar um programa que permite ao usuário inserir informações de várias pessoas, armazena essas informações em uma lista, serializa a lista em formato JSON e salva em um arquivo.

```c#
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main()
    {
        //Criar uma lista de pessoas.
        List<Pessoa> pessoas = new List<Pessoa>();

        //Permitir ao usuário inserir informações de várias pessoas.
        while (true)
        {
            Pessoa pessoa = new Pessoa();
            Console.Write("Digite o nome (ou 'sair' para encerrar): ");
            string nome = Console.ReadLine();

            if (nome.ToLower() == "sair")
                break;

            pessoa.Nome = nome;

            Console.Write("Digite a idade: ");
            pessoa.Idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o e-mail: ");
            pessoa.Email = Console.ReadLine();

            //Adicionar pessoa à lista.
            pessoas.Add(pessoa);
        }

        //Serializar a lista em JSON.
        string jsonString = JsonSerializer.Serialize(pessoas);

        //Nome do arquivo para salvar.
        string fileName = "pessoas.json";

        //Escrever JSON no arquivo.
        File.WriteAllText(fileName, jsonString);

        Console.WriteLine($"Os dados foram salvos em {fileName}");
    }
}
```

32) Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, desserializa essas informações em uma lista e exibe na tela.

```C#
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main()
    {
        //Nome do arquivo para ler.
        string fileName = "pessoas.json";

        //Verificar se o arquivo existe.
        if (File.Exists(fileName))
        {
            //Ler conteúdo do arquivo JSON.
            string jsonString = File.ReadAllText(fileName);

            //Desserializar JSON para lista de pessoas.
            List<Pessoa> pessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString);

            //Exibir informações das pessoas.
            Console.WriteLine("Informações das Pessoas:");

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, E-mail: {pessoa.Email}");
            }
        }
        else
        {
            Console.WriteLine($"O arquivo {fileName} não existe.");
        }
    }
}
```

33) Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, permite ao usuário inserir uma idade e exibe as pessoas com aquela idade.

R: 

```c#
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main()
    {
        //Nome do arquivo para ler.
        string fileName = "pessoas.json";

        //Verificar se o arquivo existe.
        if (File.Exists(fileName))
        {
            //Ler conteúdo do arquivo JSON.
            string jsonString = File.ReadAllText(fileName);

            //Desserializar JSON para lista de pessoas.
            List<Pessoa> pessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString);

            //Permitir ao usuário inserir uma idade.
            Console.Write("Digite a idade para buscar pessoas: ");
            int idadeParaBuscar = int.Parse(Console.ReadLine());

            //Filtrar pessoas com a idade especificada.
            List<Pessoa> pessoasComIdade = pessoas.Where(p => p.Idade == idadeParaBuscar).ToList();

            if (pessoasComIdade.Any())
            {
                //Exibir informações das pessoas com a idade especificada.
                Console.WriteLine($"Pessoas com {idadeParaBuscar} anos:");

                foreach (Pessoa pessoa in pessoasComIdade)
                {
                    Console.WriteLine($"Nome: {pessoa.Nome}, E-mail: {pessoa.Email}");
                }
            }
            else
            {
                Console.WriteLine($"Nenhuma pessoa encontrada com {idadeParaBuscar} anos.");
            }
        }
        else
        {
            Console.WriteLine($"O arquivo {fileName} não existe.");
        }
    }
}
```
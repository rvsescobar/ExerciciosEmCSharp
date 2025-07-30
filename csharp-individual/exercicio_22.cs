//Classe Livros

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

//Program

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
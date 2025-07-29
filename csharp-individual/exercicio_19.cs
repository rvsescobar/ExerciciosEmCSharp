//Classe Filme

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

//Program.cs

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
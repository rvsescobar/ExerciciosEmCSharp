//Classe Pais

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

//Program.cs

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
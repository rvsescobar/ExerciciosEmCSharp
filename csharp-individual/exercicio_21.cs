//Classe Carro

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

//Program

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
List<string> palavras = new List<string> { "cachorro", "gato", "elefante", "leão", "cobra" };

var palavrasFiltradas = palavras.Where(p => p.Length > 3).OrderBy(p => p.Length);

Console.WriteLine("Palavras com mais de 3 caracteres, ordenadas por comprimento:");
foreach (var palavra in palavrasFiltradas)
{
    Console.Write(palavra + " ");
}
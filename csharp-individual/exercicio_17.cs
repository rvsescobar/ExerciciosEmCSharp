try
{
    List<int> numeros = new List<int> { 1, 2, 3 };
    Console.WriteLine($"Elemento no índice 5: {numeros[5]}");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}
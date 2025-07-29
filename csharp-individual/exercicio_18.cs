try
{
    MinhaClasse objetoNulo = null;
    objetoNulo.Meumetodo();
}
catch (NullReferenceException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}
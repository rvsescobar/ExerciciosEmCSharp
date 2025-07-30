List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var numerosPares = numeros.Where(x => x % 2 == 0);

Console.WriteLine("Números Pares:");
foreach (var numero in numerosPares)
{
    Console.Write(numero + " ");
}
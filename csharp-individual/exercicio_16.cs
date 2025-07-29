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
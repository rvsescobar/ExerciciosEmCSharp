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
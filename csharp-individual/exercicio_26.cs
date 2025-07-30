//Classe Produto

class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}

//main

List<Produto> produtos = new List<Produto>
{
    new Produto { Nome = "Laptop", Preco = 1200 },
    new Produto { Nome = "Smartphone", Preco = 800 },
    new Produto { Nome = "Tablet", Preco = 500 },
    new Produto { Nome = "Câmera", Preco = 300 }
};

var precoMedio = produtos.Average(p => p.Preco);

Console.WriteLine("Preço médio dos produtos: " + precoMedio);
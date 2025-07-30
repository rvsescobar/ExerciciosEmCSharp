using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main()
    {
        //Criar uma lista de pessoas.
        List<Pessoa> pessoas = new List<Pessoa>();

        //Permitir ao usuário inserir informações de várias pessoas.
        while (true)
        {
            Pessoa pessoa = new Pessoa();
            Console.Write("Digite o nome (ou 'sair' para encerrar): ");
            string nome = Console.ReadLine();

            if (nome.ToLower() == "sair")
                break;

            pessoa.Nome = nome;

            Console.Write("Digite a idade: ");
            pessoa.Idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o e-mail: ");
            pessoa.Email = Console.ReadLine();

            //Adicionar pessoa à lista.
            pessoas.Add(pessoa);
        }

        //Serializar a lista em JSON.
        string jsonString = JsonSerializer.Serialize(pessoas);

        //Nome do arquivo para salvar.
        string fileName = "pessoas.json";

        //Escrever JSON no arquivo.
        File.WriteAllText(fileName, jsonString);

        Console.WriteLine($"Os dados foram salvos em {fileName}");
    }
}
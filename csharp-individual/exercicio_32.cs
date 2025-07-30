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
        //Nome do arquivo para ler.
        string fileName = "pessoas.json";

        //Verificar se o arquivo existe.
        if (File.Exists(fileName))
        {
            //Ler conteúdo do arquivo JSON.
            string jsonString = File.ReadAllText(fileName);

            //Desserializar JSON para lista de pessoas.
            List<Pessoa> pessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString);

            //Exibir informações das pessoas.
            Console.WriteLine("Informações das Pessoas:");

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, E-mail: {pessoa.Email}");
            }
        }
        else
        {
            Console.WriteLine($"O arquivo {fileName} não existe.");
        }
    }
}
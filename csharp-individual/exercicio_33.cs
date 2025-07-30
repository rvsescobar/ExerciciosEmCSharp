using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

            //Permitir ao usuário inserir uma idade.
            Console.Write("Digite a idade para buscar pessoas: ");
            int idadeParaBuscar = int.Parse(Console.ReadLine());

            //Filtrar pessoas com a idade especificada.
            List<Pessoa> pessoasComIdade = pessoas.Where(p => p.Idade == idadeParaBuscar).ToList();

            if (pessoasComIdade.Any())
            {
                //Exibir informações das pessoas com a idade especificada.
                Console.WriteLine($"Pessoas com {idadeParaBuscar} anos:");

                foreach (Pessoa pessoa in pessoasComIdade)
                {
                    Console.WriteLine($"Nome: {pessoa.Nome}, E-mail: {pessoa.Email}");
                }
            }
            else
            {
                Console.WriteLine($"Nenhuma pessoa encontrada com {idadeParaBuscar} anos.");
            }
        }
        else
        {
            Console.WriteLine($"O arquivo {fileName} não existe.");
        }
    }
}
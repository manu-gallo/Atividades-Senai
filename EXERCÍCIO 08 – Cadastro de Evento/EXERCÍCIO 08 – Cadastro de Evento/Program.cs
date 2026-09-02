// EXERCÍCIO 08 - CADASTRO DE EVENTO

using System;

// Método Principal
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("================================");
        Console.WriteLine("CADASTRO DE EVENTO");
        Console.WriteLine("================================");
        Console.WriteLine();

        // Declaração de Variáveis
        string nome;
        string local;
        string data;
        int quantidadeParticipantes;
        double valorIngresso;
        bool gratuito;

        // Entrada do nome
        Console.Write("Digite o nome do evento: ");
        nome = Console.ReadLine();

        // Entrada do local
        Console.Write("Digite o local: ");
        local = Console.ReadLine();

        // Entrada da data
        Console.Write("Digite a data: ");
        data = Console.ReadLine();

        // Entrada da quantidade de participantes
        Console.Write("Digite a quantidade de participantes: ");
        quantidadeParticipantes = int.Parse(Console.ReadLine());

        // Entrada do valor do ingresso
        Console.Write("Digite o valor do ingresso: ");
        valorIngresso = double.Parse(Console.ReadLine());

        // Entrada se é gratuito
        Console.Write("O evento é gratuito? (true/false): ");
        gratuito = bool.Parse(Console.ReadLine());

        // Apresentação dos dados cadastrados
        Console.WriteLine();
        Console.WriteLine("================================");
        Console.WriteLine("DADOS CADASTRADOS");
        Console.WriteLine("================================");
        Console.WriteLine($"Evento: {nome}");
        Console.WriteLine($"Local: {local}");
        Console.WriteLine($"Data: {data}");
        Console.WriteLine($"Quantidade de participantes: {quantidadeParticipantes}");
        Console.WriteLine($"Valor do ingresso: {valorIngresso}");
        Console.WriteLine($"Gratuito: {gratuito}");

        Console.WriteLine();
        Console.WriteLine("Cadastro realizado com sucesso!");

        // Finalização do programa
        Console.ReadKey();
    }
}

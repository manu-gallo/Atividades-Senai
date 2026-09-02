// EXERCÍCIO 04 - CADASTRO DE FILME

using System;

// Método Principal
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("================================");
        Console.WriteLine("CADASTRO DE FILME");
        Console.WriteLine("================================");
        Console.WriteLine();

        // Declaração de Variáveis
        string nome;
        string diretor;
        int anoLancamento;
        int duracao;
        double nota;
        bool assistido;

        // Entrada do nome
        Console.Write("Digite o nome do filme: ");
        nome = Console.ReadLine();

        // Entrada do diretor
        Console.Write("Digite o nome do diretor: ");
        diretor = Console.ReadLine();

        // Entrada do ano de lançamento
        Console.Write("Digite o ano de lançamento: ");
        anoLancamento = int.Parse(Console.ReadLine());

        // Entrada da duração
        Console.Write("Digite a duração em minutos: ");
        duracao = int.Parse(Console.ReadLine());

        // Entrada da nota
        Console.Write("Digite a nota do filme: ");
        nota = double.Parse(Console.ReadLine());

        // Entrada se foi assistido
        Console.Write("O filme já foi assistido? (true/false): ");
        assistido = bool.Parse(Console.ReadLine());

        // Apresentação dos dados cadastrados
        Console.WriteLine();
        Console.WriteLine("================================");
        Console.WriteLine("DADOS CADASTRADOS");
        Console.WriteLine("================================");
        Console.WriteLine($"Filme: {nome}");
        Console.WriteLine($"Diretor: {diretor}");
        Console.WriteLine($"Ano de lançamento: {anoLancamento}");
        Console.WriteLine($"Duração: {duracao} minutos");
        Console.WriteLine($"Nota: {nota}");
        Console.WriteLine($"Assistido: {assistido}");

        Console.WriteLine();
        Console.WriteLine("Cadastro realizado com sucesso!");

        // Finalização do programa
        Console.ReadKey();
    }
}

// EXERCÍCIO 07 - CADASTRO DE JOGO

using System;

// Método Principal
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("================================");
        Console.WriteLine("CADASTRO DE JOGO");
        Console.WriteLine("================================");
        Console.WriteLine();

        // Declaração de Variáveis
        string nome;
        string plataforma;
        int anoLancamento;
        double preco;
        int quantidadeJogadores;
        bool instalado;

        // Entrada do nome
        Console.Write("Digite o nome do jogo: ");
        nome = Console.ReadLine();

        // Entrada da plataforma
        Console.Write("Digite a plataforma: ");
        plataforma = Console.ReadLine();

        // Entrada do ano de lançamento
        Console.Write("Digite o ano de lançamento: ");
        anoLancamento = int.Parse(Console.ReadLine());

        // Entrada do preço
        Console.Write("Digite o preço: ");
        preco = double.Parse(Console.ReadLine());

        // Entrada da quantidade de jogadores
        Console.Write("Digite a quantidade de jogadores: ");
        quantidadeJogadores = int.Parse(Console.ReadLine());

        // Entrada se está instalado
        Console.Write("O jogo está instalado? (true/false): ");
        instalado = bool.Parse(Console.ReadLine());

        // Apresentação dos dados cadastrados
        Console.WriteLine();
        Console.WriteLine("================================");
        Console.WriteLine("DADOS CADASTRADOS");
        Console.WriteLine("================================");
        Console.WriteLine($"Jogo: {nome}");
        Console.WriteLine($"Plataforma: {plataforma}");
        Console.WriteLine($"Ano de lançamento: {anoLancamento}");
        Console.WriteLine($"Preço: {preco}");
        Console.WriteLine($"Quantidade de jogadores: {quantidadeJogadores}");
        Console.WriteLine($"Instalado: {instalado}");

        Console.WriteLine();
        Console.WriteLine("Cadastro realizado com sucesso!");

        // Finalização do programa
        Console.ReadKey();
    }
}

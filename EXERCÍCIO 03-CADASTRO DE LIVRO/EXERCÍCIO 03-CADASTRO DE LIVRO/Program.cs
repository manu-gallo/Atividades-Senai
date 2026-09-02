// EXERCÍCIO 03 - CADASTRO DE LIVRO

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("================================");
        Console.WriteLine("CADASTRO DE LIVRO");
        Console.WriteLine("================================");
        Console.WriteLine();

        // Declaração de Variáveis
        string titulo;
        string autor;
        int anoPublicacao;
        int numeroPaginas;
        double preco;
        bool disponivel;

        // Entrada do título
        Console.Write("Digite o título do livro: ");
        titulo = Console.ReadLine();

        // Entrada do autor
        Console.Write("Digite o nome do autor: ");
        autor = Console.ReadLine();

        // Entrada do ano
        Console.Write("Digite o ano de publicação: ");
        anoPublicacao = int.Parse(Console.ReadLine());

        // Entrada do número de páginas
        Console.Write("Digite o número de páginas: ");
        numeroPaginas = int.Parse(Console.ReadLine());

        // Entrada do preço
        Console.Write("Digite o preço: ");
        preco = double.Parse(Console.ReadLine());

        // Entrada da disponibilidade
        Console.Write("O livro está disponível? (true/false): ");
        disponivel = bool.Parse(Console.ReadLine());

        // Apresentação dos dados cadastrados
        Console.WriteLine();
        Console.WriteLine("================================");
        Console.WriteLine("DADOS CADASTRADOS");
        Console.WriteLine("================================");
        Console.WriteLine($"Título: {titulo}");
        Console.WriteLine($"Autor: {autor}");
        Console.WriteLine($"Ano de publicação: {anoPublicacao}");
        Console.WriteLine($"Número de páginas: {numeroPaginas}");
        Console.WriteLine($"Preço: {preco}");
        Console.WriteLine($"Disponível: {disponivel}");

        Console.WriteLine();
        Console.WriteLine("Cadastro realizado com sucesso!");

        // Finalização do programa
        Console.ReadKey();
    }
}

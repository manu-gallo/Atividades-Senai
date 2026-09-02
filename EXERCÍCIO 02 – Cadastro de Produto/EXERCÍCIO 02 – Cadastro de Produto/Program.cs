// EXERCÍCIO 02 - CADASTRO DE PRODUTO

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("================================");
        Console.WriteLine("CADASTRO DE PRODUTO");
        Console.WriteLine("================================");
        Console.WriteLine();

        // Declaração de Variáveis
        string nome;
        int codigo;
        string categoria;
        double preco;
        int quantidade;
        bool disponivel;

        // Entrada do nome
        Console.Write("Digite o nome do produto: ");
        nome = Console.ReadLine();

        // Entrada do código
        Console.Write("Digite o código do produto: ");
        codigo = int.Parse(Console.ReadLine());

        // Entrada da categoria
        Console.Write("Digite a categoria: ");
        categoria = Console.ReadLine();

        // Entrada do preço
        Console.Write("Digite o preço: ");
        preco = double.Parse(Console.ReadLine());

        // Entrada da quantidade
        Console.Write("Digite a quantidade em estoque: ");
        quantidade = int.Parse(Console.ReadLine());

        // Entrada da disponibilidade
        Console.Write("O produto está disponível? (true/false): ");
        disponivel = bool.Parse(Console.ReadLine());

        // Apresentação dos dados cadastrados
        Console.WriteLine();
        Console.WriteLine("================================");
        Console.WriteLine("DADOS CADASTRADOS");
        Console.WriteLine("================================");
        Console.WriteLine($"Produto: {nome}");
        Console.WriteLine($"Código: {codigo}");
        Console.WriteLine($"Categoria: {categoria}");
        Console.WriteLine($"Preço: {preco}");
        Console.WriteLine($"Quantidade: {quantidade}");
        Console.WriteLine($"Disponível: {disponivel}");

        Console.WriteLine();
        Console.WriteLine("Cadastro realizado com sucesso!");

        // Finalização do programa
        Console.ReadKey();
    }
}

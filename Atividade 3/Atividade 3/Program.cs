// SISTEMA PARA CADASTRAR PRODUTOS
using System;

class Program
{
    static void Main(string[] args)
    {
        // Variáveis
        string nome;
        int codigoProduto;
        string categoria;
        double preco;
        int quantidade;
        bool disponivel;

        // Entrada de dados
        Console.WriteLine("=================================");
        Console.WriteLine("       CADASTRO DE PRODUTO");
        Console.WriteLine("=================================");

        Console.Write("Digite o nome do produto: ");
        nome = Console.ReadLine();

        Console.Write("Digite o código do produto: ");
        codigoProduto = int.Parse(Console.ReadLine());

        Console.Write("Digite a categoria do produto: ");
        categoria = Console.ReadLine();

        Console.Write("Digite o preço do produto: ");
        preco = double.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade em estoque: ");
        quantidade = int.Parse(Console.ReadLine());

        Console.Write("O produto está disponível? (true/false): ");
        disponivel = bool.Parse(Console.ReadLine());

        // Saída de dados
        Console.WriteLine();
        Console.WriteLine("=================================");
        Console.WriteLine("       PRODUTO CADASTRADO");
        Console.WriteLine("=================================");

        Console.WriteLine("Nome do produto: " + nome);
        Console.WriteLine("Código do produto: " + codigoProduto);
        Console.WriteLine("Categoria do produto: " + categoria);
        Console.WriteLine("Preço do produto: " + preco);
        Console.WriteLine("Quantidade em estoque: " + quantidade);
        Console.WriteLine("Disponível: " + disponivel);
    }
}

using System;

class Program
{
    static void Main()
    {
        //CADASTRO DE PRODUTO

        Console.WriteLine("=================================");
        Console.WriteLine("      CADASTRO DE PRODUTO");
        Console.WriteLine("=================================");

        Console.Write("Nome do produto: ");
        string produto = Console.ReadLine();

        Console.Write("Código do produto: ");
        int codigo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Categoria: ");
        string categoria = Console.ReadLine();

        Console.Write("Preço: ");
        double preco = Convert.ToDouble(Console.ReadLine());

        Console.Write("Quantidade em estoque: ");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        Console.Write("O produto está disponível? (true/false): ");
        bool disponivel = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("=================================");
        Console.WriteLine("      DADOS DO PRODUTO");
        Console.WriteLine("=================================");

        Console.WriteLine("Produto: " + produto);
        Console.WriteLine("Código: " + codigo);
        Console.WriteLine("Categoria: " + categoria);
        Console.WriteLine("Preço: R$ " + preco);
        Console.WriteLine("Quantidade: " + quantidade);
        Console.WriteLine("Disponível: " + disponivel);

        Console.ReadKey();
    }
}
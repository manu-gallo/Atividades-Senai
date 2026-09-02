// EXERCÍCIO 06 - CADASTRO DE VEÍCULO

using System;

// Método Principal
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("================================");
        Console.WriteLine("CADASTRO DE VEÍCULO");
        Console.WriteLine("================================");
        Console.WriteLine();

        // Declaração de Variáveis
        string marca;
        string modelo;
        int ano;
        string cor;
        double preco;
        bool disponivel;

        // Entrada da marca
        Console.Write("Digite a marca: ");
        marca = Console.ReadLine();

        // Entrada do modelo
        Console.Write("Digite o modelo: ");
        modelo = Console.ReadLine();

        // Entrada do ano
        Console.Write("Digite o ano: ");
        ano = int.Parse(Console.ReadLine());

        // Entrada da cor
        Console.Write("Digite a cor: ");
        cor = Console.ReadLine();

        // Entrada do preço
        Console.Write("Digite o preço: ");
        preco = double.Parse(Console.ReadLine());

        // Entrada da disponibilidade
        Console.Write("O veículo está disponível para venda? (true/false): ");
        disponivel = bool.Parse(Console.ReadLine());

        // Apresentação dos dados cadastrados
        Console.WriteLine();
        Console.WriteLine("================================");
        Console.WriteLine("DADOS CADASTRADOS");
        Console.WriteLine("================================");
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Ano: {ano}");
        Console.WriteLine($"Cor: {cor}");
        Console.WriteLine($"Preço: {preco}");
        Console.WriteLine($"Disponível: {disponivel}");

        Console.WriteLine();
        Console.WriteLine("Cadastro realizado com sucesso!");

        // Finalização do programa
        Console.ReadKey();
    }
}


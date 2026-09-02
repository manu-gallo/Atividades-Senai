// EXERCÍCIO 05 - CADASTRO DE FUNCIONÁRIO

using System;

// Método Principal
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("================================");
        Console.WriteLine("CADASTRO DE FUNCIONÁRIO");
        Console.WriteLine("================================");
        Console.WriteLine();

        // Declaração de Variáveis
        string nome;
        string cargo;
        int idade;
        double salario;
        string cidade;
        bool ativo;

        // Entrada do nome
        Console.Write("Digite o nome: ");
        nome = Console.ReadLine();

        // Entrada do cargo
        Console.Write("Digite o cargo: ");
        cargo = Console.ReadLine();

        // Entrada da idade
        Console.Write("Digite a idade: ");
        idade = int.Parse(Console.ReadLine());

        // Entrada do salário
        Console.Write("Digite o salário: ");
        salario = double.Parse(Console.ReadLine());

        // Entrada da cidade
        Console.Write("Digite a cidade: ");
        cidade = Console.ReadLine();

        // Entrada se está ativo
        Console.Write("O funcionário está ativo na empresa? (true/false): ");
        ativo = bool.Parse(Console.ReadLine());

        // Apresentação dos dados cadastrados
        Console.WriteLine();
        Console.WriteLine("================================");
        Console.WriteLine("FICHA DO FUNCIONÁRIO");
        Console.WriteLine("================================");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Cargo: {cargo}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Salário: {salario}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Ativo: {ativo}");

        Console.WriteLine();
        Console.WriteLine("Cadastro realizado com sucesso!");

        // Finalização do programa
        Console.ReadKey();
    }
}

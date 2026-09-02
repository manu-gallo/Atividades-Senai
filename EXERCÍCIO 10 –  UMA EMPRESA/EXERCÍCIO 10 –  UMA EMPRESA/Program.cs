// EXERCÍCIO 10 - CADASTRO DE EMPRESA

using System;

// Método Principal
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("================================");
        Console.WriteLine("CADASTRO DE EMPRESA");
        Console.WriteLine("================================");
        Console.WriteLine();

        // Declaração de Variáveis
        string nomeEmpresa;
        string cnpj;
        string cidade;
        string responsavel;
        int numeroFuncionarios;
        double faturamentoMensal;
        bool ativa;

        // Entrada do nome da empresa
        Console.Write("Digite o nome da empresa: ");
        nomeEmpresa = Console.ReadLine();

        // Entrada do CNPJ
        Console.Write("Digite o CNPJ: ");
        cnpj = Console.ReadLine();

        // Entrada da cidade
        Console.Write("Digite a cidade: ");
        cidade = Console.ReadLine();

        // Entrada do responsável
        Console.Write("Digite o nome do responsável: ");
        responsavel = Console.ReadLine();

        // Entrada do número de funcionários
        Console.Write("Digite o número de funcionários: ");
        numeroFuncionarios = int.Parse(Console.ReadLine());

        // Entrada do faturamento mensal
        Console.Write("Digite o faturamento mensal: ");
        faturamentoMensal = double.Parse(Console.ReadLine());

        // Entrada se a empresa está ativa
        Console.Write("A empresa está ativa? (true/false): ");
        ativa = bool.Parse(Console.ReadLine());

        // Apresentação dos dados cadastrados
        Console.WriteLine();
        Console.WriteLine("================================");
        Console.WriteLine("DADOS DA EMPRESA");
        Console.WriteLine("================================");
        Console.WriteLine($"Nome da empresa: {nomeEmpresa}");
        Console.WriteLine($"CNPJ: {cnpj}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Responsável: {responsavel}");
        Console.WriteLine($"Número de funcionários: {numeroFuncionarios}");
        Console.WriteLine($"Faturamento mensal: {faturamentoMensal}");
        Console.WriteLine($"Empresa ativa: {ativa}");

        Console.WriteLine();
        Console.WriteLine("Cadastro realizado com sucesso!");

        // Finalização do programa
        Console.ReadKey();
    }
}

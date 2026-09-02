// EXERCÍCIO 09 - PERFIL DE USUÁRIO

using System;

// Método Principal
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("================================");
        Console.WriteLine("PERFIL DO USUÁRIO");
        Console.WriteLine("================================");
        Console.WriteLine();

        // Declaração de Variáveis
        string nome;
        string usuario;
        int idade;
        string cidade;
        double altura;
        bool perfilAtivo;

        // Entrada do nome
        Console.Write("Digite o nome: ");
        nome = Console.ReadLine();

        // Entrada do nome de usuário
        Console.Write("Digite o nome de usuário: ");
        usuario = Console.ReadLine();

        // Entrada da idade
        Console.Write("Digite a idade: ");
        idade = int.Parse(Console.ReadLine());

        // Entrada da cidade
        Console.Write("Digite a cidade: ");
        cidade = Console.ReadLine();

        // Entrada da altura
        Console.Write("Digite a altura: ");
        altura = double.Parse(Console.ReadLine());

        // Entrada se o perfil está ativo
        Console.Write("O perfil está ativo? (true/false): ");
        perfilAtivo = bool.Parse(Console.ReadLine());

        // Apresentação dos dados cadastrados
        Console.WriteLine();
        Console.WriteLine("================================");
        Console.WriteLine("PERFIL DO USUÁRIO");
        Console.WriteLine("================================");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Usuário: {usuario}");
        Console.WriteLine($"Idade: {idade} anos");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Altura: {altura} metros");
        Console.WriteLine($"Perfil ativo: {perfilAtivo}");

        Console.WriteLine();
        Console.WriteLine("Cadastro realizado com sucesso!");

        // Finalização do programa
        Console.ReadKey();
    }
}

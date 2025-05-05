// Arquivo: Exercicio1.cs
using System;
using System.Globalization;
class Exercicio1
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 1 - Leitura de dados do usuário");
  
            Console.WriteLine("Digite seu nome Completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa: ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o preço do seu aluguel: ");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Seu nome é " + nome + " na sua casa tem " + quartos + " quartos e seu aluguel é de: " + preco.ToString("F2", CultureInfo.InvariantCulture) + " Reais.");

            Console.WriteLine("Me diga seu sobrenome, idade e altura (pressione enter após preencher todos os dados): ");

            string[] vet = Console.ReadLine().Split(' ');

            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Seu sobrenome é " + sobrenome + " você tem " + idade + " anos e tem " + altura.ToString("F2", CultureInfo.InvariantCulture) + " de altura.");

        
    }
}
    

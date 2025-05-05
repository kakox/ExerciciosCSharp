// Arquivo: Exercicio12.cs
using System;
using System.Globalization;
class Exercicio12
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 12 - Média e elementos abaixo dela");

        int n;
        Console.WriteLine("Com quantos numeros quer trabalhar?");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite os numeros utilizando espaço para separa-los, assim que finalizar pressione enter: ");
        double[] vet = new double[n];
        string[] valores = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++)
        {
            vet[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
        }

        double soma = 0;

        for (int i = 0; i < n; i++)
        {
            soma += vet[i];
        }

        double media = soma / n;

        Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

        for (int i = 0; i < n; i++)
        {
            if (vet[i] < media)
            {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
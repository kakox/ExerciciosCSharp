// Arquivo: Exercicio11.cs
using System;
class Exercicio11
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 11 - Soma de dois vetores");

        // entrada de tamanho dos vetores
        Console.WriteLine("Quantos numeros quer que seja? ");
        int n;
        n = int.Parse(Console.ReadLine());
        // criação de vetores
        int[] a = new int[n];
        int[] b = new int[n];
        int[] c = new int[n];

        // entrada de dados do primeiro vetor

        Console.WriteLine("Digite os valores do primeiro vetor utilizando espaço como separador, apos digitar todos os valores pressione enter: ");
        string[] vetA = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(vetA[i]);
        }

        // entrada de dados do segundo vetor
        Console.WriteLine("Digite os valores do segundo vetor utilizando espaço como separador, apos digitar todos os valores pressione enter: ");
        string[] vetB = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++)
        {
            b[i] = int.Parse(vetB[i]);
        }
        // soma do vetor A e B para ser o vetor C 
        for (int i = 0; i < n; i++)
        {
            c[i] = a[i] + b[i];
        }

        // saida do vetor C que são os 2 vetores somados 
        Console.WriteLine("A soma de indice dos vetores anteriores é: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(c[i] + " ");
        }

        Console.WriteLine();
    }
}
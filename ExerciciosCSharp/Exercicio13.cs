// Arquivo: Exercicio13.cs
using System;
using System.Globalization;
class Exercicio13
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 13 - Média dos números pares de um vetor");

        int n;
        Console.WriteLine("Com quantos numeros quer trabalhar? ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite todos os numeros e por fim pressione enter: ");
        int[] vetA = new int[n];
        string[] vetB = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++)
        {
            vetA[i] = int.Parse(vetB[i]);
        }

        int somaPares = 0;
        int contarPares = 0;

        for (int i = 0; i < n; i++)
        {
            if (vetA[i] % 2 == 0)
            {
                somaPares += vetA[i];
                contarPares++;
            }
        }
        if (contarPares > 0)
        {
            double media = (double)somaPares / contarPares;
            Console.WriteLine("A media aritmetica dos numeros pares é: " + media.ToString("F1", CultureInfo.InvariantCulture));

        }
        else
        {
            Console.WriteLine("Nao encontramos numeros pares para somar");
        }
    }
}
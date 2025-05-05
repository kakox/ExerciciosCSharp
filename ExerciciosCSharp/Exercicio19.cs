// Arquivo: Exercicio19.cs
using System;
class Exercicio19
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 19 - Soma por linha de uma matriz");

        int m, n;
        int[,] mat;

        Console.WriteLine("Digite as linhas e colunas da matriz: ");
        string[] aux = Console.ReadLine().Split(' ');
        m = int.Parse(aux[0]);
        n = int.Parse(aux[1]);
        mat = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            aux = Console.ReadLine().Split(' ');

            for (int j = 0; j < n; j++)
            {
                mat[i, j] = int.Parse(aux[j]);
            }
        }

        int[] vet = new int[m];

        for (int i = 0; i < m; i++)
        {
            int soma = 0;
            for (int j = 0; j < n; j++)
            {
                soma = soma + mat[i, j];
            }
            vet[i] = soma;
        }
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine(vet[i]);
        }
    }
}
// Arquivo: Exercicio21.cs
using System;
class Exercicio21
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 21 - Soma dos elementos de uma matriz");

        int n;
        Console.WriteLine("Essa é uma matriz quadrada, portanto digite o numero de linhas e colunas: ");
        n = int.Parse(Console.ReadLine());
        int[,] matriz1 = new int[n, n];
        Console.WriteLine("Digite os valores a serem armazenados na matriz: ");
        for (int i = 0; i < n; i++)
        {
            string[] aux = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matriz1[i, j] = int.Parse(aux[j]);
            }
        }

        for (int i = 0; i < n; i++)
        {
            int somaLinha = 0;
            for (int j = 0; j < n; j++)
            {
                somaLinha += matriz1[i, j];
            }
            Console.WriteLine("A soma da " + (i + 1) + "° linha é: " + somaLinha);

        }

    }
}
// Arquivo: Exercicio23.cs
using System;
class Exercicio23
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 23 - Soma acima da diagonal principal");

        int n;
        Console.WriteLine("Digite o tamanho da matriz quadrada: ");
        n = int.Parse(Console.ReadLine());
        int[,] matriz = new int[n, n];

        Console.WriteLine("Digite os elementos da matriz: ");
        for (int i = 0; i < n; i++)
        {
            string[] aux = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = int.Parse(aux[j]);
            }
        }

        int soma = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i < j)
                {
                    soma += matriz[i, j];
                }
            }
        }
        Console.WriteLine("A soma dos elementos da diagonal principal são: " + soma);
    }
}
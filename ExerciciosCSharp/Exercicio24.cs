// Arquivo: Exercicio24.cs
using System;
class Exercicio24
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 24 - Soma de duas matrizes");

        int m, n;
        Console.WriteLine("Digite a dimensão da matriz (linhas e colunas): ");
        string[] aux = Console.ReadLine().Split(' ');
        m = int.Parse(aux[0]);
        n = int.Parse(aux[1]);

        int[,] matriz1 = new int[m, n];

        Console.WriteLine("Digite os elementos da matriz: ");
        for (int i = 0; i < m; i++)
        {
            string[] aux2 = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matriz1[i, j] = int.Parse(aux2[j]);
            }
        }
        Console.WriteLine("Agora os elementos da segunda matriz: ");
        int[,] matriz2 = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            string[] aux2 = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matriz2[i, j] = int.Parse(aux2[j]);
            }
        }

        int[,] matrizSoma = new int[m, n];
        Console.WriteLine("Essa é a soma das duas matrizes: ");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrizSoma[i, j] = matriz1[i, j] + matriz2[i, j];

                Console.Write(matrizSoma[i, j] + " ");

            }
            Console.WriteLine();

        }
    }
}
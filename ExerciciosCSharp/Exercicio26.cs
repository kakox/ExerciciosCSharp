// Arquivo: Exercicio26.cs
using System;
class Exercicio26
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 26 - Manipulação de fila de soldados");

        int m, n;
        Console.WriteLine("Digite a quantidade de filas: ");
        m = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade de soldados por fila: ");
        n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            string[] aux2 = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = int.Parse(aux2[j]);
            }
        }
        Console.WriteLine("Qual fila deseja girar? ");
        int filaParaGirar = int.Parse(Console.ReadLine()) - 1;

        int[] novaFila = new int[n];
        novaFila[0] = matriz[filaParaGirar, n - 1];

        for (int i = 1; i < n; i++)
        {
            novaFila[i] = matriz[filaParaGirar, i - 1];
        }

        for (int i = 0; i < n; i++)
        {
            matriz[filaParaGirar, i] = novaFila[i];
        }


        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

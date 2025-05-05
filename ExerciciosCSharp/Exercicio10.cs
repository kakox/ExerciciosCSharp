// Arquivo: Exercicio10.cs
using System;
class Exercicio10
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 10 - Exibição de números pares");

        int n;
        n = int.Parse(Console.ReadLine());
        int[] num = new int[n];
        string[] s = Console.ReadLine().Split(' ');

        // Pega os numeros pares 
        Console.Write("Esses são os numeros pares: ");
        for (int i = 0; i < n; i++)
        {
            num[i] = int.Parse(s[i]);
            if (num[i] % 2 == 0)
            {
                Console.Write(num[i] + " ");
            }
        }

        int cont = 0;
        for (int i = 0; i < n; i++)
        {
            if (num[i] % 2 == 0)
            {

                cont++;

            }
        }
        Console.WriteLine();
        Console.WriteLine("Quantidade de numeros pares: " + cont);


    }
}
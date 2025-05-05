// Arquivo: Exercicio8.cs
using System;
class Exercicio8
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 8 - Exemplo de uso do foreach");

        int n;
        n = int.Parse(Console.ReadLine());
        string[] vet = new string[n];

        for (int i = 0; i < n; i++)
        {
            vet[i] = Console.ReadLine();
        }

        Console.WriteLine("Nomes lidos: ");
        foreach (string elemento in vet)
        {
            Console.WriteLine(elemento);
        }
    }
}
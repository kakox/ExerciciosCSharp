﻿// Arquivo: Exercicio4.cs
using System;
class Exercicio4
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 4 - Leitura de 3 valores e exibição do menor");

        int x, y, z;

        string[] vet = Console.ReadLine().Split(' ');

        x = int.Parse(vet[0]);
        y = int.Parse(vet[1]);
        z = int.Parse(vet[2]);

        if (x < y && x < z)
        {
            Console.WriteLine("MENOR = " + x);
        }
        else if (y < z)
        {
            Console.WriteLine("MENOR = " + y);
        }
        else
        {
            Console.WriteLine("MENOR = " + z);
        }

    }
}
// Arquivo: Exercicio5.cs
using System;
class Exercicio5
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 5 - Uso da estrutura switch case");

        int x = int.Parse(Console.ReadLine());
        string dia;

        switch (x)
        {
            case 1:
                dia = "domingo";
                break;

            case 2:
                dia = "segunda";
                break;

            case 3:
                dia = "terça";
                break;

            case 4:
                dia = "quarta";
                break;

            case 5:
                dia = "quinta";
                break;

            case 6:
                dia = "sexta";
                break;

            case 7:
                dia = "sabado";
                break;

            default:
                dia = "valor inválido";
                break;

        }

        Console.WriteLine("Dia da semana: " + dia);
    }
}
// Arquivo: Exercicio6.cs
using System;
using System.Globalization;
class Exercicio6
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Exercício 6 - Exemplo com estrutura while");

        double c, f;
        char repetir;
        do
        {
            Console.WriteLine("Digite a temperatura em Celsius: ");
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f = 9.0 * c / 5.0 + 32;
            Console.WriteLine("Equivalente em Fahrenheit: " + f.ToString("F1", CultureInfo.InvariantCulture));


            Console.WriteLine("Deseja repetir (s/n)? ");
            repetir = char.Parse(Console.ReadLine());
        } while (repetir == 's');
    }
}
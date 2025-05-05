using System;

namespace ExerciciosCSharp
{
    class Program
    {
        static void Main(string[] a)
        {
            int escolha;

            do
            {
                Console.Clear(); // Limpa a tela antes de mostrar o menu

                Console.WriteLine("=== MENU DE EXERCÍCIOS ===\n");
                Console.WriteLine("Escolha um exercício para rodar ou 0 para sair:\n");

                Console.WriteLine("Exercício 1  - Leitura de dados do usuário.");
                Console.WriteLine("Exercício 2  - Cálculo da área de um terreno e valor com base no m².");
                Console.WriteLine("Exercício 3  - Cálculo da área de um retângulo.");
                Console.WriteLine("Exercício 4  - Leitura de 3 valores e exibição do menor.");
                Console.WriteLine("Exercício 5  - Uso da estrutura switch case.");
                Console.WriteLine("Exercício 6  - Exemplo com estrutura while.");
                Console.WriteLine("Exercício 7  - Altura média e percentual de menores de 16 anos.");
                Console.WriteLine("Exercício 8  - Exemplo de uso do foreach.");
                Console.WriteLine("Exercício 9  - Identificação do maior número e sua posição.");
                Console.WriteLine("Exercício 10 - Exibição de números pares.");
                Console.WriteLine("Exercício 11 - Soma de dois vetores e exibição do vetor resultante.");
                Console.WriteLine("Exercício 12 - Média dos elementos e exibição dos abaixo da média.");
                Console.WriteLine("Exercício 13 - Média aritmética dos números pares de um vetor.");
                Console.WriteLine("Exercício 14 - Leitura de nomes e idades e identificação do mais velho.");
                Console.WriteLine("Exercício 15 - Cálculo da média de notas e verificação de aprovação.");
                Console.WriteLine("Exercício 16 - Altura média das mulheres, maior/menor altura e número de homens.");
                Console.WriteLine("Exercício 17 - Cálculo de lucro por produto e totalização.");
                Console.WriteLine("Exercício 18 - Diagonal principal de uma matriz e contagem de números negativos.");
                Console.WriteLine("Exercício 19 - Soma dos elementos de cada linha de uma matriz.");
                Console.WriteLine("Exercício 20 - Impressão de números negativos de uma matriz.");
                Console.WriteLine("Exercício 21 - Soma dos elementos de uma matriz quadrada.");
                Console.WriteLine("Exercício 22 - Maior elemento de cada linha de uma matriz.");
                Console.WriteLine("Exercício 23 - Soma dos elementos acima da diagonal principal.");
                Console.WriteLine("Exercício 24 - Soma de duas matrizes gerando uma terceira.");
                Console.WriteLine("Exercício 25 - Soma dos positivos, leitura de linha/coluna e modificação da matriz.");
                Console.WriteLine("Exercício 26 - Manipulação de filas de soldados, trazendo o último para a frente.");

                Console.Write("\nDigite o número do exercício desejado: ");
                bool valido = int.TryParse(Console.ReadLine(), out escolha);

                if (!valido)
                {
                    Console.WriteLine("\nEntrada inválida. Digite apenas números.");
                    Console.WriteLine("Pressione Enter para continuar...");
                    Console.ReadLine();
                    continue;
                }

                switch (escolha)
                {
                    case 0:
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    case 1:  Exercicio01.Executar(); break;
                    case 2:  Exercicio02.Executar(); break;
                    case 3:  Exercicio03.Executar(); break;
                    case 4:  Exercicio04.Executar(); break;
                    case 5:  Exercicio05.Executar(); break;
                    case 6:  Exercicio06.Executar(); break;
                    case 7:  Exercicio07.Executar(); break;
                    case 8:  Exercicio08.Executar(); break;
                    case 9:  Exercicio09.Executar(); break;
                    case 10: Exercicio10.Executar(); break;
                    case 11: Exercicio11.Executar(); break;
                    case 12: Exercicio12.Executar(); break;
                    case 13: Exercicio13.Executar(); break;
                    case 14: Exercicio14.Executar(); break;
                    case 15: Exercicio15.Executar(); break;
                    case 16: Exercicio16.Executar(); break;
                    case 17: Exercicio17.Executar(); break;
                    case 18: Exercicio18.Executar(); break;
                    case 19: Exercicio19.Executar(); break;
                    case 20: Exercicio20.Executar(); break;
                    case 21: Exercicio21.Executar(); break;
                    case 22: Exercicio22.Executar(); break;
                    case 23: Exercicio23.Executar(); break;
                    case 24: Exercicio24.Executar(); break;
                    case 25: Exercicio25.Executar(); break;
                    case 26: Exercicio26.Executar(); break;
                    default:
                        Console.WriteLine("\nOpção inválida. Tente novamente.");
                        break;
                }

                if (escolha != 0)
                {
                    Console.WriteLine("\nPressione Enter para voltar ao menu...");
                    Console.ReadLine();
                }

            } while (escolha != 0);
        }
    }
}

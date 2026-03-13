// See https://aka.ms/new-console-template for more information
using System;

namespace CalculadoraCheckpoint
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ManterProgramaAtivo = true;

            while (ManterProgramaAtivo)
            {
                Console.Clear();
                Console.WriteLine("Calculadora (Adição / Subtração / Multiplicação / Divisão)");
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1-Adição");
                Console.WriteLine("2-Subtração");
                Console.WriteLine("3-Multiplicação");
                Console.WriteLine("4-Divisão");
                Console.WriteLine("5-Sair");
                Console.Write("\nOpção: ");

                string Opcao = Console.ReadLine();

                if (Opcao == "5")
                {
                    ManterProgramaAtivo = false;
                    Console.WriteLine("Encerrando o programa...");
                    continue;
                }

                // Validação de opção válida
                if (Opcao != "1" && Opcao != "2" && Opcao != "3" && Opcao != "4")
                {
                    Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                    continue;
                }

                try
                {
                    Console.Write("Digite o primeiro número: ");
                    double Numero1 = double.Parse(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    double Numero2 = double.Parse(Console.ReadLine());

                    double Resultado = 0;

                    switch (Opcao)
                    {
                        case "1":
                            Resultado = Numero1 + Numero2;
                            Console.WriteLine($"\nResultado da Adição: {Resultado}");
                            break;
                        case "2":
                            Resultado = Numero1 - Numero2;
                            Console.WriteLine($"\nResultado da Subtração: {Resultado}");
                            break;
                        case "3":
                            Resultado = Numero1 * Numero2;
                            Console.WriteLine($"\nResultado da Multiplicação: {Resultado}");
                            break;
                        case "4":
                            if (Numero2 == 0)
                            {
                                Console.WriteLine("\nErro: Não é possível dividir por zero!");
                            }
                            else
                            {
                                Resultado = Numero1 / Numero2;
                                Console.WriteLine($"\nResultado da Divisão: {Resultado}");
                            }
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nErro: Por favor, digite apenas números válidos.");
                }

                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }
        }
    }
}
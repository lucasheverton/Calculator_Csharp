using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma operação via número: ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("-------------------------------");
            EscolherOperacao();
        }

        static void EscolherOperacao()
        {
            byte operacao = byte.Parse(Console.ReadLine() ?? "0");

            switch (operacao)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Multiplicacao();
                    break;
                case 4:
                    Divisao();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor da operação: ");
            float? v1 = float.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Digite o segundo valor da operação: ");
            float? v2 = float.Parse(Console.ReadLine() ?? "0");

            float? result = v1 + v2;
            Console.WriteLine();

            Console.WriteLine($"O valor da operação soma é: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor da operação: ");
            float? v1 = float.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Digite o segundo valor da operação: ");
            float? v2 = float.Parse(Console.ReadLine() ?? "0");

            float? result = v1 - v2;
            Console.WriteLine();

            Console.WriteLine($"O valor da operação subtração é: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor da operação: ");
            float? v1 = float.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Digite o segundo valor da operação: ");
            float? v2 = float.Parse(Console.ReadLine() ?? "0");

            float? result = v1 * v2;
            Console.WriteLine();

            Console.WriteLine($"O valor da operação multiplicação é: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor da operação: ");
            float? v1 = float.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Digite o segundo valor da operação: ");
            float? v2 = float.Parse(Console.ReadLine() ?? "0");

            float? result = v1 / v2;
            Console.WriteLine();

            Console.WriteLine($"O valor da operação divisão é: {result}");
            Console.ReadKey();
            Menu();
        }
    }
}
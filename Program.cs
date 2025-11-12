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
            Console.WriteLine("5 - Potência");
            Console.WriteLine("6- Sair");
            Console.WriteLine("-------------------------------");
            EscolherOperacao();
        }

        static void EscolherOperacao()
        {
            byte operacao = byte.Parse(Console.ReadLine() ?? "0");

            switch (operacao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Potencia(); break;
                case 6: Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Operacao(string tipoDeOperacao)
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor da operação: ");
            float v1 = float.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Digite o segundo valor da operação: ");
            float v2 = float.Parse(Console.ReadLine() ?? "0");
            float result = 0;

            if (tipoDeOperacao == "soma") result = v1 + v2;
            if (tipoDeOperacao == "subtracao") result = v1 - v2;
            if (tipoDeOperacao == "multiplicacao") result = v1 * v2;
            if (tipoDeOperacao == "divisao") result = v1 / v2;
            if (tipoDeOperacao == "potencia") result = (float)Math.Pow(v1, v2);

            Console.WriteLine();

            Console.WriteLine($"O valor da operação {tipoDeOperacao} é: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Soma()
        {
            Operacao("soma");
        }

        static void Subtracao()
        {
            Operacao("subtracao");
        }

        static void Multiplicacao()
        {
            Operacao("multiplicacao");
        }

        static void Divisao()
        {
            Operacao("divisao");
        }

        static void Potencia()
        {
            Operacao("potencia");
        }
    }
}
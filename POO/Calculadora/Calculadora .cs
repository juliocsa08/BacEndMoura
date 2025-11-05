using System;

namespace Calculadora
{
    public class Calculator
    {
        public double N1;
        public double N2;
        public double Resultado;

        public double Somar()
        {
            if (N1 == 0 && N2 == 0)
            {
                Console.WriteLine("A soma de zero com zero é zero.");
            }

            Resultado = N1 + N2;
            Console.WriteLine("Resultado da soma: " + Resultado);
            return Resultado;
        }

        public double Subtrair()
        {
            if (N1 < N2)
            {
                Console.WriteLine("O resultado da subtração será negativo.");
            }

            Resultado = N1 - N2;
            Console.WriteLine("Resultado da subtração: " + Resultado);
            return Resultado;
        }

        public double Multiplicar()
        {
            if (N1 == 0 || N2 == 0)
            {
                Console.WriteLine("Multiplicação por zero resulta em zero.");
                return 0;
            }

            Resultado = N1 * N2;
            Console.WriteLine("Resultado da Multiplicação: " + Resultado);
            return Resultado;
        }

        public double Dividir()
        {
            if (N2 == 0)
            {
                Console.WriteLine("Não existe divisão por zero.");
                return -1;
            }

            Resultado = N1 / N2;
            Console.WriteLine("Resultado da Divisão: " + Resultado);
            return Resultado;
        }
    }

    class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo à Calculadora!");
            Calculator calc = new Calculator();

            while (true)
            {
                Console.WriteLine("$Menu de Opções:");
                Console.WriteLine("1) Somar");
                Console.WriteLine("2) Subtrair");
                Console.WriteLine("3) Multiplicar");
                Console.WriteLine("4) Dividir");
                Console.WriteLine("5) Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                if (opcao == "5")
                {
                    Console.WriteLine("Obrigado por usar a calculadora. Até mais!");
                    break;
                }

                Console.Write("Digite o primeiro número: ");
                calc.N1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                calc.N2 = double.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case "1":
                        calc.Somar();
                        break;
                    case "2":
                        calc.Subtrair();
                        break;
                    case "3":
                        calc.Multiplicar();
                        break;
                    case "4":
                        calc.Dividir();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();
            // Soma();
            // Subtratacao();
            // Divisao();
            // Multiplicacao();

        }

        static void Menu(){
            Console.Clear();

            Console.WriteLine("Olá, o que deseja fazer? \n");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("0 - Sair \n");

            Console.WriteLine("--------------------------\n");
            Console.WriteLine("Selecione uma opção: ");

            short opcao = short.Parse(Console.ReadLine());

            switch(opcao) {
                case 0: System.Environment.Exit(0);
                break;
                case 1: Soma();
                break;
                case 2: Subtratacao();
                break;
                case 3: Divisao();
                break;
                case 4: Multiplicacao();
                break;
                default: Menu();
                break; 
            }
        }

        static void Soma() {

            Console.Clear();
            Console.WriteLine("Digite o Primeiro Valor: ");
            float numeroUm = float.Parse(Console.ReadLine()); //sempre retorna Strign 
            Console.WriteLine("Digite o Segundo Número:");
            float numeroDois = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float resultado = numeroUm + numeroDois;
            Console.WriteLine("O Resultado da Soma é: " + resultado);
            // Console.WriteLine($"O resultado da Soma é {numeroUm+numeroDois}");
            // Console.WriteLine($"O resultado da Soma é:{numeroUm+numeroDois}");
            // Console.WriteLine("O resultado da Soma é: " + (numeroUm+numeroDois));
            // Console.WriteLine("O resultado da Soma é: " + numeroUm+numeroDois);

            Console.ReadKey();
            Menu();
        }

        static void Subtratacao(){
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro valor:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = num1 - num2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Divisao(){
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = num1/num2;
            Console.WriteLine($"O resultado é {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao(){
            Console.Clear();

            Console.WriteLine("Digite o primeiro número:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = num1 * num2;
            Console.WriteLine($"O resultado é {resultado}");

            Console.ReadKey();
            Menu();
        }

    }
}
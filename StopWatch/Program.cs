using System;

namespace StopWatch
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

            Console.WriteLine("S =  Segundo -> 10s = 10 segundos");
            Console.WriteLine("M =  Minuto -> 1m = 1 minuto");
            Console.WriteLine("0 =  Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower(); // tudo minusculo
            char tipo = char.Parse(data.Substring(data.Length - 1,1)); // pega o último caracter
            int tempo = int.Parse(data.Substring(0,data.Length - 1)); // pega tudo antes do último caracter
            int multiplicador = 1;

            if(tipo == 'm')
                multiplicador=60;

            if(tipo == 0)
                System.Environment.Exit(0);

            PreStart(tempo*multiplicador);
        }

        static void PreStart(int tempo)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(tempo);
        }

        static void Start(int tempo)
        {
            int minutoAtual = 0;

            while(minutoAtual != tempo)
            {
                Console.Clear();
                minutoAtual++;
                Console.WriteLine(minutoAtual);
                Thread.Sleep(1000); // dormiu por 1 segundo
            }

            Console.Clear();
            Console.WriteLine("Stopwatch Finalizado");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
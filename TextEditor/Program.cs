using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            
        }

        static void Menu(){
            Console.Clear();

            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1- Abrir arquivo");
            Console.WriteLine("2- Criar novo arquivo");
            Console.WriteLine("0- Sair");
            short opcao = short.Parse(Console.ReadLine());

            switch(opcao){
                case 0: System.Environment.Exit(0);
                break;
                case 1: Abrir();
                break;
                case 2: Editar();
                break;
                default: Menu();
                break;
            }
        }

        static void Abrir()
        {
            Console.Clear();

            Console.WriteLine("Qual caminho do arquivo?");
            string caminho = Console.ReadLine();

            using(var arquivo = new StreamReader(caminho))
            {
                string text = arquivo.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Editar()
        {
            Console.Clear();

            Console.WriteLine("Digite seu texto abaixo (ESC para sair).");
            Console.WriteLine("---------------------------\n");
            string text = "";

            do 
            {
                text += Console.ReadLine();
                text += Environment.NewLine; // quebrando a linha 
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);
            
        }

        static void Salvar(string text)
        {
            Console.Clear();

            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var caminho = Console.ReadLine();

            using (var arquivo = new StreamWriter(caminho)) // abre e fecha o arquivo no .net
            {
                arquivo.Write(text);
            }

            Console.WriteLine($"Arquivo {caminho} salvo com sucesso!");
            Console.ReadLine();
            Menu();
        }
        
    }
}
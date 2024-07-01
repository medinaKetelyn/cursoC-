using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void Guids()
        {
            var id = Guid.NewGuid(); // identificador global unico - NewGuild gera 
            id.ToString();

            id = new Guid("02c07b11-ad76-4253-951f-b45f8d32734c"); // apresenta o guild
            id.ToString().Substring(0, 8); // só quer os oito primeiros dígitos da string - colocar no console
            Console.WriteLine(id); // transformando em string antes de imprimir na tela
        }

        static void Interpolacao()
        {
            var price = 10.2;
            var texto = "O preço do produto é " + price + " \napenas na promoção";
            //var texto = string.format("o preço do produto é {1} apenas na promoção {0}", price, true);
            //var texto = $"O preço do produto é {price} apenas na promoção";
            //var texto = @"O preço do produto é
            //valor apenas na promoção";
            //var texto = $@"O preço do produto é
            //{price} apenas na promoção";

            Console.WriteLine(texto);
        }
    }
}

using System;
using System.Globalization;

namespace ExercicioFixaçãoImprimir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            // O comando "ToString" serve para definir a quantidade de casas decimais //
            Console.WriteLine(produto1 + ", cujo preço é $ " + preco1.ToString("F2"));
            // O "\r\n" serve para pular linha //
            Console.WriteLine(produto2 + ", cujo preço é $ " + preco2.ToString("F2") + "\r\n");
            Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e gênero: " + genero + "\r\n");
            Console.WriteLine(medida.ToString("F8"));
            Console.WriteLine(medida.ToString("F3"));
            //Precisa da biblioteca "System.Globalization" para utilizar o "CultureInfo"//
            Console.WriteLine(medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

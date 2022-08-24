using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TESTANDO VARIAVEIS E IMPRIMINDO
            string prod1 = "Computador", prod2 = "Mesa de escritório";

            byte ida = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0, preco2 = 550.50, medida = 53.234567;

            Console.WriteLine($"Produtos:\n" +
                $"{prod1}, cujo preço é $ {preco1:F2}\n" +
                $"{prod2}, cujo preço é $ {preco2:F2}\n\n" +
                $"Registro: {ida} anos de idade, código {codigo} e gênero: {genero}\n\n" +
                $"Medida com oito casas decimais: {medida:f8}\n" +
                $"Arredondado (três casa decimais): {medida:f3}\n" +
                $"Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture) + "\n\n\n");


            /* ------------------------------------------------------------- */
        }
    }
}

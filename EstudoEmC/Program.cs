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

            //TESTANDO INPUT E VETOR
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço do produto:");
            double produto = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu ultimo nome, idade e altura:");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine($"\nVocê digitou: {nome}\n{quarto}\n{produto:f2}\n{ultimoNome}\n{idade}\n{altura:f2}");

            /* ------------------------------------------------------------- */

            //SOMA
            Console.WriteLine("\n\nSOMA número 1:");
            double som1 = double.Parse(Console.ReadLine());
            Console.WriteLine("SOMA número 2:");
            double som2 = double.Parse(Console.ReadLine());

            double som3 = som1 + som2;
            Console.WriteLine($"{num1} + {num2} = {num3}");
            
            //SUBTRACAO
            Console.WriteLine("\n\nSUBTRAÇÃO número 1:");
            double sub1 = double.Parse(Console.ReadLine());
            Console.WriteLine("SUBTRAÇÃO número 2:");
            double sub2 = double.Parse(Console.ReadLine());

            double sub3 = sub1 - sub2;
            Console.WriteLine($"{sub1} - {sub2} = {sub3}");

            /* ------------------------------------------------------------- */

            //MULTIPLICACAO
            Console.WriteLine("\n\nMultiplicação número 1:");
            double mult1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Multiplicação número 2:");
            double mult2 = double.Parse(Console.ReadLine());

            double mult3 = mult1 * mult2;
            Console.WriteLine($"{mult1} * {mult2} = {mult3}");
            
            //DIVISAO
            Console.WriteLine("\n\nDivisão número 1:");
            double div1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Divisão número 2:");
            double div2 = double.Parse(Console.ReadLine());

            double div3 = div1 / div2;
            Console.WriteLine($"{div1} / {div2} = {div3}");
            
            /* ------------------------------------------------------------- */

            //AREA DE UM CIRCULO
            Console.WriteLine("\n\nDigite o raio do círculo, para descobirr a área:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pi = 3.14159;
            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}

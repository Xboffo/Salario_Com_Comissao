using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salario, totalDeVendas;


            salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            totalDeVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             salario = salario + (totalDeVendas * 0.15);

            Console.WriteLine("TOTAL = R$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
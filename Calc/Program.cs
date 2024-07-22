using System;

namespace Calculadora
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o primeiro numero: ");
            string input1 = Console.ReadLine();
            Console.Write("Digite o segundo numero: ");
            string input2 = Console.ReadLine();

            if (double.TryParse(input1, out double numero1) && double.TryParse(input2, out double numero2))
            {
                double resultado = Somar(numero1, numero2);
                Console.WriteLine($"A soma de {numero1} e {numero2} é {resultado}.");
            }
            else
            {
                Console.WriteLine("Entrada invalida. Por favor, insira um numero valido");
            }
        }
        public static double Somar(double a, double b)
        {
            return a + b;
        }
    }
}
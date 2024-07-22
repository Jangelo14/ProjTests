using System;
using Xunit;
using Calculadora;

namespace Calctests;
{
    public class CalculadoraTests
    {
        [Fact]
        public void Somar_DeveLancarExcecaoParaEntradasInvalidas()
        {
            string input1 = "abc";
            string input2 = "xyz";

            Assert.Throws<FormatException>(() =>
            {
                if(!double.TryParse(input1, out double numero1) || !double.TryParse(input2, out double numero2))
                {
                    throw new FormatException("Entrada invalida");
                }
                Program.Somar(numero1, numero2);
            });
        }
    }
}
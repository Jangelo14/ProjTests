using System;
using Xunit;
using Calculadora;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        [Fact] // Divisao por zero
        public void Calcular()
        {
            string input1 = "10";
            string input2 = "0";
            string operacao = "/";

            Assert.Throws<DivideByZeroException>(() => Program.Calcular(input1, input2, operacao));
        }
    }
}
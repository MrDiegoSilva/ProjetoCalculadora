using Xunit;

namespace CalculadoraTeste
{
    public class CalculadoraTeste
    {
        [Fact]
        public void DeveSomarOsValoresCorretamente()
        {
            //Arrange
            int primeiroValor = 1;
            int segundoValor = 2;


            //Act
            Calculadora.Calculadora calculadora = new Calculadora.Calculadora();
            var resultado = calculadora.Somar(primeiroValor, segundoValor);

            //Asset
            Assert.Equal(3, resultado);
        }

        [Fact]
        public void DeveSubtrairOsValoresCorretamente()
        {
            //Arrange
            int primeiroValor = 10;
            int segundoValor = 2;


            //Act
            Calculadora.Calculadora calculadora = new Calculadora.Calculadora();
            var resultado = calculadora.Subtrair(primeiroValor, segundoValor);

            //Asset
            Assert.Equal(8, resultado);
        }

        [Fact]
        public void DeveMultiplicarOsValoresCorretamente()
        {
            //Arrange
            int primeiroValor = 10;
            int segundoValor = 2;


            //Act
            Calculadora.Calculadora calculadora = new Calculadora.Calculadora();
            var resultado = calculadora.Multiplicar(primeiroValor, segundoValor);

            //Asset
            Assert.Equal(20, resultado);
        }

        [Fact]
        public void DeveDividirOsValoresCorretamente()
        {
            //Arrange
            int primeiroValor = 10;
            int segundoValor = 2;


            //Act
            Calculadora.Calculadora calculadora = new Calculadora.Calculadora();
            var resultado = calculadora.Dividir(primeiroValor, segundoValor);

            //Asset
            Assert.Equal(5, resultado);
        }
    }
}

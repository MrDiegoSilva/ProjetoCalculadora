using System;

namespace Calculadora
{
    public class Calculadora
    {
        public int Somar(int primeiroValor, int segundoValor)
        {
            return primeiroValor + segundoValor;
        }

        public int Subtrair(int primeiroValor, int segundoValor)
        {
            return primeiroValor - segundoValor;
        }

        public int Multiplicar(int primeiroValor, int segundoValor)
        {
            return primeiroValor * segundoValor;
        }

        public decimal Dividir(int primeiroValor, int segundoValor)
        {
            return primeiroValor / segundoValor;
        }
    }
}

using NewTalents;

namespace TesteNewTalent
{
    public class UnitTest1
    {
        public Calculadora construirClasse()
        {
            string data = "09/04/2024";
            Calculadora calc = new Calculadora(data);

            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestSoma(int valor1, int valor2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.somar(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(3,2,1)]
        [InlineData(9,5,4)]
        public void TestSubtrair(int valor1, int valor2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.subtrair(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(3, 2, 6)]
        [InlineData(9, 5, 45)]
        public void TestMultiplicar(int valor1, int valor2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.multiplicar(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(10,2,5)]
        [InlineData(45, 5, 9)]
        public void TestDividir(int valor1, int valor2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.dividir(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPor0()
        {
            Calculadora calc = construirClasse();
            Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse();
            calc.somar(1, 2);
            calc.subtrair(3, 2);
            calc.multiplicar(2, 3);
            calc.dividir(4, 2);

            var lista = calc.historico();
            Assert.NotEmpty(lista);
            Assert.Equal(3,lista.Count);
        }
    }
}
using ProjetoTesteFS;
using Xunit;

namespace TestXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {   // Padr�o 3A

            // Arrange - Prepara��o
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Act - A��o
            var resultado = Operacoes.Somar(pNum, sNum);

            // Assert - Verifica��o
            Assert.Equal(rNum, resultado);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 1, 2)]

        public void SomarDoisListas(double pNum, double sNum, double rNum)
        {
            // Act - A��o
            var resultado = Operacoes.Somar(pNum, sNum);

            // Assert - Verifica��o
            Assert.Equal(rNum, resultado);
        }
    }
}
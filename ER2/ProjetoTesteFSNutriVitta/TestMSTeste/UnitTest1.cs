using Microsoft.VisualStudio.TestTools.UnitTesting; //Referencia de Projeto
using ProjetoTesteFS;

namespace TestMSTeste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {   // Padr�o 3A

            // Arrange - Prepara��o
            double pNum = 1; // Primeiro n�mero
            double sNum = 1; // Segundo n�mero
            double rNum = 2; // Resultado

            //Act - A��o
            var resultado = Operacoes.Somar(pNum, sNum);

            // Assert - Verifica��o
            Assert.AreEqual(rNum, resultado);
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 1, 2)] // Errado para verificar

        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            // Act - A��o
            var resultado = Operacoes.Somar(pNum, sNum);

            // Assert - Verifica��o
            Assert.AreEqual(rNum, resultado);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting; //Referencia de Projeto
using ProjetoTesteFS;

namespace TestMSTeste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {   // Padrão 3A

            // Arrange - Preparação
            double pNum = 1; // Primeiro número
            double sNum = 1; // Segundo número
            double rNum = 2; // Resultado

            //Act - Ação
            var resultado = Operacoes.Somar(pNum, sNum);

            // Assert - Verificação
            Assert.AreEqual(rNum, resultado);
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 1, 2)] // Errado para verificar

        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            // Act - Ação
            var resultado = Operacoes.Somar(pNum, sNum);

            // Assert - Verificação
            Assert.AreEqual(rNum, resultado);
        }
    }
}
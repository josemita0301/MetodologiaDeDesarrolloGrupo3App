using MetodologiaDeDesarrolloGrupo3App.Models;
using NUnit.Framework;

namespace MetodologiaDeDesarrolloGrupo3App.Testing
{
    [TestFixture]
    public class CalculadoraTest
    {
        private Calculadora _calculadora;

        [SetUp]
        public void Setup()
        {
            _calculadora = new Calculadora();
        }

        [Test]
        public void Sumar_DosNumeros_RetornaLaSuma()
        {
            // Arrange
            int numero1 = 5;
            int numero2 = 10;

            // Act
            int resultado = _calculadora.Sumar(numero1, numero2);

            // Assert
            Assert.Equals(15, resultado);
        }

        // Aquí puedes añadir más pruebas para diferentes escenarios
    }

}

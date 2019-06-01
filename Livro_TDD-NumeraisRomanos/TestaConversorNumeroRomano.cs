using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Livro_TDD_NumeraisRomanos
{
    [TestClass]
    public class TestaConversorNumeroRomano
    {
        [TestMethod]
        public void DeveEntenderOSimboloI()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();

            int numero = romano.Converte("I");

            Assert.AreEqual(1, numero);
        }

        [TestMethod]
        public void DeveEntenderOSimboloV()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();

            int numero = romano.Converte("V");

            Assert.AreEqual(5, numero);
        }

        [TestMethod]
        public void DeveEntenderOSimboloX()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();

            int numero = romano.Converte("X");

            Assert.AreEqual(10, numero);
        }

        [TestMethod]
        public void DeveEntenderOSimboloL()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();

            int numero = romano.Converte("L");

            Assert.AreEqual(50, numero);
        }

        [TestMethod]
        public void DeveEntenderOSimboloC()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();

            int numero = romano.Converte("C");

            Assert.AreEqual(100, numero);
        }

        [TestMethod]
        public void DeveEntenderOSimboloD()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();

            int numero = romano.Converte("D");

            Assert.AreEqual(500, numero);
        }

        [TestMethod]
        public void DeveEntenderOSimboloM()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();

            int numero = romano.Converte("M");

            Assert.AreEqual(1000, numero);
        }

        //testa números escrita com duas letras iguais
        [TestMethod]
        public void DeveEntenderDoisSimbolosComoII()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();

            int numero = romano.Converte("II");

            Assert.AreEqual(2, numero);
        }
        
        //testa números escrito com letras diferentes escritas juntas
        [TestMethod]
        public void DeveEntenderNumerosComoIX()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();

            int numero = romano.Converte("IX");

            Assert.AreEqual(9, numero);
        }

        //testa números formados por pares iguais de letras
        [TestMethod]
        public void DeveEntenderQuatroSimbolosDoisADoisComoXXII()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();

            int numero = romano.Converte("XXII");

            Assert.AreEqual(22, numero);
        }

        //testa números complexos que não são escritos aos pares
        [TestMethod]
        public void DeveEntenderNumerosComplexosComoXXIV()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();

            int numero = romano.Converte("XXIV");

            Assert.AreEqual(24, numero);
        }

        [TestMethod]
        public void DeveRetornarZeroSeForEnviadoAlgoDiferenteDosAlgarismosRomanos()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();

            int numero = romano.Converte("");

            Assert.AreEqual(0, numero);
        }

        //trecho comentado devido ao método validaEntrada estar private
        //[TestMethod]
        //public void DeveRetornarFalseSeEntradaForInvalida()
        //{
        //    ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();

        //    bool teste = romano.validaEntrada("8");

        //    Assert.AreEqual(false, teste);
        //}
    }
}

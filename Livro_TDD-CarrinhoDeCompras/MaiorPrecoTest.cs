using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Livro_TDD_CarrinhoDeCompras
{
    [TestClass]
    public class MaiorPrecoTest
    {
        [TestMethod]
        public void DeveRetornarZeroSeCarrinhoVazio()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            /** Uso da Classe MaiorPreco - OBSOLETO**/
            //MaiorPreco algoritmo = new MaiorPreco();
            //double valor = algoritmo.Encontra(carrinho);
            //Assert.AreEqual(0.0, valor, 0.0001);

            Assert.AreEqual(0.0, carrinho.MaiorValor(), 0.0001);
        }

        [TestMethod]
        public void DeveRetornarValorDoItemSeCarrinhoCom1Elemento()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Item("Geladeira", 1, 900.0));

            /** Uso da Classe MaiorPreco - OBSOLETO**/
            //MaiorPreco algoritmo = new MaiorPreco();
            //double valor = algoritmo.Encontra(carrinho);
            //Assert.AreEqual(900.0, valor, 0.0001);

            Assert.AreEqual(900.0, carrinho.MaiorValor(), 0.0001);
        }

        [TestMethod]
        public void DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Item("Geladeira", 1, 900.0));
            carrinho.Adiciona(new Item("Fogão", 1, 1500.0));
            carrinho.Adiciona(new Item("Máquina de Lavar", 1, 750.0));

            /** Uso da Classe MaiorPreco - OBSOLETO**/
            //MaiorPreco algoritmo = new MaiorPreco();
            //double valor = algoritmo.Encontra(carrinho);
            //Assert.AreEqual(1500.0, valor, 0.0001);

            Assert.AreEqual(1500.0, carrinho.MaiorValor(), 0.0001);
        }
    }
}

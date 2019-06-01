using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Livro_TDD_MaiorEMenor
{
    [TestClass]
    public class TesteMaiorEMenor
    {
        [TestMethod]
        public void OrdemDecrescenteDeProdutos()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Geladeira", 450.0));
            carrinho.Adiciona(new Produto("Liquidificador", 250.0));
            carrinho.Adiciona(new Produto("Jogo de pratos", 70.0));

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual("Jogo de pratos",
            algoritmo.Menor.Nome);
            Assert.AreEqual("Geladeira",
            algoritmo.Maior.Nome);
        }

        [TestMethod]
        public void OrdemCrescenteDeProdutos()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Jogo de pratos", 70.0));
            carrinho.Adiciona(new Produto("Liquidificador", 250.0));            
            carrinho.Adiciona(new Produto("Geladeira", 450.0));           

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual("Jogo de pratos",
            algoritmo.Menor.Nome);
            Assert.AreEqual("Geladeira",
            algoritmo.Maior.Nome);
        }

        [TestMethod]
        public void QualquerOrdemDeProdutos()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Liquidificador", 250.0));
            carrinho.Adiciona(new Produto("Jogo de pratos", 70.0));            
            carrinho.Adiciona(new Produto("Geladeira", 450.0));
            carrinho.Adiciona(new Produto("Fogão", 100.0));
            carrinho.Adiciona(new Produto("Notebook", 200.0));

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual("Jogo de pratos",
            algoritmo.Menor.Nome);
            Assert.AreEqual("Geladeira",
            algoritmo.Maior.Nome);
        }

        [TestMethod]
        public void CarrinhoComApenasUmProduto()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            carrinho.Adiciona(new Produto("Geladeira", 450.0));

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual("Geladeira", algoritmo.Menor.Nome);
            Assert.AreEqual("Geladeira", algoritmo.Maior.Nome);
        }
    }
}

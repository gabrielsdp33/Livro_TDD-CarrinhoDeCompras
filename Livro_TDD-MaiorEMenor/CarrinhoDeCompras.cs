using System;
using System.Collections.Generic;
using System.Text;

namespace Livro_TDD_MaiorEMenor
{
    class CarrinhoDeCompras
    {
        public List<Produto> Produtos { get; private set; }

        public CarrinhoDeCompras()
        {
            Produtos = new List<Produto>();
        }

        public void Adiciona(Produto produto)
        {
            Produtos.Add(produto);
        }
    }
}

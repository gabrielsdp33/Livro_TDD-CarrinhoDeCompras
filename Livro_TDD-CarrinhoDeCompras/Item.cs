using System;
using System.Collections.Generic;
using System.Text;

namespace Livro_TDD_CarrinhoDeCompras
{
    class Item
    {
        public string Descricao { get; private set; }
        public int Quantidade { get; private set; }
        public double ValorUnitario { get; private set; }

        public Item(String descricao, int quantidade, double valorUnitario)
        {
            this.Descricao = descricao;
            this.Quantidade = quantidade;
            this.ValorUnitario = valorUnitario;
        }

        public double ValorTotal
        {
            get
            {
                return this.ValorUnitario * Quantidade;
            }
        }
    }
}

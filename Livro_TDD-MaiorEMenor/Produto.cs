using System;
using System.Collections.Generic;
using System.Text;

namespace Livro_TDD_MaiorEMenor
{
    class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Produto()
        {

        }

        public Produto(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}

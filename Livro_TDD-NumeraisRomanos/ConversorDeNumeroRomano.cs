using System;
using System.Collections.Generic;
using System.Text;

namespace Livro_TDD_NumeraisRomanos
{
    class ConversorDeNumeroRomano
    {
        private Dictionary<string, int> tabela = new Dictionary<string, int>()
        {
            {"I", 1 },
            {"V", 5 },
            {"X", 10 },
            {"L", 50 },
            {"C", 100 },
            {"D", 500 },
            {"M", 1000 }

        };

        public int Converte(string numeroEmRomano)
        {
            int acumulador = 0;
            int ultimoVizinhoDaDireita = 0;

            for(int i = numeroEmRomano.Length - 1; i >= 0; i--)            { 
                
                //valida se é um algarismo romano válido
                if (validaEntrada(numeroEmRomano[i]))
                {
                    //pega o inteiro referente ao simbolo atual
                    int atual = tabela[numeroEmRomano[i].ToString()];

                    //se o da direitafor menor, o multiplicaremos
                    //por -1 para torná-lo negativo
                    int multiplicador = 1;
                    if (atual < ultimoVizinhoDaDireita) multiplicador = -1;

                    acumulador += atual * multiplicador;

                    //atualiza o vizinho da direita
                    ultimoVizinhoDaDireita = atual;
                }
            }
            return acumulador;
        }

        private bool validaEntrada(char letra)
        {
            bool letraValida = false;

            if (tabela.ContainsKey(letra.ToString()))
            {
                letraValida = true;
            }

            return letraValida;

        }
        
    }
}

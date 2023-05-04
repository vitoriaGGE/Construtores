﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Produto
{
    internal class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {

            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }

        public double ValorTotalEmEstoque()
        {

            return Preco * Quantidade;

        }

        public void AdicionarProdutos(int quantidade)
        {

            Quantidade = Quantidade + quantidade;

        }

        public void RemoverProdutos(int quantidade)
        {

            Quantidade = Quantidade - quantidade;

        }

        public override string ToString()
        {

            return Nome + ", $" + Preco.ToString("F2") + ", " + Quantidade + " Unidades, Total: $" + ValorTotalEmEstoque().ToString("F2");

        }

    }
}
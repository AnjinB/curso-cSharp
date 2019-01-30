﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Loja
{
    class Global
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        public int Adcionar;
        public int Excluir;

        public Global()
        {
        }

        public Global(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;

        }
        public Global(string nome, double preco, int quantidade) : this(nome, preco)
        {

            Quantidade = quantidade;

        }


        public Double ValorTotal()
        {
            return Preco * Quantidade;
        }
        public void AdcionaProduto(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }
        public void ExcluirProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " Unidades, total: $ "
                + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}

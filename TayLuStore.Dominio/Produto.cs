using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TayLuStore.Dominio
{
    public class Produto :EntidadeBase
    {
        public Produto(string nome, string descricao, decimal valor, int quantEstoque, int id)
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            QuantEstoque = quantEstoque;
            Id = id;
            AtivarUsuario();
        }

        public string  Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; } = 0;
        public int QuantEstoque { get; private set; }

        public void DebitarEstoque(int quantidade)
        {
            if(quantidade < 0)
            {
                quantidade *= -1;
            }
            QuantEstoque -= quantidade;
        }

        public void ReporEstoque(int quantidade)
        {
            QuantEstoque += quantidade;
        }

        public int QuantidadeEstoque()
        {
            return QuantEstoque;
        }

        public bool PossuiEstoque()
        {
            if(QuantEstoque > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}

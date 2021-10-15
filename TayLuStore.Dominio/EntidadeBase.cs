using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TayLuStore.Dominio
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set;  }
        protected bool Ativo { get; set; } = true;

        public bool DesativarUsuario() => Ativo = false;
        public bool AtivarUsuario() => Ativo;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TayLuStore.Dominio
{
    public class Perfil : EntidadeBase
    {
        public Perfil(string descricao, string regras, int id, DateTime dataCadastro)
        {
            Descricao = descricao;
            Regras = regras;
            Id = id;
            DataCadastro = DateTime.Now;
            AtivarUsuario();
        }

        public string Descricao { get; set; }
        public string Regras { get; set; }
    }
}

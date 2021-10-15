using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TayLuStore.Dominio
{
    public class Usuario: EntidadeBase
    {
        public Usuario(string nome, int id, string email, string senha, int perfilId)
        {
            Nome = nome;
            Id = id;
            Email = email;
            Senha = senha;
            PerfilId = perfilId;
            AtivarUsuario();
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int PerfilId { get; set; }
        public Perfil Perfil { get; set; }

    }
}

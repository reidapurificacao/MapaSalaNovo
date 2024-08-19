using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.entidades
{
    public class UsuariosEntidade
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public Object[] Linha()
        {
            return new object[] { Id,Login,Senha,Nome,Ativo };
        }
    }
}

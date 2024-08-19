using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.view_model
{
    public class UsuariosView
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public string ativo(bool ativo)
        {
            if (ativo)
            {
                return "Ativado";
            }
            else
            {
                return "desativado";
            }
        }
    }
}

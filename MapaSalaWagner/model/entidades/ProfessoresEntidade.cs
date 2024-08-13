using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.entidades
{
    public class ProfessoresEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public Object[] Linha()
        {
            return new object[] { Id, Nome, Apelido };
        }
    }
}

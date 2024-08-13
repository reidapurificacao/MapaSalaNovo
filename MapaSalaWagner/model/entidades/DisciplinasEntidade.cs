using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.entidades
{
    public class DisciplinasEntidade
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public string sigla { get; set; }
        public bool ativo { get; set; }
        public Object[] Linha()
        {
            return new object[] { ID, nome, sigla, ativo };
        }
    }
}
